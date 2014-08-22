using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;

namespace Services
{
    public class GerenciadorGrupoPlanoDeContas
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorGrupoPlanoDeContas()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorGrupoPlanoDeContas(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="grupoModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(GrupoPlanoDeContasModel grupoModel)
        {
            tb_grupoplanocontas grupoE = new tb_grupoplanocontas();
            Atribuir(grupoModel, grupoE);
            unitOfWork.RepositorioGrupoPlanoContas.Inserir(grupoE);
            unitOfWork.Commit(shared);
            return grupoE.IdGrupoPlanoDeConta;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="grupoModel"></param>
        public void Editar(GrupoPlanoDeContasModel grupoModel)
        {
            tb_grupoplanocontas grupoE = new tb_grupoplanocontas();
            Atribuir(grupoModel, grupoE);
            unitOfWork.RepositorioGrupoPlanoContas.Editar(grupoE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idTipoPlanoDeConta"> </param>
        public void Remover(int idGrupoPlanoDeConta)
        {
            unitOfWork.RepositorioGrupoPlanoContas.Remover(gp => gp.IdGrupoPlanoDeConta == idGrupoPlanoDeConta);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados da entidade como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<GrupoPlanoDeContasModel> GetQuery()
        {
            IQueryable<tb_grupoplanocontas> tb_grupoplanocontas = unitOfWork.RepositorioGrupoPlanoContas.GetQueryable();
            var query = from grupoPlanoDeConta in tb_grupoplanocontas
                        select new GrupoPlanoDeContasModel
                        {
                            IdGrupoPlanoDeConta = grupoPlanoDeConta.IdGrupoPlanoDeConta,
                            TipoPlanoDeConta = (grupoPlanoDeConta.TipoPlanoDeConta == "Receita" ? ListaTipoPlanoConta.Receita : ListaTipoPlanoConta.Despesa),
                            Descricao = grupoPlanoDeConta.Descricao
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<GrupoPlanoDeContasModel> ObterTodos()
        {
            return GetQuery();
        }


        /// <summary>
        /// Obtém um grupoPlanoDeConta
        /// </summary>
        /// <param name="idTipoPlanoDeConta">Identificador da entidade na base de dados</param>
        /// <returns>GrupoPlanoDeContasModel</returns>
        public GrupoPlanoDeContasModel Obter(int idGrupoPlanoDeConta)
        {
            IEnumerable<GrupoPlanoDeContasModel> grupoE = GetQuery().Where(gp => gp.IdGrupoPlanoDeConta == idGrupoPlanoDeConta);
            return grupoE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados da Entidade Model para a Entidade Entity
        /// </summary>
        /// <param name="grupoModel">Objeto do modelo</param>
        /// <param name="grupoE">Entity mapeada da base de dados</param>
        private void Atribuir(GrupoPlanoDeContasModel grupoModel, tb_grupoplanocontas grupoE)
        {
            grupoE.IdGrupoPlanoDeConta = grupoModel.IdGrupoPlanoDeConta;
            grupoE.TipoPlanoDeConta = grupoModel.TipoPlanoDeConta.ToString();
            grupoE.Descricao = grupoModel.Descricao;
        }
    }
}

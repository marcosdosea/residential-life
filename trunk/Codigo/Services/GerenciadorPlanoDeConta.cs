using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;

namespace Services
{
    /// <summary>
    /// Gerencia todas as regras de negócio da entidade PlanoDeConta
    /// </summary>

    public class GerenciadorPlanoDeConta
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorPlanoDeConta()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorPlanoDeConta(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="planoDeContaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(PlanoDeContaModel planoDeContaModel)
        {
            tb_planodeconta planoDeContaE = new tb_planodeconta();
            Atribuir(planoDeContaModel, planoDeContaE);
            unitOfWork.RepositorioPlanoDeConta.Inserir(planoDeContaE);
            unitOfWork.Commit(shared);
            return planoDeContaE.IdPlanoDeConta;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="planoDeContaModel">Dados do modelo</param>
        public void Editar(PlanoDeContaModel planoDeContaModel)
        {
            tb_planodeconta planoDeContaE = new tb_planodeconta();
            Atribuir(planoDeContaModel, planoDeContaE);
            unitOfWork.RepositorioPlanoDeConta.Editar(planoDeContaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idPlanoDeConta">Identificador do planoDeConta na base de dados</param>
        public void Remover(int idPlanoDeConta)
        {
            unitOfWork.RepositorioPlanoDeConta.Remover(planoDeConta => planoDeConta.IdPlanoDeConta == idPlanoDeConta);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do planoDeConta como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<PlanoDeContaModel> GetQuery()
        {
            IQueryable<tb_planodeconta> tb_planodeconta = unitOfWork.RepositorioPlanoDeConta.GetQueryable();
            var query = from planoDeConta in tb_planodeconta
                        select new PlanoDeContaModel
                        {
                            IdPlanoDeConta = planoDeConta.IdPlanoDeConta,
                            Descricao = planoDeConta.Descricao,
                            IdGrupoPlanoDeConta = planoDeConta.tb_grupoplanocontas.IdGrupoPlanoDeConta,
                            DescricaoGrupoPlanoContas = planoDeConta.tb_grupoplanocontas.Descricao
                        };
            return query;
        }


        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PlanoDeContaModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um planoDeConta
        /// </summary>
        /// <param name="idPlanoDeConta">Identificador do planoDeConta na base de dados</param>
        /// <returns>PlanoDeConta model</returns>
        public PlanoDeContaModel Obter(int idPlanoDeConta)
        {
            IEnumerable<PlanoDeContaModel> planoDeContaE = GetQuery().Where(planoDeContaModel => planoDeContaModel.IdPlanoDeConta == idPlanoDeConta);
            return planoDeContaE.ElementAtOrDefault(0);
        }


        /// <summary>
        /// Atribui dados do PlanoDeConta Model para o PlanoDeConta Entity
        /// </summary>
        /// <param name="planoDeContaModel">Objeto do modelo</param>
        /// <param name="planoDeContaE">Entity mapeada da base de dados</param>
        private void Atribuir(PlanoDeContaModel planoDeContaModel, tb_planodeconta planoDeContaE)
        {
            planoDeContaE.IdPlanoDeConta = planoDeContaModel.IdPlanoDeConta;
            planoDeContaE.Descricao = planoDeContaModel.Descricao;
            planoDeContaE.IdTipoPlanoDeConta = planoDeContaModel.IdGrupoPlanoDeConta;
        }
    }
}

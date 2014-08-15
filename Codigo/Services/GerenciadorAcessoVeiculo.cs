using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;

namespace Services
{
    public class GerenciadorAcessoVeiculo
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorAcessoVeiculo()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorAcessoVeiculo(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="PostagemModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(AcessoVeiculoModel acessoPredioModel)
        {
            tb_acessoveiculo acessoVeiculoE = new tb_acessoveiculo();
            Atribuir(acessoPredioModel, acessoVeiculoE);
            unitOfWork.RepositorioAcessoVeiculo.Inserir(acessoVeiculoE);
            unitOfWork.Commit(shared);
            return acessoVeiculoE.IdAcessoVeiculo;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="acessoPredio"></param>
        public void Editar(AcessoVeiculoModel acessoPredioModel)
        {
            tb_acessoveiculo acessoVeiculoE = new tb_acessoveiculo();
            Atribuir(acessoPredioModel, acessoVeiculoE);
            unitOfWork.RepositorioAcessoVeiculo.Editar(acessoVeiculoE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="AcessoVeiculoModel"> Dados do modelo</param>
        public void Remover(int idAcessoVeiculo)
        {
            unitOfWork.RepositorioAcessoVeiculo.Remover(AcessoVeiculo => AcessoVeiculo.IdAcessoVeiculo.Equals(idAcessoVeiculo));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do autor como model
        /// </summary>
        /// <returns></returns>
        /// 
        private IQueryable<AcessoVeiculoModel> GetQuery()
        {
            IQueryable<tb_acessoveiculo> tb_acessoveiculo = unitOfWork.RepositorioAcessoVeiculo.GetQueryable();
            var query = from AcessoVeiculo in tb_acessoveiculo
                        select new AcessoVeiculoModel
                        {
                            IdAcessoVeiculo = AcessoVeiculo.IdAcessoVeiculo,
                            IdVeiculo = AcessoVeiculo.IdVeiculo,
                            Data = AcessoVeiculo.DataHora,
                            PlacaVeiculo = AcessoVeiculo.tb_veiculo.Placa,
                            TipoAcesso = (AcessoVeiculo.TipoAcesso == "Entrada" ? ListaTipoAcesso.Entrada : ListaTipoAcesso.Saida)
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AcessoVeiculoModel> ObterTodos()
        {
            return GetQuery().OrderBy(ac => ac.PlacaVeiculo);
        }

        /// <summary>
        /// Obtém um autor
        /// </summary>
        /// <param name="idPostagem">Identificador da postagem na base de dados</param>
        /// <returns>Autor model</returns>
        public AcessoVeiculoModel Obter(int idAcessoVeiculo)
        {
            IEnumerable<AcessoVeiculoModel> AcessoVeiculoModelmE = GetQuery().Where(AcessoVeiculo => AcessoVeiculo.IdAcessoVeiculo.Equals(idAcessoVeiculo));
            return AcessoVeiculoModelmE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Autor Model para o postagem Entity
        /// </summary>
        /// <param name="PostagemModel">Objeto do modelo</param>
        /// <param name="PostagemE">Entity mapeada da base de dados</param>
        private void Atribuir(AcessoVeiculoModel AcessoVeiculoModel, tb_acessoveiculo AcessoVeiculoE)
        {
            AcessoVeiculoE.IdAcessoVeiculo = AcessoVeiculoModel.IdAcessoVeiculo;
            AcessoVeiculoE.IdVeiculo = AcessoVeiculoModel.IdVeiculo;
            AcessoVeiculoE.DataHora = AcessoVeiculoModel.Data;
            AcessoVeiculoE.TipoAcesso = AcessoVeiculoModel.TipoAcesso.ToString();

        }
    }
}

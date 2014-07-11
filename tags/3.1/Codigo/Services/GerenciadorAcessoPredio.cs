using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Persistence;
using Models.Models;

namespace Services
{
    public class GerenciadorAcessoPredio
    {
        /*
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorAcessoPredio()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorAcessoPredio(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="PostagemModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(AcessoPredioModel acessoPredioModel)
        {
            tb_acessopredio acessoPredioE = new tb_acessopredio();
            Atribuir(acessoPredioModel, acessoPredioE);
            unitOfWork.RepositorioAcessoPredio.Inserir(acessoPredioE);
            unitOfWork.Commit(shared);
            return acessoPredioE.IdAcessoPredio;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="acessoPredio"></param>
        public void Editar(AcessoPredioModel acessoPredioModel)
        {
            tb_acessopredio acessoPredioE = new tb_acessopredio();
            Atribuir(acessoPredioModel, acessoPredioE);
            unitOfWork.RepositorioAcessoPredio.Editar(acessoPredioE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="AcessoPredioModel"> Dados do modelo</param>
        public void Remover(int idAcessoPredio)
        {
            unitOfWork.RepositorioAcessoPredio.Remover(AcessoPredio => AcessoPredio.IdAcessoPredio.Equals(idAcessoPredio));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do autor como model
        /// </summary>
        /// <returns></returns>
        /// 
        private IQueryable<AcessoPredioModel> GetQuery()
        {
            IQueryable<tb_acessopredio> tb_acessopredio = unitOfWork.RepositorioAcessoPredio.GetQueryable();
            var query = from AcessoPredio in tb_acessopredio
                        select new AcessoPredioModel
                        {
                            IdAcesoPredio = AcessoPredio.IdAcessoPredio,
                            IdPessoa = AcessoPredio.IdPessoa,
                            DataEntrada = AcessoPredio.DataEntrada,
                            DataSaida = AcessoPredio.DataSaida,
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AcessoPredioModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AcessoPredioModel> ObterTodosPorPessoa(int idPessoa)
        {
            return GetQuery().Where(AcessoPredio => AcessoPredio.IdPessoa.Equals(idPessoa));
        }

        /// <summary>
        /// Obtém um autor
        /// </summary>
        /// <param name="idPostagem">Identificador da postagem na base de dados</param>
        /// <returns>Autor model</returns>
        public AcessoPredioModel Obter(int idAcessoPredio)
        {
            IEnumerable<AcessoPredioModel> AcessoPredioModelmE = GetQuery().Where(AcessoPredio => AcessoPredio.IdAcesoPredio.Equals(idAcessoPredio));
            return AcessoPredioModelmE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Autor Model para o postagem Entity
        /// </summary>
        /// <param name="PostagemModel">Objeto do modelo</param>
        /// <param name="PostagemE">Entity mapeada da base de dados</param>
        private void Atribuir(AcessoPredioModel AcessoPredioModel, tb_acessopredio AcessoPredioE)
        {
            AcessoPredioE.IdAcessoPredio = AcessoPredioModel.IdAcesoPredio;
            AcessoPredioE.IdPessoa = AcessoPredioModel.IdPessoa;
            AcessoPredioE.DataEntrada = AcessoPredioModel.DataEntrada;
            AcessoPredioE.DataSaida = AcessoPredioModel.DataSaida;

        }*/
    }
}

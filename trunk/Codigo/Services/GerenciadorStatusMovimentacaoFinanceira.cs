using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorStatusMovimentacaoFinanceira
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorStatusMovimentacaoFinanceira()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorStatusMovimentacaoFinanceira(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo veiculo na base de dados
        /// </summary>
        /// <param name="statusMovimentacaoFinanceiraModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(StatusMovimentacaoFinanceiraModel statusMovimentacaoFinanceiraModel)
        {
            tb_statusmovimentacaofinanceira statusMovimentacaoFinanceiraModelE = new tb_statusmovimentacaofinanceira();
            Atribuir(statusMovimentacaoFinanceiraModel, statusMovimentacaoFinanceiraModelE);
            unitOfWork.RepositorioStatusMovimentacaoFinanceira.Inserir(statusMovimentacaoFinanceiraModelE);
            unitOfWork.Commit(shared);
            return statusMovimentacaoFinanceiraModelE.IdStatusMovimentacaoFinanceira;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="statusMovimentacaoFinanceiraModel">Dados do modelo</param>
        public void Editar(StatusMovimentacaoFinanceiraModel statusMovimentacaoFinanceiraModel)
        {
            tb_statusmovimentacaofinanceira statusMovimentacaoFinanceiraModelE = new tb_statusmovimentacaofinanceira();
            Atribuir(statusMovimentacaoFinanceiraModel, statusMovimentacaoFinanceiraModelE);
            unitOfWork.RepositorioStatusMovimentacaoFinanceira.Editar(statusMovimentacaoFinanceiraModelE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idStatusMovimentacaoFinanceira">Identificador do status na base de dados</param>
        public void Remover(int idStatusMovimentacaoFinanceira)
        {
            unitOfWork.RepositorioStatusMovimentacaoFinanceira.Remover(StatusMovimentacaoFinanceira => StatusMovimentacaoFinanceira.IdStatusMovimentacaoFinanceira.Equals(idStatusMovimentacaoFinanceira));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do statusmovimentacaofinanceira como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<StatusMovimentacaoFinanceiraModel> GetQuery()
        {
            IQueryable<tb_statusmovimentacaofinanceira> tb_statusmovimentacaofinanceira = unitOfWork.RepositorioStatusMovimentacaoFinanceira.GetQueryable();
            var query = from StatusMovimentacaoFinanceira in tb_statusmovimentacaofinanceira
                        select new StatusMovimentacaoFinanceiraModel
                        {
                            IdStatusMovimentacaoFinanceira = StatusMovimentacaoFinanceira.IdStatusMovimentacaoFinanceira,
                            StatusMovimentacaoFinanceira = StatusMovimentacaoFinanceira.StatusMovimentacaoFinanceira
                           
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<StatusMovimentacaoFinanceiraModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um tipo de plano de conta
        /// </summary>
        /// <param name="idStatusMovimentacaoFinanceira">Identificador do tipo de plano de conta na base de dados</param>
        /// <returns>StatusMovimentacaoFinanceira model</returns>
        public StatusMovimentacaoFinanceiraModel Obter(int idStatusMovimentacaoFinanceira)
        {
            IEnumerable<StatusMovimentacaoFinanceiraModel> statusMovimentacaoFinanceiraEs = GetQuery().Where(StatusMovimentacaoFinanceira => StatusMovimentacaoFinanceira.IdStatusMovimentacaoFinanceira.Equals(idStatusMovimentacaoFinanceira));
            return statusMovimentacaoFinanceiraEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do status StatusMovimentacaoFinanceira Model para o StatusMovimentacaoFinanceira Entity
        /// </summary>
        /// <param name="statusMovimentacaoFinanceiraModel">Objeto do modelo</param>
        /// <param name="statusMovimentacaoFinanceiraE">Entity mapeada da base de dados</param>
        private void Atribuir(StatusMovimentacaoFinanceiraModel statusMovimentacaoFinanceiraModel, tb_statusmovimentacaofinanceira statusMovimentacaoFinanceiraE)
        {
            statusMovimentacaoFinanceiraE.IdStatusMovimentacaoFinanceira = statusMovimentacaoFinanceiraModel.IdStatusMovimentacaoFinanceira;
            statusMovimentacaoFinanceiraE.StatusMovimentacaoFinanceira = statusMovimentacaoFinanceiraModel.StatusMovimentacaoFinanceira;
        }
    }
}

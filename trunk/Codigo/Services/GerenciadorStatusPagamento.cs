using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorStatusPagamento
    {
        /*
       private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorStatusPagamento()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorStatusPagamento(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="statusPagamentoModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(StatusPagamentoModel statusPagamentoModel)
        {
            tb_statuspagamento statusPagamentoE = new tb_statuspagamento();
            Atribuir(statusPagamentoModel, statusPagamentoE);
            unitOfWork.RepositorioStatusPagamento.Inserir(statusPagamentoE);
            unitOfWork.Commit(shared);
            return statusPagamentoE.IdStatusPagamento;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="enqueteModel">Dados do modelo</param>
        public void Editar(StatusPagamentoModel statusPagamentoModel)
        {
            tb_statuspagamento statusPagamentoE = new tb_statuspagamento();
            Atribuir(statusPagamentoModel, statusPagamentoE);
            unitOfWork.RepositorioStatusPagamento.Editar(statusPagamentoE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="statusPagamentoModel">Identificador do pagamento na base de dados</param>
        public void Remover(int idStatusPagamento)
        {
            unitOfWork.RepositorioStatusPagamento.Remover(statusPagamento => statusPagamento.IdStatusPagamento.Equals(idStatusPagamento));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do statusenquete como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<StatusPagamentoModel> GetQuery()
        {
            IQueryable<tb_statuspagamento> tb_statuspagamento = unitOfWork.RepositorioStatusPagamento.GetQueryable();
            var query = from statusPagamento in tb_statuspagamento
                        select new StatusPagamentoModel
                        {
                            IdStatusPagamento = statusPagamento.IdStatusPagamento,
                            StatusPagamento = statusPagamento.StatusPagamento
                           
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<StatusPagamentoModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um pagamento
        /// </summary>
        /// <param name="idStatusPagamento">Identificador do pagamento na base de dados</param>
        /// <returns>Pagamento model</returns>
        public StatusPagamentoModel Obter(int idStatusPagamento)
        {
            IEnumerable<StatusPagamentoModel> statusPagamentoEs = GetQuery().Where(statusPagamento => statusPagamento.IdStatusPagamento.Equals(idStatusPagamento));
            return statusPagamentoEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do status Pagamento Model para o Pagamento Entity
        /// </summary>
        /// <param name="statusPagamentoModel">Objeto do modelo</param>
        /// <param name="statusPagamentoE">Entity mapeada da base de dados</param>
        private void Atribuir(StatusPagamentoModel statusPagamentoModel, tb_statuspagamento statusPagamentoE)
        {
            statusPagamentoE.IdStatusPagamento = statusPagamentoModel.IdStatusPagamento;
            statusPagamentoE.StatusPagamento = statusPagamentoModel.StatusPagamento;
         
   
        } */
    }
}

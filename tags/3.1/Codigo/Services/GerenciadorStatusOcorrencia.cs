
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorStatusOcorrencia
    {
        /*
       private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorStatusOcorrencia()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorStatusOcorrencia(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="statusOcorrenciaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(StatusOcorrenciaModel statusOcorrenciaModel)
        {
            tb_statusocorrencia statusOcorrenciaModelE = new tb_statusocorrencia();
            Atribuir(statusOcorrenciaModel, statusOcorrenciaModelE);
            unitOfWork.RepositorioStatusOcorrencia.Inserir(statusOcorrenciaModelE);
            unitOfWork.Commit(shared);
            return statusOcorrenciaModelE.IdStatusOcorrencia;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="enqueteModel">Dados do modelo</param>
        public void Editar(StatusOcorrenciaModel statusOcorrenciaModel)
        {
            tb_statusocorrencia statusOcorrenciaModelE = new tb_statusocorrencia();
            Atribuir(statusOcorrenciaModel, statusOcorrenciaModelE);
            unitOfWork.RepositorioStatusOcorrencia.Editar(statusOcorrenciaModelE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="statusPagamentoModel">Identificador do pagamento na base de dados</param>
        public void Remover(int idStatusOcorrencia)
        {
            unitOfWork.RepositorioStatusOcorrencia.Remover(statusOcorrencia => statusOcorrencia.IdStatusOcorrencia.Equals(idStatusOcorrencia));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do statusenquete como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<StatusOcorrenciaModel> GetQuery()
        {
            IQueryable<tb_statusocorrencia> tb_statusocorrencia = unitOfWork.RepositorioStatusOcorrencia.GetQueryable();
            var query = from statusOcorrencia in tb_statusocorrencia
                        select new StatusOcorrenciaModel
                        {
                            IdStatusOcorrencia = statusOcorrencia.IdStatusOcorrencia,
                            StatusOcorrencia = statusOcorrencia.StatusOcorrencia
                           
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<StatusOcorrenciaModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um pagamento
        /// </summary>
        /// <param name="idStatusOcorrencia">Identificador do pagamento na base de dados</param>
        /// <returns>Pagamento model</returns>
        public StatusOcorrenciaModel Obter(int idStatusOcorrencia)
        {
            IEnumerable<StatusOcorrenciaModel> statusOcorrenciaEs = GetQuery().Where(statusOcorrencia => statusOcorrencia.IdStatusOcorrencia.Equals(idStatusOcorrencia));
            return statusOcorrenciaEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do status Pagamento Model para o Pagamento Entity
        /// </summary>
        /// <param name="statusPagamentoModel">Objeto do modelo</param>
        /// <param name="statusPagamentoE">Entity mapeada da base de dados</param>
        private void Atribuir(StatusOcorrenciaModel statusOcorrenciaModel, tb_statusocorrencia statusOcorrenciaE)
        {
            statusOcorrenciaE.IdStatusOcorrencia = statusOcorrenciaModel.IdStatusOcorrencia;
            statusOcorrenciaE.StatusOcorrencia = statusOcorrenciaModel.StatusOcorrencia;
         
   
        }*/
    }
}

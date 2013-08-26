using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorStatusEnquete
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorStatusEnquete()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorStatusEnquete(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="statusEnqueteModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(StatusEnqueteModel statusEnqueteModel)
        {
            tb_statusenquete statusEnqueteE = new tb_statusenquete();
            Atribuir(statusEnqueteModel, statusEnqueteE);
            unitOfWork.RepositorioStatusEnquete.Inserir(statusEnqueteE);
            unitOfWork.Commit(shared);
            return statusEnqueteE.IdStatusEnquete;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="enqueteModel">Dados do modelo</param>
        public void Editar(StatusEnqueteModel statusEnqueteModel)
        {
            tb_statusenquete statusEnqueteE = new tb_statusenquete();
            Atribuir(statusEnqueteModel, statusEnqueteE);
            unitOfWork.RepositorioStatusEnquete.Editar(statusEnqueteE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="statusEnqueteModel">Identificador do enquete na base de dados</param>
        public void Remover(int idStatusEnquete)
        {
            unitOfWork.RepositorioStatusEnquete.Remover(statusEnquete => statusEnquete.IdStatusEnquete.Equals(idStatusEnquete));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do statusenquete como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<StatusEnqueteModel> GetQuery()
        {
            IQueryable<tb_statusenquete> tb_statusenquete = unitOfWork.RepositorioStatusEnquete.GetQueryable();
            var query = from statusEnquete in tb_statusenquete
                        select new StatusEnqueteModel
                        {
                            idStatusEnquete = statusEnquete.IdStatusEnquete,
                            StatusEnquete = statusEnquete.StatusEnquete
                           
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<StatusEnqueteModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um enquete
        /// </summary>
        /// <param name="idStatusEnquete">Identificador do enquete na base de dados</param>
        /// <returns>Enquete model</returns>
        public StatusEnqueteModel Obter(int idStatusEnquete)
        {
            IEnumerable<StatusEnqueteModel> statusEnqueteEs = GetQuery().Where(enqueteModel => enqueteModel.idStatusEnquete.Equals(idStatusEnquete));
            return statusEnqueteEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do status Enquete Model para o Enquete Entity
        /// </summary>
        /// <param name="statusEnqueteModel">Objeto do modelo</param>
        /// <param name="statusEnqueteE">Entity mapeada da base de dados</param>
        private void Atribuir(StatusEnqueteModel statusEnqueteModel, tb_statusenquete statusEnqueteE)
        {
            statusEnqueteE.IdStatusEnquete = statusEnqueteModel.idStatusEnquete;
            statusEnqueteE.StatusEnquete = statusEnqueteModel.StatusEnquete;
         
   
        }
    }
}

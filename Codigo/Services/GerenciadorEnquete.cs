using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    public class GerenciadorEnquete
    {
        /*
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorEnquete()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorEnquete(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="enqueteModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(EnqueteModel enqueteModel )
        {
            tb_enquete enqueteE = new tb_enquete();
            tb_opcoesenquete opcoesEnqueteE = new tb_opcoesenquete();

            Atribuir(enqueteModel, enqueteE);
            unitOfWork.RepositorioEnquete.Inserir(enqueteE);

            unitOfWork.Commit(shared);
            
            return enqueteE.IdEnquete;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="enqueteModel">Dados do modelo</param>
        public void Editar(EnqueteModel enqueteModel)
        {
            tb_enquete enqueteE = new tb_enquete();
            Atribuir(enqueteModel, enqueteE);
            unitOfWork.RepositorioEnquete.Editar(enqueteE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="enqueteModel">Identificador do enquete na base de dados</param>
        public void Remover(int idEnquete)
        {
            unitOfWork.RepositorioOpcaoEnquete.Remover(opcao => opcao.IdEnquete.Equals(idEnquete));
            unitOfWork.RepositorioEnquete.Remover(enquete => enquete.IdEnquete.Equals(idEnquete));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do enquete como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<EnqueteModel> GetQuery()
        {
            IQueryable<tb_enquete> tb_enquete = unitOfWork.RepositorioEnquete.GetQueryable();
            var query = from enquete in tb_enquete
                        select new EnqueteModel
                        {
                            IdEnquete = enquete.IdEnquete,
                            IdPessoa = enquete.IdPesssoa,
                            Titulo = enquete.Titulo,
                            Descricao = enquete.Descricao,
                            DataInicio = enquete.DataInicio,
                            DataFim = enquete.DataFim,
                            IdStatusEnquete = enquete.IdStatusEnquete,
                            StatusEnquete  = enquete.tb_statusenquete.StatusEnquete,
                            NomeCriador = enquete.tb_pessoa.Nome
                            
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EnqueteModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obter todos as enquetes marcadas como finalizada
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EnqueteModel> ObterEnquetesFinalizadas()
        {
            return GetQuery().Where(enquete => enquete.StatusEnquete.Contains("Fechada"));
        }

        /// <summary>
        /// Obter todos as enquetes não marcadas como finalizada
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EnqueteModel> ObterEnquetesAtivas()
        {
            return GetQuery().Where(enquete => !enquete.StatusEnquete.Contains("Fechada"));
        }


        /// <summary>
        /// Obtém um enquete
        /// </summary>
        /// <param name="idEnquete">Identificador do enquete na base de dados</param>
        /// <returns>Enquete model</returns>
        public EnqueteModel Obter(int idEnquete)
        {
            IEnumerable<EnqueteModel> enqueteEs = GetQuery().Where(enqueteModel => enqueteModel.IdEnquete.Equals(idEnquete));
            return enqueteEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Enquete Model para o Enquete Entity
        /// </summary>
        /// <param name="enqueteModel">Objeto do modelo</param>
        /// <param name="enqueteE">Entity mapeada da base de dados</param>
        private void Atribuir(EnqueteModel enqueteModel, tb_enquete enqueteE)
        {
            enqueteE.IdEnquete = enqueteModel.IdEnquete;
            enqueteE.IdPesssoa = enqueteModel.IdPessoa;
            enqueteE.Titulo = enqueteModel.Titulo;
            enqueteE.Descricao = enqueteModel.Descricao;
            enqueteE.DataInicio = enqueteModel.DataInicio;
            enqueteE.DataFim = enqueteModel.DataFim;
            enqueteE.IdStatusEnquete = enqueteModel.IdStatusEnquete;
           
        }*/
    }
}

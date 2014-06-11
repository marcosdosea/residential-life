using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistence;
using Models.Models;
using Models;

namespace Services
{
    /// <summary>
    /// Gerencia todas as regras de negócio da entidade Status Area Publica
    /// </summary>

    public class GerenciadorStatusAreaPublica
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorStatusAreaPublica()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorStatusAreaPublica(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="AreaPublicaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(StatusAreaPublicaModel StatusAreaPublicaModel)
        {
            tb_statusareapublica StatusAreaPublicaE = new tb_statusareapublica();
            Atribuir(StatusAreaPublicaModel, StatusAreaPublicaE);
            unitOfWork.RepositorioStatusAreaPublica.Inserir(StatusAreaPublicaE);
            unitOfWork.Commit(shared);
            return StatusAreaPublicaE.IdStatusAreaPublica;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="AreaPublicaModel"></param>
        public void Editar(StatusAreaPublicaModel StatusAreaPublicaModel)
        {
            tb_statusareapublica StatusAreaPublicaE = new tb_statusareapublica();
            Atribuir(StatusAreaPublicaModel, StatusAreaPublicaE);
            unitOfWork.RepositorioStatusAreaPublica.Editar(StatusAreaPublicaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="AreaPublicaModel"> Dados do modelo</param>
        public void Remover(int idStatusAreaPublica)
        {
            unitOfWork.RepositorioStatusAreaPublica.Remover(StatusAreaPublica => StatusAreaPublica.IdStatusAreaPublica.Equals(idStatusAreaPublica));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do autor como model
        /// </summary>
        /// <returns></returns>
        /// 
        private IQueryable<StatusAreaPublicaModel> GetQuery()
        {
            IQueryable<tb_statusareapublica> tb_StatusAreaPublica = unitOfWork.RepositorioStatusAreaPublica.GetQueryable();
            var query = from StatusAreaPublica in tb_StatusAreaPublica
                        select new StatusAreaPublicaModel
                        {
                            IdStatusAreaPublica = StatusAreaPublica.IdStatusAreaPublica,                           
                            Status= StatusAreaPublica.StatusAreaPublica,                                                      
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<StatusAreaPublicaModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um autor
        /// </summary>
        /// <param name="idAutor">Identificador do autor na base de dados</param>
        /// <returns>Autor model</returns>
        public StatusAreaPublicaModel Obter(int idStatusAreaPublica)
        {
            IEnumerable<StatusAreaPublicaModel> StatusAreaPublicaE = GetQuery().Where(StatusAreaPublicaModel => StatusAreaPublicaModel.IdStatusAreaPublica.Equals(idStatusAreaPublica));
            return StatusAreaPublicaE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Autor Model para o Autor Entity
        /// </summary>
        /// <param name="AreaPublicaModel">Objeto do modelo</param>
        /// <param name="AreaPublicaE">Entity mapeada da base de dados</param>
        private void Atribuir(StatusAreaPublicaModel StatusAreaPublicaModel, tb_statusareapublica StatusAreaPublicaE)
        {
            StatusAreaPublicaE.IdStatusAreaPublica = StatusAreaPublicaModel.IdStatusAreaPublica;
            StatusAreaPublicaE.StatusAreaPublica = StatusAreaPublicaModel.Status;
           
        }
    }
}

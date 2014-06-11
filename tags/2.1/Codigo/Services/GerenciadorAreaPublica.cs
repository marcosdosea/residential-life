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
    /// Gerencia todas as regras de negócio da entidade Area Publica
    /// </summary>

    public class GerenciadorAreaPublica
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorAreaPublica()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorAreaPublica(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="AreaPublicaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(AreaPublicaModel AreaPublicaModel)
        {
            tb_areapublica AreaPublicaE = new tb_areapublica();
            Atribuir(AreaPublicaModel, AreaPublicaE);
            unitOfWork.RepositorioAreaPublica.Inserir(AreaPublicaE);
            unitOfWork.Commit(shared);
            return AreaPublicaE.IdAreaPublica;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="AreaPublicaModel"></param>
        public void Editar(AreaPublicaModel AreaPublicaModel)
        {
            tb_areapublica AreaPublicaE = new tb_areapublica();
            Atribuir(AreaPublicaModel, AreaPublicaE);
            unitOfWork.RepositorioAreaPublica.Editar(AreaPublicaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="AreaPublicaModel"> Dados do modelo</param>
        public void Remover(int idAreaPublica)
        {
            unitOfWork.RepositorioAreaPublica.Remover(AreaPublica => AreaPublica.IdAreaPublica.Equals(idAreaPublica));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do autor como model
        /// </summary>
        /// <returns></returns>
        /// 
        private IQueryable<AreaPublicaModel> GetQuery()
        {
            IQueryable<tb_areapublica> tb_AreaPublica = unitOfWork.RepositorioAreaPublica.GetQueryable();
            var query = from AreaPublica in tb_AreaPublica
                        select new AreaPublicaModel
                        {
                            IdAreaPublica = AreaPublica.IdAreaPublica,
                            IdCondominio = AreaPublica.IdCondominio,
                            IdStatusAreaPublica = AreaPublica.IdStatusAreaPublica,
                            Nome = AreaPublica.Nome,
                            Local = AreaPublica.Local,
                            Tamanho = AreaPublica.Tamanho,
                            ValorReserva = AreaPublica.ValorReserva,
                            StatusAreaPublica = AreaPublica.tb_statusareapublica.StatusAreaPublica,
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AreaPublicaModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um autor
        /// </summary>
        /// <param name="idAutor">Identificador do autor na base de dados</param>
        /// <returns>Autor model</returns>
        public AreaPublicaModel Obter(int idAreaPublica)
        {
            IEnumerable<AreaPublicaModel> AreaPublicaE = GetQuery().Where(AreaPublicaModel => AreaPublicaModel.IdAreaPublica.Equals(idAreaPublica));
            return AreaPublicaE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Autor Model para o Autor Entity
        /// </summary>
        /// <param name="AreaPublicaModel">Objeto do modelo</param>
        /// <param name="AreaPublicaE">Entity mapeada da base de dados</param>
        private void Atribuir(AreaPublicaModel AreaPublicaModel, tb_areapublica AreaPublicaE)
        {
            AreaPublicaE.IdAreaPublica = AreaPublicaModel.IdAreaPublica;
            AreaPublicaE.IdCondominio = AreaPublicaModel.IdCondominio;
            AreaPublicaE.Nome = AreaPublicaModel.Nome;
            AreaPublicaE.Local = AreaPublicaModel.Local;
            AreaPublicaE.Tamanho = AreaPublicaModel.Tamanho;
            AreaPublicaE.ValorReserva = AreaPublicaModel.ValorReserva;
            AreaPublicaE.IdStatusAreaPublica = AreaPublicaModel.IdStatusAreaPublica;
        }
    }
}

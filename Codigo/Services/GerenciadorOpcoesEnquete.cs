using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;

namespace Services
{
    public class GerenciadorOpcaoEnquete
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorOpcaoEnquete()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorOpcaoEnquete(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="opcaoModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(OpcaoModel opcaoModel, int id_enquete)
        {
            tb_opcoesenquete opcoesEnqueteE = new tb_opcoesenquete();

            opcaoModel.IdEnquete = id_enquete;

            Atribuir(opcaoModel, opcoesEnqueteE);
            unitOfWork.RepositorioOpcaoEnquete.Inserir(opcoesEnqueteE);

             unitOfWork.Commit(shared);
             return opcoesEnqueteE.IdOpcao;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="opcaoModel">Dados do modelo</param>
        public void Editar(OpcaoModel opcaoModel)
        {
            tb_opcoesenquete opcaoE = new tb_opcoesenquete();
            Atribuir(opcaoModel, opcaoE);
            unitOfWork.RepositorioOpcaoEnquete.Editar(opcaoE);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="opcaoModel">Identificador do opcao na base de dados</param>
        public void Remover(int idOpcaoEnquete)
        {
            unitOfWork.RepositorioOpcaoEnquete.Remover(opcao => opcao.IdOpcao.Equals(idOpcaoEnquete));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do opcao como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<OpcaoModel> GetQuery()
        {
            IQueryable<tb_opcoesenquete> tb_opcao = unitOfWork.RepositorioOpcaoEnquete.GetQueryable();
            var query = from opcao in tb_opcao
                        select new OpcaoModel
                        {
                            IdOpcao = opcao.IdOpcao,
                            IdEnquete = opcao.IdEnquete,
                            Descricao = opcao.Descricao

                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OpcaoModel> ObterTodos()
        {
            return GetQuery();
        }

        public IEnumerable<OpcaoModel> ObterOpcoesEnquete(int id)
        {
            return GetQuery().Where(opcoes => opcoes.IdEnquete.Equals(id));
        }


        
        /// <summary>
        /// Obtém um opcao
        /// </summary>
        /// <param name="idOpcaoEnquete">Identificador do opcao na base de dados</param>
        /// <returns>OpcaoEnquete model</returns>
        public OpcaoModel Obter(int idOpcaoEnquete)
        {
            IEnumerable<OpcaoModel> opcaoEs = GetQuery().Where(opcaoModel => opcaoModel.IdOpcao.Equals(idOpcaoEnquete));
            return opcaoEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do OpcaoEnquete Model para o OpcaoEnquete Entity
        /// </summary>
        /// <param name="opcaoModel">Objeto do modelo</param>
        /// <param name="opcaoE">Entity mapeada da base de dados</param>
        internal void Atribuir(OpcaoModel opcaoModel, tb_opcoesenquete opcaoE)
        {
            opcaoE.IdOpcao= opcaoModel.IdOpcao;
            opcaoE.IdEnquete = opcaoModel.IdEnquete;
            opcaoE.Descricao = opcaoModel.Descricao;
           

        }
    }
}

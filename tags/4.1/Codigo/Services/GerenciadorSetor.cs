using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;

namespace Services
{
    /// <summary>
    /// Gerencia todas as regras de negócio da entidade Setor
    /// </summary>

    public class GerenciadorSetor
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorSetor()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorSetor(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="setorModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(SetorModel setorModel)
        {
            tb_setor setorE = new tb_setor();
            Atribuir(setorModel, setorE);
            unitOfWork.RepositorioSetor.Inserir(setorE);
            unitOfWork.Commit(shared);
            return setorE.IdSetor;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="setorModel">Dados do modelo</param>
        public void Editar(SetorModel setorModel)
        {
            tb_setor setorE = new tb_setor();
            Atribuir(setorModel, setorE);
            unitOfWork.RepositorioSetor.Editar(setorE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idSetor">Identificador do setor na base de dados</param>
        public void Remover(int idSetor)
        {
            unitOfWork.RepositorioSetor.Remover(setor => setor.IdSetor == idSetor);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do setor como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<SetorModel> GetQuery()
        {
            IQueryable<tb_setor> tb_setor = unitOfWork.RepositorioSetor.GetQueryable();
            var query = from setor in tb_setor
                        select new SetorModel
                        {
                            IdSetor = setor.IdSetor,
                            Nome = setor.Nome,
                            Descricao = setor.Descricao
                        };
            return query;
        }


        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SetorModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um setor
        /// </summary>
        /// <param name="idSetor">Identificador do setor na base de dados</param>
        /// <returns>Setor model</returns>
        public SetorModel Obter(int idSetor)
        {
            IEnumerable<SetorModel> setorE = GetQuery().Where(setorModel => setorModel.IdSetor == idSetor);
            return setorE.ElementAtOrDefault(0);
        }



        /// <summary>
        /// Atribui dados do Setor Model para o Setor Entity
        /// </summary>
        /// <param name="setorModel">Objeto do modelo</param>
        /// <param name="setorE">Entity mapeada da base de dados</param>
        private void Atribuir(SetorModel setorModel, tb_setor setorE)
        {
            setorE.IdSetor = setorModel.IdSetor;
            setorE.Nome = setorModel.Nome;
            setorE.Descricao = setorModel.Descricao;
        }
    }
}

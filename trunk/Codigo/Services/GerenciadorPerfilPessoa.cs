using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;

namespace Services
{
    public class GerenciadorPerfilPessoa
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorPerfilPessoa()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorPerfilPessoa(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="perfilPessoa">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public void Inserir(PerfilPessoaModel perfilPessoa)
        {
            tb_perfilpessoa perfilPessoaE = new tb_perfilpessoa();
            Atribuir(perfilPessoa, perfilPessoaE);
            unitOfWork.RepositorioPerfilPessoa.Inserir(perfilPessoaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="perfilPessoa">Dados do modelo</param>
        public void Editar(PerfilPessoaModel perfilPessoa)
        {
            tb_perfilpessoa perfilPessoaE = new tb_perfilpessoa();
            Atribuir(perfilPessoa, perfilPessoaE);
            unitOfWork.RepositorioPerfilPessoa.Editar(perfilPessoaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idPerfil">Identificador do perfil na base de dados</param>
        /// <param name="idPessoa">Identificador do pessoa na base de dados</param>
        public void Remover(int idPerfil, int idPessoa)
        {
            unitOfWork.RepositorioPerfilPessoa.Remover(p => p.IdPerfil.Equals(idPerfil) && p.IdPessoa.Equals(idPessoa));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do perfil como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<PerfilPessoaModel> GetQuery()
        {
            IQueryable<tb_perfilpessoa> tb_perfilpessoa = unitOfWork.RepositorioPerfilPessoa.GetQueryable();
            var query = from perfilPessoa in tb_perfilpessoa
                        select new PerfilPessoaModel
                        {
                            IdPerfil = perfilPessoa.IdPerfil,
                            IdPessoa = perfilPessoa.IdPessoa,
                            Ativo = perfilPessoa.Ativo,

                            CPF = perfilPessoa.tb_pessoa.CPF,
                            NomePessoa = perfilPessoa.tb_pessoa.Nome,
                            RG = perfilPessoa.tb_pessoa.RG,

                            Perfil = perfilPessoa.my_aspnet_roles.name
                        };
            return query;
        }


        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PerfilPessoaModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um perfil
        /// </summary>
        /// <param name="idPerfil">Identificador do perfil na base de dados</param>
        /// <returns>Pontuacao model</returns>
        public PerfilPessoaModel Obter(int idPerfil, int idPessoa)
        {
            IEnumerable<PerfilPessoaModel> perfilPessoaE = GetQuery().Where(p => p.IdPerfil.Equals(idPerfil) && 
                p.IdPessoa.Equals(idPessoa));
            return perfilPessoaE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtem todas as pessoas com perfil de funcionario ou profissional
        /// </summary>
        /// <returns>Lista com profissionais e funcionarios</returns>
        public IEnumerable<PerfilPessoaModel> ObterProfissionaisEFuncionariosAtivos()
        {
            IEnumerable<PerfilPessoaModel> perfilPessoaE = GetQuery().Where(p => (p.IdPerfil.Equals(Global.IdPerfilProfissional) ||
                p.IdPerfil.Equals(Global.IdPerfilFuncionario)) && p.Ativo == true);
            return perfilPessoaE;
        }


        /// <summary>
        /// Atribui dados do Setor Model para o Setor Entity
        /// </summary>
        /// <param name="perfilPessoa">Objeto do modelo</param>
        /// <param name="perfilPessoaE">Entity mapeada da base de dados</param>
        private void Atribuir(PerfilPessoaModel perfilPessoa, tb_perfilpessoa perfilPessoaE)
        {
            perfilPessoaE.IdPerfil = perfilPessoa.IdPerfil;
            perfilPessoaE.IdPessoa = perfilPessoa.IdPessoa;
            perfilPessoaE.Ativo = perfilPessoaE.Ativo;
        }
    }
}

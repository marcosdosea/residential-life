using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;


namespace Services
{
    /// <summary>
    /// Gerencia todas as regras de negócio da entidade Autor
    /// </summary>
    
    public class GerenciadorPessoa
    {
        private static GerenciadorPessoa gPessoa;

        private IUnitOfWork unitOfWork;
        private bool shared;

        public static GerenciadorPessoa GetInstance()
        {
            if (gPessoa == null)
            {
                gPessoa = new GerenciadorPessoa();
            }
            return gPessoa;
        }

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorPessoa()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorPessoa(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="pessoaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(PessoaModel pessoaModel)
        {
            tb_pessoa pessoaE = new tb_pessoa();
            Atribuir(pessoaModel, pessoaE);
            unitOfWork.RepositorioPessoa.Inserir(pessoaE);
            unitOfWork.Commit(shared);
            return pessoaE.IdPessoa;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="pessoaModel"></param>
        public void Editar(PessoaModel pessoaModel)
        {
            tb_pessoa pessoaE = new tb_pessoa(); 
            Atribuir(pessoaModel, pessoaE);
            unitOfWork.RepositorioPessoa.Editar(pessoaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="pessoaModel"> </param>
        public void Remover(int idPes)
        {
            unitOfWork.RepositorioPessoa.Remover(pessoa => pessoa.IdPessoa.Equals(idPes));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados da entidade como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<PessoaModel> GetQuery()
        {
            IQueryable<tb_pessoa> tb_pessoa = unitOfWork.RepositorioPessoa.GetQueryable();
            var query = from pessoa in tb_pessoa 
                        select new PessoaModel
                        {
                            IdPessoa = pessoa.IdPessoa,
                            IdUser = pessoa.IdUser,
                            IdSetor = pessoa.IdSetor,
                            Bairro = pessoa.Bairro,
                            CEP = pessoa.CEP,
                            Cidade = pessoa.Cidade,
                            Complemento = pessoa.Complemento,
                            CPF = pessoa.CPF,
                            Estado = pessoa.Estado,
                            Nome = pessoa.Nome,
                            Numero = pessoa.Numero,
                            RG = pessoa.RG,
                            Rua = pessoa.Rua,
                            Sexo = pessoa.Sexo,
                            TelefoneCelular = pessoa.TelefoneCelular,
                            TelefoneFixo = pessoa.TelefoneFixo,

                            NomeUsuario = pessoa.my_aspnet_users.name,
                            NomeSetor = pessoa.tb_setor.Nome
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PessoaModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obter todos as entidades cadastradas ordenado por CPF
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PessoaModel> ObterTodosPorCPF()
        {
            return GetQuery().OrderBy(p => p.CPF);
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public bool existePessoa(int id)
        {
            if (GetQuery().Where(pessoa => pessoa.IdPessoa.Equals(id)).Count() > 0)
                return true;
            else
                return false;
            
        }


        /// <summary>
        /// Obtém uma pessoa
        /// </summary>
        /// <param name="idPessoa">Identificador da entidade na base de dados</param>
        /// <returns>Autor model</returns>
        public PessoaModel Obter(int idPessoa)
        {
            IEnumerable<PessoaModel> pessoaE = GetQuery().Where(pessoaModel => pessoaModel.IdPessoa.Equals(idPessoa));
            return pessoaE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtem a partir do id do usuario logada uma pessoa
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns>Pessoa Logada no sistema</returns>
        public PessoaModel ObterPessoaLogada(int idUser)
        {
            IEnumerable<PessoaModel> pessoaE = GetQuery().Where(pessoaModel => pessoaModel.IdUser == idUser);
            return pessoaE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtem a partir do id do usuario logada uma pessoa
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns>Pessoa Logada no sistema</returns>
        public PessoaModel ObterPessoaLogadaUser(string UserName)
        {
            IEnumerable<PessoaModel> pessoaE = GetQuery().Where(pessoaModel => pessoaModel.NomeUsuario == UserName);
            return pessoaE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados da Entidade Model para a Entidade Entity
        /// </summary>
        /// <param name="pessoaModel">Objeto do modelo</param>
        /// <param name="pessoaE">Entity mapeada da base de dados</param>
        private void Atribuir(PessoaModel pessoaModel, tb_pessoa pessoaE)
        {
            pessoaE.IdPessoa = pessoaModel.IdPessoa;
            pessoaE.IdUser = pessoaModel.IdUser;
            pessoaE.IdSetor = pessoaModel.IdSetor;
            pessoaE.Bairro = pessoaModel.Bairro;
            pessoaE.CEP = pessoaModel.CEP;
            pessoaE.Cidade = pessoaModel.Cidade;
            pessoaE.Complemento = pessoaModel.Complemento;
            pessoaE.CPF = pessoaModel.CPF;
            pessoaE.Estado = pessoaModel.Estado;
            pessoaE.Nome = pessoaModel.Nome;
            pessoaE.Numero = pessoaModel.Numero;
            pessoaE.RG = pessoaModel.RG;
            pessoaE.Rua = pessoaModel.Rua;
            pessoaE.Sexo = pessoaModel.Sexo;
            pessoaE.TelefoneCelular = pessoaModel.TelefoneCelular;
            pessoaE.TelefoneFixo = pessoaModel.TelefoneFixo;
        }
    }
}

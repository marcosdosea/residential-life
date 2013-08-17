using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Persistence;


namespace Services
{
    /// <summary>
    /// Gerencia todas as regras de negócio da entidade Autor
    /// </summary>
    
    public class GerenciadorPessoa

    {
        private IUnitOfWork unitOfWork;
        private bool shared;

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
            return pessoaE.IdPes;
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
            unitOfWork.RepositorioPessoa.Remover(pessoa => pessoa.IdPes.Equals(idPes));
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
                            IdPes = pessoa.IdPes,
                            Bairro = pessoa.Bairro,
                            CEP = pessoa.CEP,
                            Cidade = pessoa.Cidade,
                            Complemento = pessoa.Complemento,
                            CPF = pessoa.CPF,
                            Email = pessoa.Email,
                            Estado = pessoa.Estado,
                            Login = pessoa.Login,
                            Nome = pessoa.Nome,
                            Numero = pessoa.Numero,
                            RG = pessoa.RG,
                            Rua = pessoa.Rua,
                            Senha = pessoa.Senha,
                            Sexo = pessoa.Sexo,
                            TelefoneCelular = pessoa.TelefoneCelular,
                            TelefoneFixo = pessoa.TelefoneFixo,
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
        /// Obtém um autor
        /// </summary>
        /// <param name="idPessoa">Identificador da entidade na base de dados</param>
        /// <returns>Autor model</returns>
        public PessoaModel Obter(int idPessoa)
        {
            IEnumerable<PessoaModel> pessoaE = GetQuery().Where(pessoaModel => pessoaModel.IdPes.Equals(idPessoa));
            return pessoaE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados da Entidade Model para a Entidade Entity
        /// </summary>
        /// <param name="pessoaModel">Objeto do modelo</param>
        /// <param name="pessoaE">Entity mapeada da base de dados</param>
        private void Atribuir(PessoaModel pessoaModel, tb_pessoa pessoaE)
        {
            pessoaE.IdPes = pessoaModel.IdPes;
            pessoaE.Bairro = pessoaModel.Bairro;
            pessoaE.CEP = pessoaModel.CEP;
            pessoaE.Cidade = pessoaModel.Cidade;
            pessoaE.Complemento = pessoaModel.Complemento;
            pessoaE.CPF = pessoaModel.CPF;
            pessoaE.Email = pessoaModel.Email;
            pessoaE.Estado = pessoaModel.Estado;
            pessoaE.Login = pessoaModel.Login;
            pessoaE.Nome = pessoaModel.Nome;
            pessoaE.Numero = pessoaModel.Numero;
            pessoaE.RG = pessoaModel.RG;
            pessoaE.Rua = pessoaModel.Rua;
            pessoaE.Senha = pessoaModel.Senha;
            pessoaE.Sexo = pessoaModel.Sexo;
            pessoaE.TelefoneCelular = pessoaModel.TelefoneCelular;
            pessoaE.TelefoneFixo = pessoaModel.TelefoneFixo;
            
        }
    }
}

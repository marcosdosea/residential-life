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
        public int Inserir(Pessoa pessoaModel)
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
        public void Editar(Pessoa pessoaModel)
        {
            tb_pessoa pessoaE = new tb_pessoa(); 
            Atribuir(pessoaModel, pessoaE);
            unitOfWork.RepositorioPessoa.Editar(pessoaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="pessoaModel"></param>
        public void Remover(int idPes)
        {
            unitOfWork.RepositorioPessoa.Remover(pessoa => pessoa.IdPes.Equals(idPes));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do autor como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<Pessoa> GetQuery()
        {
            IQueryable<tb_pessoa> tb_pessoa = unitOfWork.RepositorioPessoa.GetQueryable();
            var query = from pessoa in tb_pessoa 
                        select new Pessoa
                        {
                            PesId = pessoa.IdPes
                            
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Pessoa> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um autor
        /// </summary>
        /// <param name="idAutor">Identificador do autor na base de dados</param>
        /// <returns>Autor model</returns>
        public Pessoa Obter(int idAutor)
        {
            IEnumerable<Pessoa> pessoaEs = GetQuery().Where(pessoaModel => pessoaModel.PesId.Equals(idAutor));
            return pessoaEs.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Autor Model para o Autor Entity
        /// </summary>
        /// <param name="pessoaModel">Objeto do modelo</param>
        /// <param name="pessoaE">Entity mapeada da base de dados</param>
        private void Atribuir(Pessoa pessoaModel, tb_pessoa pessoaE)
        {
            pessoaE.IdPes = pessoaModel.PesId;
            //pessoaE.nome = pessoaModel.Nome;
            //pessoaE.anoNascimento = pessoaModel.AnoNascimento;
        }
    }
}

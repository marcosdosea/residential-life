using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;

namespace Services
{
    public class GerenciadorPontuarPessoa
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorPontuarPessoa()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorPontuarPessoa(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="pontuarPessoaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(PontuarPessoaModel pontuarPessoaModel)
        {
            tb_pontuacaopessoa pontuacaoPessoaE = new tb_pontuacaopessoa();
            Atribuir(pontuarPessoaModel, pontuacaoPessoaE);
            unitOfWork.RepositorioPontuarPessoa.Inserir(pontuacaoPessoaE);
            unitOfWork.Commit(shared);
            return pontuacaoPessoaE.IdPontuacao;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="pontuarPessoaModel">Dados do modelo</param>
        public void Editar(PontuarPessoaModel pontuarPessoaModel)
        {
            tb_pontuacaopessoa pontuacaoPessoaE = new tb_pontuacaopessoa();
            Atribuir(pontuarPessoaModel, pontuacaoPessoaE);
            unitOfWork.RepositorioPontuarPessoa.Editar(pontuacaoPessoaE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idPontuacao">Identificador do pontuacao na base de dados</param>
        /// <param name="idPessoa">Identificador do pessoa na base de dados</param>
        public void Remover(int idPontuacao, int idPessoa)
        {
            unitOfWork.RepositorioPontuarPessoa.Remover(p => p.IdPontuacao.Equals(idPontuacao) &&
                p.IdPessoa.Equals(idPessoa));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do pontuacao como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<PontuarPessoaModel> GetQuery()
        {
            IQueryable<tb_pontuacaopessoa> tb_pontuacaopessoa = unitOfWork.RepositorioPontuarPessoa.GetQueryable();
            var query = from pontuarPessoa in tb_pontuacaopessoa
                        select new PontuarPessoaModel
                        {
                            IdPontuacao = pontuarPessoa.IdPontuacao,
                            IdPessoa = pontuarPessoa.IdPessoa,
                            Comentario = pontuarPessoa.Comentario,

                            NomePessoa = pontuarPessoa.tb_pessoa.Nome,
                            Pontuacao = pontuarPessoa.tb_pontuacao.Pontuacao
                        };
            return query;
        }


        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PontuarPessoaModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um pontuacao
        /// </summary>
        /// <param name="idPontuacao">Identificador do pontuacao na base de dados</param>
        /// <param name="idPessoa">Identificador do pessoa na base de dados</param>
        /// <returns>Pontuacao model</returns>
        public PontuarPessoaModel Obter(int idPontuacao, int idPessoa)
        {
            IEnumerable<PontuarPessoaModel> pontuacaoPessoaE = GetQuery().Where(p => p.IdPontuacao == idPontuacao &&
                p.IdPessoa.Equals(idPessoa));
            return pontuacaoPessoaE.ElementAtOrDefault(0);
        }


        /// <summary>
        /// Atribui dados do Setor Model para o Setor Entity
        /// </summary>
        /// <param name="pontuarPessoaModel">Objeto do modelo</param>
        /// <param name="pontuacaoPessoaE">Entity mapeada da base de dados</param>
        private void Atribuir(PontuarPessoaModel pontuarPessoaModel, tb_pontuacaopessoa pontuacaoPessoaE)
        {
            pontuacaoPessoaE.IdPontuacao = pontuarPessoaModel.IdPontuacao;
            pontuacaoPessoaE.IdPessoa = pontuarPessoaModel.IdPessoa;
            pontuacaoPessoaE.Comentario = pontuarPessoaModel.Comentario;
        }

        /// <summary>
        /// Obtem pontuacoes de determinada pessoa
        /// </summary>
        /// <param name="idPessoa">Identificador da pessoa</param>
        /// <returns>Lista de pontuacoes de determinada pessoa</returns>
        public IEnumerable<PontuarPessoaModel> ObterPorPessoa(int idPessoa)
        {
            return GetQuery().Where(p => p.IdPessoa.Equals(idPessoa));
        }
    }
}

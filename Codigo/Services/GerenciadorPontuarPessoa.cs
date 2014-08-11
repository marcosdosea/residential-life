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
            return pontuacaoPessoaE.IdPontuacaoPessoa;
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
        /// <param name="idPontuacaoPessoa">Identificador do pontuacao na base de dados</param>
        public void Remover(int idPontuacaoPessoa)
        {
            unitOfWork.RepositorioPontuarPessoa.Remover(p => p.IdPontuacaoPessoa.Equals(idPontuacaoPessoa));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do pontuacao como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<PontuarPessoaModel> GetQuery()
        {
            IQueryable<tb_pontuacaopessoa> tb_pontuacaopessoa = unitOfWork.RepositorioPontuarPessoa.GetQueryable();
            var query = from pontuar in tb_pontuacaopessoa
                        select new PontuarPessoaModel
                        {
                            IdPontuacaoPessoa = pontuar.IdPontuacaoPessoa,
                            IdPessoa = pontuar.IdPessoa,
                            Comentario = pontuar.Comentario,
                            Pontuacao = pontuar.Pontuacao == "Zero" ? ListaPontuacao.Zero : pontuar.Pontuacao == "Um" ? ListaPontuacao.Um : 
                                pontuar.Pontuacao == "Dois" ? ListaPontuacao.Dois : pontuar.Pontuacao == "Tres" ? ListaPontuacao.Tres : 
                                pontuar.Pontuacao == "Quatro" ? ListaPontuacao.Quatro : pontuar.Pontuacao == "Cinco" ? ListaPontuacao.Cinco :
                                pontuar.Pontuacao == "Seis" ? ListaPontuacao.Seis : pontuar.Pontuacao == "Sete" ? ListaPontuacao.Sete :
                                pontuar.Pontuacao == "Oito" ? ListaPontuacao.Oito : pontuar.Pontuacao == "Oito" ? ListaPontuacao.Oito :
                                pontuar.Pontuacao == "Nove" ? ListaPontuacao.Nove : ListaPontuacao.Dez,

                            NomePessoa = pontuar.tb_pessoa.Nome
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
        public PontuarPessoaModel Obter(int idPontuacaoPessoa)
        {
            IEnumerable<PontuarPessoaModel> pontuacaoPessoaE = GetQuery().Where(p => p.IdPontuacaoPessoa == idPontuacaoPessoa);
            return pontuacaoPessoaE.ElementAtOrDefault(0);
        }


        /// <summary>
        /// Atribui dados do Setor Model para o Setor Entity
        /// </summary>
        /// <param name="pontuarPessoaModel">Objeto do modelo</param>
        /// <param name="pontuacaoPessoaE">Entity mapeada da base de dados</param>
        private void Atribuir(PontuarPessoaModel pontuarPessoaModel, tb_pontuacaopessoa pontuacaoPessoaE)
        {
            pontuacaoPessoaE.IdPontuacaoPessoa = pontuarPessoaModel.IdPontuacaoPessoa;
            pontuacaoPessoaE.IdPessoa = pontuarPessoaModel.IdPessoa;
            pontuacaoPessoaE.Comentario = pontuarPessoaModel.Comentario;
            pontuacaoPessoaE.Pontuacao = pontuarPessoaModel.Pontuacao.ToString();
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

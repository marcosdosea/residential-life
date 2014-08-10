using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;

namespace Services
{
    public class GerenciadorPontuacao
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorPontuacao()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorPontuacao(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="pontuacaoModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(PontuacaoModel pontuacaoModel)
        {
            tb_pontuacao pontuacaoE = new tb_pontuacao();
            Atribuir(pontuacaoModel, pontuacaoE);
            unitOfWork.RepositorioPontuacao.Inserir(pontuacaoE);
            unitOfWork.Commit(shared);
            return pontuacaoE.IdPontuacao;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="pontuacaoModel">Dados do modelo</param>
        public void Editar(PontuacaoModel pontuacaoModel)
        {
            tb_pontuacao pontuacaoE = new tb_pontuacao();
            Atribuir(pontuacaoModel, pontuacaoE);
            unitOfWork.RepositorioPontuacao.Editar(pontuacaoE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idPontuacao">Identificador do pontuacao na base de dados</param>
        public void Remover(int idPontuacao)
        {
            unitOfWork.RepositorioPontuacao.Remover(pontuacao => pontuacao.IdPontuacao == idPontuacao);
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do pontuacao como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<PontuacaoModel> GetQuery()
        {
            IQueryable<tb_pontuacao> tb_pontuacao = unitOfWork.RepositorioPontuacao.GetQueryable();
            var query = from pontuacao in tb_pontuacao
                        select new PontuacaoModel
                        {
                            IdPontuacao = pontuacao.IdPontuacao,
                            Pontuacao = pontuacao.Pontuacao
                        };
            return query;
        }


        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PontuacaoModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um pontuacao
        /// </summary>
        /// <param name="idPontuacao">Identificador do pontuacao na base de dados</param>
        /// <returns>Pontuacao model</returns>
        public PontuacaoModel Obter(int idPontuacao)
        {
            IEnumerable<PontuacaoModel> pontuacaoE = GetQuery().Where(p => p.IdPontuacao == idPontuacao);
            return pontuacaoE.ElementAtOrDefault(0);
        }


        /// <summary>
        /// Atribui dados do Setor Model para o Setor Entity
        /// </summary>
        /// <param name="pontuacaoModel">Objeto do modelo</param>
        /// <param name="pontuacaoE">Entity mapeada da base de dados</param>
        private void Atribuir(PontuacaoModel pontuacaoModel, tb_pontuacao pontuacaoE)
        {
            pontuacaoE.IdPontuacao = pontuacaoModel.IdPontuacao;
            pontuacaoE.Pontuacao = pontuacaoModel.Pontuacao;
        }
    }
}

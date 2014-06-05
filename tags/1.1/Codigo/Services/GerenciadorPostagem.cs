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
    /// Gerencia todas as regras de negócio da entidade Postagem
    /// </summary>
    public class GerenciadorPostagem
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorPostagem()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorPostagem(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="PostagemModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(PostagemModel PostagemModel)
        {
            tb_postagem PostagemE = new tb_postagem();
            Atribuir(PostagemModel, PostagemE);
            unitOfWork.RepositorioPostagem.Inserir(PostagemE);
            unitOfWork.Commit(shared);
            return PostagemE.IdPostagem;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="PostagemModel"></param>
        public void Editar(PostagemModel PostagemModel)
        {
            tb_postagem PostagemE = new tb_postagem();
            Atribuir(PostagemModel, PostagemE);
            unitOfWork.RepositorioPostagem.Editar(PostagemE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="PostagemModel"> Dados do modelo</param>
        public void Remover(int idPostagem)
        {
            unitOfWork.RepositorioPostagem.Remover(Postagem => Postagem.IdPostagem.Equals(idPostagem));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do autor como model
        /// </summary>
        /// <returns></returns>
        /// 
        private IQueryable<PostagemModel> GetQuery()
        {
            IQueryable<tb_postagem> tb_Postagem = unitOfWork.RepositorioPostagem.GetQueryable();
            var query = from Postagem in tb_Postagem
                        select new PostagemModel
                        {
                            IdPostagem = Postagem.IdPostagem,
                            IdPessoa = Postagem.IdPessoa,
                            titulo = Postagem.Titulo,
                            descricao = Postagem.Descricao,
                            dataPublAutomatica = Postagem.DataCriacao,
                            dataExclusaoAutomatica = (DateTime)Postagem.DataEncerramento,                       
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PostagemModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PostagemModel> ObterTodosPorPessoa(int idPessoa)
        {
            return GetQuery().Where(postagem => postagem.IdPessoa.Equals(idPessoa));
        }

        /// <summary>
        /// Obtém um autor
        /// </summary>
        /// <param name="idPostagem">Identificador da postagem na base de dados</param>
        /// <returns>Autor model</returns>
        public PostagemModel Obter(int idPostagem)
        {
            IEnumerable<PostagemModel> PostagemE = GetQuery().Where(PostagemModel => PostagemModel.IdPostagem.Equals(idPostagem));
            return PostagemE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do Autor Model para o postagem Entity
        /// </summary>
        /// <param name="PostagemModel">Objeto do modelo</param>
        /// <param name="PostagemE">Entity mapeada da base de dados</param>
        private void Atribuir(PostagemModel PostagemModel, tb_postagem PostagemE)
        {
            PostagemE.IdPostagem = PostagemModel.IdPostagem;
            PostagemE.IdPessoa = PostagemModel.IdPessoa;
            PostagemE.Titulo = PostagemModel.titulo;
            PostagemE.Descricao = PostagemModel.descricao;
            PostagemE.DataCriacao = PostagemModel.dataPublAutomatica;
            PostagemE.DataEncerramento = PostagemModel.dataExclusaoAutomatica;           
        }

    }
}

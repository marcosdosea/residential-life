using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using Persistence;

namespace Services
{
    public class GerenciadorComentario
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorComentario()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        internal GerenciadorComentario(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="ComentarioModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(ComentarioModel comentarioModel)
        {
            tb_comentario comentarioE = new tb_comentario();
            Atribuir(comentarioModel, comentarioE);
            unitOfWork.RepositorioComentario.Inserir(comentarioE);
            unitOfWork.Commit(shared);
            return comentarioE.IdComentario;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="ComentarioModel"></param>
        public void Editar(ComentarioModel comentarioModel)
        {
            tb_comentario comentarioE = new tb_comentario();
            Atribuir(comentarioModel, comentarioE);
            unitOfWork.RepositorioComentario.Editar(comentarioE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idComentario"> Dados do modelo</param>
        public void Remover(int idComentario)
        {
            unitOfWork.RepositorioComentario.Remover(c => c.IdComentario.Equals(idComentario));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do autor como model
        /// </summary>
        /// <returns></returns>
        /// 
        private IQueryable<ComentarioModel> GetQuery()
        {
            IQueryable<tb_comentario> tb_comentario = unitOfWork.RepositorioComentario.GetQueryable();
            var query = from comentario in tb_comentario
                        select new ComentarioModel
                        {
                            IdComentario = comentario.IdComentario,
                            IdPessoa = comentario.IdPessoa,
                            IdPostagem = comentario.IdPostagem,
                            Comentario = comentario.Comentario,
                            Status = comentario.Status,
                            Data  = (DateTime) comentario.Data,

                            NomePessoa = comentario.tb_pessoa.Nome,
                            Titulo = comentario.tb_postagem.Titulo
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ComentarioModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obter todos as entidades cadastradas por pessoa
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ComentarioModel> ObterTodosPorPessoa(int idPessoa)
        {
            return GetQuery().Where(c => c.IdPessoa.Equals(idPessoa));
        }

        /// <summary>
        /// Obtém um comentario
        /// </summary>
        /// <param name="idComentario">Identificador do cometario na base de dados</param>
        /// <returns>Autor model</returns>
        public ComentarioModel Obter(int idComentario)
        {
            IEnumerable<ComentarioModel> comentarioE = GetQuery().Where(c => c.IdComentario.Equals(idComentario));
            return comentarioE.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtem todos os comentarios de determinada postagem
        /// </summary>
        /// <param name="idPostagem">Identificador da postagem</param>
        /// <returns>Lista de comentarios</returns>
        public IEnumerable<ComentarioModel> ObterPorPostagem(int idPostagem)
        {
            IEnumerable<ComentarioModel> comentarioE = GetQuery().Where(c => c.IdPostagem.Equals(idPostagem));
            return comentarioE;
        }


        /// <summary>
        /// Obtem comentarios de determinada pessoa e postagem
        /// </summary>
        /// <param name="idPostagem">Identificador da postagem</param>
        /// <param name="idPessoa">Identificador da pessoa</param>
        /// <returns>Lista de pessoas</returns>
        public IEnumerable<ComentarioModel> ObterPorPostagemPessoa(int idPostagem, int idPessoa)
        {
            IEnumerable<ComentarioModel> comentarioE = GetQuery().Where(c => c.IdPostagem.Equals(idPostagem) && 
                c.IdPessoa.Equals(idPessoa));
            return comentarioE;
        }

        /// <summary>
        /// Atribui dados do Cometario Model para o comentario Entity
        /// </summary>
        /// <param name="ComentarioModel">Objeto do modelo</param>
        /// <param name="comentarioE">Entity mapeada da base de dados</param>
        private void Atribuir(ComentarioModel comentarioModel, tb_comentario comentarioE)
        {
            comentarioE.IdComentario = comentarioModel.IdComentario;
            comentarioE.IdPessoa = comentarioModel.IdPessoa;
            comentarioE.IdPostagem = comentarioModel.IdPostagem;
            comentarioE.Comentario = comentarioModel.Comentario;
            comentarioE.Data = comentarioModel.Data;
            comentarioE.Status = comentarioModel.Status;           
        }
    }
}

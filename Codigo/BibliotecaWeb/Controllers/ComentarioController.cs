using System;
using System.Web.Mvc;
using System.Web.Security;
using Models;
using Services;

namespace BibliotecaWeb
{ 
    public class ComentarioController : Controller
    {
        private GerenciadorComentario gComentario;
        private GerenciadorPessoa gPessoa;
        private GerenciadorPostagem gPostagem;

        public ComentarioController()
        {
            gComentario = new GerenciadorComentario();
            gPessoa = new GerenciadorPessoa();
            gPostagem = new GerenciadorPostagem();
        }

        //
        // GET: /Comentario/

        public ActionResult Index(int idPostagem)
        {
            PostagemModel postagem = gPostagem.Obter(idPostagem);
            ViewsBagsComentarios(postagem);
            return View(gComentario.ObterPorPostagem(postagem.IdPostagem));
        }

        public ActionResult MeusComentarios(int idPostagem)
        {
            PostagemModel postagem = gPostagem.Obter(idPostagem);
            int idPessoa = ViewsBagsComentarios(postagem);
            return View("Index", gComentario.ObterPorPostagemPessoa(postagem.IdPostagem, idPessoa));
        }

        private int ViewsBagsComentarios(PostagemModel postagem)
        {
            ViewBag.NomePessoa = postagem.NomePessoa;
            ViewBag.Titulo = postagem.Titulo;
            ViewBag.IdPostagem = postagem.IdPostagem;
            int idPessoa = gPessoa.ObterPessoaLogada((int)Membership.GetUser(true).ProviderUserKey).IdPessoa;
            ViewBag.IdPessoaLogada = idPessoa;
            return idPessoa;
        }

        //
        // GET: /Comentario/Create
        //[Authorize(Roles = "Morador")]     
        public ActionResult Create(int idPostagem)
        {
            ComentarioModel comentario = new ComentarioModel();
            comentario.IdPostagem = idPostagem;
            return View(comentario);
        }

        //
        // POST: /Comentario/Create
        [HttpPost]
        public ActionResult Create(ComentarioModel comentarioModel)
        {
            comentarioModel.IdPessoa = gPessoa.ObterPessoaLogada((int)Membership.GetUser(true).ProviderUserKey).IdPessoa;
            comentarioModel.Data = DateTime.Now;
            if (ModelState.IsValid)
            {
                int idPostagem = comentarioModel.IdPostagem;
                gComentario.Inserir(comentarioModel);
                ViewsBagsComentarios(gPostagem.Obter(idPostagem));
                return View("Index", gComentario.ObterPorPostagem(idPostagem));
            }
            return View(comentarioModel);
        }

        //
        // GET: /Comentario/Details/5
        //[Authorize(Roles = "Morador")]
        //[Authorize(Roles = "Síndico")]
        public ViewResult Details(int id)
        {
            ViewBag.IdPessoaLogada = gPessoa.ObterPessoaLogada((int)Membership.GetUser(true).ProviderUserKey).IdPessoa;
            ComentarioModel comentario = gComentario.Obter(id);
            return View(comentario);
        }

        //
        // GET: /Comentario/Edit/5
        //[Authorize(Roles = "Morador")]
        //[Authorize(Roles = "Síndico")]
        public ActionResult Edit(int id)
        {
            ComentarioModel comentario = gComentario.Obter(id);
            return View(comentario);
        }

        //
        // POST: /Comentario/Edit/5
        [HttpPost]
        public ActionResult Edit(ComentarioModel comentarioModel)
        {
            if (ModelState.IsValid)
            {
                int idPostagem = comentarioModel.IdPostagem;
                gComentario.Editar(comentarioModel);
                ViewsBagsComentarios(gPostagem.Obter(idPostagem));
                return View("Index", gComentario.ObterPorPostagem(idPostagem));
            }
            return View(comentarioModel);
        }

        //
        // GET: /Comentario/Delete/5
        //[Authorize(Roles = "Morador")]
        //[Authorize(Roles = "Síndico")]
        public ActionResult Delete(int id)
        {
            ComentarioModel comentarioModel = gComentario.Obter(id);
            return View(comentarioModel);
        }

        //
        // POST: /Comentario/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            int idPostagem = gComentario.Obter(id).IdPostagem;
            gComentario.Remover(id);
            ViewsBagsComentarios(gPostagem.Obter(idPostagem));
            return View("Index", gComentario.ObterPorPostagem(idPostagem));
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
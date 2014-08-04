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

        public ComentarioController()
        {
            gComentario = new GerenciadorComentario();
            gPessoa = new GerenciadorPessoa();
        }

        //
        // GET: /Comentario/

        public ActionResult Index(int idPostagem)
        {
            return View(gComentario.ObterPorPostagem(idPostagem));
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
                gComentario.Inserir(comentarioModel);
                return RedirectToAction("Index");
            }
            return View(gComentario);
        }

        //
        // GET: /Comentario/Details/5
        //[Authorize(Roles = "Morador")]
        //[Authorize(Roles = "Síndico")]
        public ViewResult Details(int id)
        {
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
                gComentario.Editar(comentarioModel);
                return RedirectToAction("Index");
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
            gComentario.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
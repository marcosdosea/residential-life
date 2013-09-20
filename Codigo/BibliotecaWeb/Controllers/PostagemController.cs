using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Models;
using Services;
using Microsoft.Reporting.WebForms;

namespace BibliotecaWeb.Controllers
{
    public class PostagemController : Controller
    {

         private GerenciadorPostagem gPostagem;
     
        public PostagemController()
        {
            gPostagem = new GerenciadorPostagem();
        }

        //
        // GET: /Postagem/

        public ActionResult Index()
        {
            return View(gPostagem.ObterTodos());
        }

        //
        // GET: /Postagem/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Postagem/Create
        [HttpPost]
        public ActionResult Create(PostagemModel postagemModel)
        {
            if (ModelState.IsValid)
            {
                gPostagem.Inserir(postagemModel);
                return RedirectToAction("Index");
            }

            return View(gPostagem);
        }

        //
        // GET: /pessoa/Details/5
        public ViewResult Details(int id)
        {
            PostagemModel postagem = gPostagem.Obter(id);
            return View(postagem);
        }

        //
        // GET: /Postagem/Edit/5
        public ActionResult Edit(int id)
        {
            PostagemModel postagem = gPostagem.Obter(id);
            return View(postagem);
        }

        //
        // POST: /Postagem/Edit/5
        [HttpPost]
        public ActionResult Edit(PostagemModel postagemModel)
        {
            if (ModelState.IsValid)
            {
                gPostagem.Editar(postagemModel);
                return RedirectToAction("Index");
            }
            return View(postagemModel);
        }

        //
        // GET: /Postagem/Delete/5
        public ActionResult Delete(int id)
        {
            PostagemModel postagemModel = gPostagem.Obter(id);
            return View(postagemModel);
        }

        //
        // POST: /Postagem/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gPostagem.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}

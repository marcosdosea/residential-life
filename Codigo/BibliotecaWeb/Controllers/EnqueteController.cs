using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models.Models;

namespace BibliotecaWeb.Controllers
{
    public class EnqueteController : Controller
    {
        //
        // GET: /Enquete/

        private GerenciadorEnquete gEnquete;
        private GerenciadorPessoa gPessoa;
        private GerenciadorStatusEnquete gStatusEnquete;

        public EnqueteController()
        {
            gEnquete = new GerenciadorEnquete();
            gStatusEnquete = new GerenciadorStatusEnquete();
            gPessoa = new GerenciadorPessoa();
        }

        public ViewResult Index()
        {
            return View(gEnquete.ObterTodos());
        }

        //
        // GET: /enquete/Details/5

        public ViewResult Details(int id)
        {
            EnqueteModel enquete = gEnquete.Obter(id);
            return View(enquete);
        }

        //
        // GET: /enquete/Create

        public ActionResult Create()
        {
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            ViewBag.IdStatusEnquete = new SelectList(gStatusEnquete.ObterTodos(), "IdStatusEnquete", "StatusEnquete");
            return View();
        }

        //
        // POST: /enquete/Create

        [HttpPost]
        public ActionResult Create(EnqueteModel enqueteModel)
        {
            if (ModelState.IsValid)
            {
                gEnquete.Inserir(enqueteModel);
                return RedirectToAction("Index");
            }

            return View(enqueteModel);
        }

        //
        // GET: /enquete/Edit/5

        public ActionResult Edit(int id)
        {
            EnqueteModel enqueteModel = gEnquete.Obter(id);
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", enqueteModel.IdPessoa);
            ViewBag.IdStatusEnquete = new SelectList(gStatusEnquete.ObterTodos(), "IdStatusEnquete", "StatusEnquete");
            return View(enqueteModel);
        }



        //
        // POST: /enquete/Edit/5

        [HttpPost]
        public ActionResult Edit(EnqueteModel enqueteModel)
        {
            if (ModelState.IsValid)
            {
                gEnquete.Editar(enqueteModel);
                return RedirectToAction("Index");
            }
            return View(enqueteModel);
        }

        //
        // GET: /enquete/Delete/5

        public ActionResult Delete(int id)
        {
            EnqueteModel enqueteModel = gEnquete.Obter(id);
            return View(enqueteModel);
        }

        //
        // POST: /enquete/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gEnquete.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


    }
}

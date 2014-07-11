using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Services;

namespace BibliotecaWeb.Controllers
{ 
    public class AtendimentoController : Controller
    {
        //
        // GET: /Atendimento/

        private GerenciadorPessoa gPessoa;
        private GerenciadorAtendimento gAtendimento;

        public AtendimentoController()
        {
            gAtendimento = new GerenciadorAtendimento();
            gPessoa = new GerenciadorPessoa();
        }


        //
        // GET: /Atendimento/
        public ActionResult Index()
        {
            return View(gAtendimento.ObterTodos());
        }

        //
        // GET: /Atendimento/Create
        public ActionResult Create()
        {
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            return View();
        }

        //
        // POST: /Atendimento/Create
        [HttpPost]
        public ActionResult Create(AtendimentoModel atendimentoModel)
        {
            if (ModelState.IsValid)
            {
                gAtendimento.Inserir(atendimentoModel);
                return RedirectToAction("Index");
            }

            return View(atendimentoModel);
        }

        //
        // GET: /pessoa/Details/5
        public ViewResult Details(int id)
        {
            AtendimentoModel atendimento = gAtendimento.Obter(id);
            return View(atendimento);
        }

        //
        // GET: /Atendimento/Edit/5
        public ActionResult Edit(int id)
        {
            AtendimentoModel atendimento = gAtendimento.Obter(id);
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", atendimento.IdPessoa);
            return View(atendimento);
        }

        //
        // POST: /Atendimento/Edit/5
        [HttpPost]
        public ActionResult Edit(AtendimentoModel atendimentoModel)
        {
            if (ModelState.IsValid)
            {
                gAtendimento.Editar(atendimentoModel);
                return RedirectToAction("Index");
            }
            return View(atendimentoModel);
        }

        //
        // GET: /Atendimento/Delete/5
        public ActionResult Delete(int id)
        {
            AtendimentoModel atendimentoModel = gAtendimento.Obter(id);
            return View(atendimentoModel);
        }

        //
        // POST: /Atendimento/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gAtendimento.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
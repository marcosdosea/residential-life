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
    public class PessoaController : Controller
    {
        private GerenciadorPessoa gPessoa;
     
        public PessoaController()
        {
            gPessoa = new GerenciadorPessoa();
        }
        //
        // GET: /pessoa/

        public ViewResult Index()
        {
            return View(gPessoa.ObterTodos());
        }

        //
        // GET: /pessoa/Details/5

        public ViewResult Details(int id)
        {
            PessoaModel pessoa = gPessoa.Obter(id);
            return View(pessoa);
        }

        //
        // GET: /pessoa/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /pessoa/Create

        [HttpPost]
        public ActionResult Create(PessoaModel pessoaModel)
        {
            if (ModelState.IsValid)
            {
                gPessoa.Inserir(pessoaModel);
                return RedirectToAction("Index");  
            }

            return View(pessoaModel);
        }
        
        //
        // GET: /pessoa/Edit/5
 
        public ActionResult Edit(int id)
        {

            PessoaModel pessoa = gPessoa.Obter(id);
            return View(pessoa);
        }

        //
        // POST: /pessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(PessoaModel pessoaModel)
        {
            if (ModelState.IsValid)
            {
                gPessoa.Editar(pessoaModel);
                return RedirectToAction("Index");
            }
            return View(pessoaModel);
        }

        //
        // GET: /pessoa/Delete/5
 
        public ActionResult Delete(int id)
        {
            PessoaModel pessoaModel = gPessoa.Obter(id);
            return View(pessoaModel);
        }

        //
        // POST: /pessoa/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gPessoa.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
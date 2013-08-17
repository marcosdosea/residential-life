using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models.Models;

namespace BibliotecaWeb.Controllers
{
    public class BlocoController : Controller
    {
        private GerenciadorBloco gBloco;

        public BlocoController()
        {
            gBloco = new GerenciadorBloco();
        }
        //
        // GET: /bloco/

        public ViewResult Index()
        {
            return View(gBloco.ObterTodos());
        }

        //
        // GET: /bloco/Details/5

        public ViewResult Details(int id)
        {
            BlocoModel bloco = gBloco.Obter(id);
            return View(bloco);
        }

        //
        // GET: /bloco/Create

        public ActionResult Create()
        {
           
            return View();
        }

        //
        // POST: /bloco/Create

        [HttpPost]
        public ActionResult Create(BlocoModel blocoModel)
        {
            if (ModelState.IsValid)
            {
                gBloco.Inserir(blocoModel);
                return RedirectToAction("Index");
            }

            return View(blocoModel);
        }

        //
        // GET: /bloco/Edit/5

        public ActionResult Edit(int id)
        {

            BlocoModel bloco = gBloco.Obter(id);
            return View(bloco);
        }

        //
        // POST: /bloco/Edit/5

        [HttpPost]
        public ActionResult Edit(BlocoModel blocoModel)
        {
            if (ModelState.IsValid)
            {
                gBloco.Editar(blocoModel);
                return RedirectToAction("Index");
            }
            return View(blocoModel);
        }

        //
        // GET: /bloco/Delete/5

        public ActionResult Delete(int id)
        {
            BlocoModel blocoModel = gBloco.Obter(id);
            return View(blocoModel);
        }

        //
        // POST: /bloco/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gBloco.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        
    }
}

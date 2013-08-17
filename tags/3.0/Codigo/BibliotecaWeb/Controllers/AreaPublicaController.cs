using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models.Models;

namespace BibliotecaWeb.Controllers
{
    public class AreaPublicaController : Controller
    {
        private GerenciadorAreaPublica gAreaPublica;

        public AreaPublicaController()
        {
            gAreaPublica = new GerenciadorAreaPublica();
        }
        //
        // GET: /AreaPublica/

        public ViewResult Index()
        {
            return View(gAreaPublica.ObterTodos());
        }

        //
        // GET: /AreaPublica/Details/5

        public ViewResult Details(int id)
        {
            AreaPublicaModel AreaPublica = gAreaPublica.Obter(id);
            return View(AreaPublica);
        }

        //
        // GET: /AreaPublica/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AreaPublica/Create

        [HttpPost]
        public ActionResult Create(AreaPublicaModel AreaPublicaModel)
        {
            if (ModelState.IsValid)
            {
                gAreaPublica.Inserir(AreaPublicaModel);
                return RedirectToAction("Index");
            }

            return View(AreaPublicaModel);
        }

        //
        // GET: /AreaPublica/Edit/5

        public ActionResult Edit(int id)
        {

            AreaPublicaModel AreaPublica = gAreaPublica.Obter(id);
            return View(AreaPublica);
        }

        //
        // POST: /AreaPublica/Edit/5

        [HttpPost]
        public ActionResult Edit(AreaPublicaModel AreaPublicaModel)
        {
            if (ModelState.IsValid)
            {
                gAreaPublica.Editar(AreaPublicaModel);
                return RedirectToAction("Index");
            }
            return View(AreaPublicaModel);
        }

        //
        // GET: /AreaPublica/Delete/5

        public ActionResult Delete(int id)
        {
            AreaPublicaModel AreaPublicaModel = gAreaPublica.Obter(id);
            return View(AreaPublicaModel);
        }

        //
        // POST: /AreaPublica/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gAreaPublica.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
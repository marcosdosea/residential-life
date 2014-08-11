using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models.Models;

namespace BibliotecaWeb.Controllers
{
    public class CondominioController : Controller
    {
        
        private GerenciadorCondominio gCondominio;
        private GerenciadorAdministradora gAdministradora;

        public CondominioController()
        {
            gCondominio = new GerenciadorCondominio();
            gAdministradora = new GerenciadorAdministradora();
        }
        //
        // GET: /condominio/
        //[Authorize(Roles = "Adm Sistema")]
        public ViewResult Index()
        {
            return View(gCondominio.ObterTodos());
        }

        //
        // GET: /condominio/Details/5
        //[Authorize(Roles = "Adm Sistema")]
        public ViewResult Details(int id)
        {
            CondominioModel condominio = gCondominio.Obter(id);
            return View(condominio);
        }

        //
        // GET: /condominio/Create
        //[Authorize(Roles = "Adm Sistema")]
        public ActionResult Create()
        {
            //ViewBag.IdAdministradora = new SelectList(gAdministradora.ObterTodos(), "IdAdministradora", "Nome");
            return View();
        }

        //
        // POST: /condominio/Create

        [HttpPost]
        public ActionResult Create(CondominioModel condominioModel)
        {
            if (ModelState.IsValid)
            {
                gCondominio.Inserir(condominioModel);
                return RedirectToAction("Index");
            }

            return View(condominioModel);
        }

        //
        // GET: /condominio/Edit/5
        // [Authorize(Roles = "Adm Sistema")]
        public ActionResult Edit(int id)
        {
            CondominioModel condominio = gCondominio.Obter(id);
            //ViewBag.IdAdministradora = new SelectList(gAdministradora.ObterTodos(), "IdAdministradora", "Nome", condominio.IdAdministradora);
            return View(condominio);
        }



        //
        // POST: /condominio/Edit/5

        [HttpPost]
        public ActionResult Edit(CondominioModel condominioModel)
        {
            if (ModelState.IsValid)
            {
                gCondominio.Editar(condominioModel);
                return RedirectToAction("Index");
            }
            return View(condominioModel);
        }

        //
        // GET: /condominio/Delete/5
        public ActionResult Delete(int id)
        {
            CondominioModel condominioModel = gCondominio.Obter(id);
            return View(condominioModel);
        }

        //
        // POST: /condominio/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gCondominio.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}

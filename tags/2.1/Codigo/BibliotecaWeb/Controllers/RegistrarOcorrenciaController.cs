using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models;

namespace BibliotecaWeb.Controllers
{
    public class RegistrarOcorrenciaController : Controller
    {

        private GerenciadorPessoa gPessoa;
        private GerenciadorRegistrarOcorrencia gRegistrarOcorrencia;

        public RegistrarOcorrenciaController()
        {
            gRegistrarOcorrencia = new GerenciadorRegistrarOcorrencia();
            gPessoa = new GerenciadorPessoa();
        }


        //
        // GET: /RegistrarOcorrencia/

        public ActionResult Index()
        {
            return View(gRegistrarOcorrencia.ObterTodos());
        }

        //
        // GET: /RegistrarOcorrencia/Details/5

        public ViewResult Details(int id)
        {
            RegistrarOcorrenciaModel RegistrarOcorrencia = gRegistrarOcorrencia.Obter(id);
            return View(RegistrarOcorrencia);
        }

        //
        // GET: /RegistrarOcorrencia/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /RegistrarOcorrencia/Create

        [HttpPost]
        public ActionResult Create(RegistrarOcorrenciaModel RegistrarOcorrenciaModel)
        {
            if (ModelState.IsValid)
            {
                gRegistrarOcorrencia.Inserir(RegistrarOcorrenciaModel);
                return RedirectToAction("Index");
            }

            return View(RegistrarOcorrenciaModel);
        }

        //
        // GET: /RegistrarOcorrencia/Edit/5

        public ActionResult Edit(int id)
        {

            RegistrarOcorrenciaModel RegistrarOcorrencia = gRegistrarOcorrencia.Obter(id);
            return View(RegistrarOcorrencia);
        }

        //
        // POST: /RegistrarOcorrencia/Edit/5

        [HttpPost]
        public ActionResult Edit(RegistrarOcorrenciaModel RegistrarOcorrenciaModel)
        {
            if (ModelState.IsValid)
            {
                gRegistrarOcorrencia.Editar(RegistrarOcorrenciaModel);
                return RedirectToAction("Index");
            }
            return View(RegistrarOcorrenciaModel);
        }

        //
        // GET: /RegistrarOcorrencia/Delete/5

        public ActionResult Delete(int id)
        {
            RegistrarOcorrenciaModel RegistrarOcorrenciaModel = gRegistrarOcorrencia.Obter(id);
            return View(RegistrarOcorrenciaModel);
        }

        //
        // POST: /RegistrarOcorrencia/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gRegistrarOcorrencia.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


    }
}

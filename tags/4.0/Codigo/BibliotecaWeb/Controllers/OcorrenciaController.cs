using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models;

namespace BibliotecaWeb.Controllers
{
    public class OcorrenciaController : Controller
    {

        private GerenciadorPessoa gPessoa;
        private GerenciadorOcorrencia gOcorrencia;
        private GerenciadorStatusOcorrencia gStatusOcorrencia;
        private GerenciadorTipoOcorrencia gTipoOcorrencia;

        public OcorrenciaController()
        {
            gOcorrencia = new GerenciadorOcorrencia();
            gPessoa = new GerenciadorPessoa();
            gStatusOcorrencia = new GerenciadorStatusOcorrencia();
            gTipoOcorrencia = new GerenciadorTipoOcorrencia();

        }


        //
        // GET: /Ocorrencia/

        public ActionResult Index()
        {
            return View(gOcorrencia.ObterTodos());
        }

        //
        // GET: /Ocorrencia/Details/5

        public ViewResult Details(int id)
        {
            OcorrenciaModel Ocorrencia = gOcorrencia.Obter(id);
            return View(Ocorrencia);
        }

        //
        // GET: /Ocorrencia/Create

        public ActionResult Create()
        {
            ViewBag.IdTipoOcorrencia = new SelectList(gTipoOcorrencia.ObterTodos(), "IdTipoOcorrencia", "TipoOcorrencia");
            ViewBag.IdStatusOcorrencia = new SelectList(gStatusOcorrencia.ObterTodos(), "IdStatusOcorrencia", "StatusOcorrencia");
            return View();
        }

        //
        // POST: /Ocorrencia/Create

        [HttpPost]
        public ActionResult Create(OcorrenciaModel OcorrenciaModel)
        {
            if (ModelState.IsValid)
            {
                gOcorrencia.Inserir(OcorrenciaModel);
                return RedirectToAction("Index");
            }

            return View(OcorrenciaModel);
        }

        //
        // GET: /Ocorrencia/Edit/5

        public ActionResult Edit(int id)
        {

            OcorrenciaModel Ocorrencia = gOcorrencia.Obter(id);

            ViewBag.IdTipoOcorrencia = new SelectList(gTipoOcorrencia.ObterTodos(), "IdTipoOcorrencia", "TipoOcorrencia", Ocorrencia.IdTipoOcorrencia);
            ViewBag.IdStatusOcorrencia = new SelectList(gStatusOcorrencia.ObterTodos(), "IdStatusOcorrencia", "StatusOcorrencia");

            return View(Ocorrencia);
        }

        //
        // POST: /Ocorrencia/Edit/5

        [HttpPost]
        public ActionResult Edit(OcorrenciaModel OcorrenciaModel)
        {
            if (ModelState.IsValid)
            {
                gOcorrencia.Editar(OcorrenciaModel);
                return RedirectToAction("Index");
            }
            return View(OcorrenciaModel);
        }

        //
        // GET: /Ocorrencia/Delete/5

        public ActionResult Delete(int id)
        {
            OcorrenciaModel OcorrenciaModel = gOcorrencia.Obter(id);
            return View(OcorrenciaModel);
        }

        //
        // POST: /Ocorrencia/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gOcorrencia.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


    }
}

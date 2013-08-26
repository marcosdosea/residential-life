using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Services;
using Models.Models;

namespace BibliotecaWeb.Controllers
{
    public class ReservaAmbienteController : Controller
    {
        private GerenciadorReservaAmbiente gReservaAmbiente;
        private GerenciadorAreaPublica gAreaPublica;

        public ReservaAmbienteController()
        {
            gReservaAmbiente = new GerenciadorReservaAmbiente();
            gAreaPublica = new GerenciadorAreaPublica();
        }

        //
        // GET: /ReservaAmbiente/

        public ViewResult Index()
        {
            return View(gReservaAmbiente.ObterTodos());
        }

        //
        // GET: /ReservaAmbiente/Details/5

        public ViewResult Details(int id)
        {
            ReservaAmbienteModel reservaAmbiente = gReservaAmbiente.Obter(id);
            return View(reservaAmbiente);
        }

        //
        // GET: /ReservaAmbiente/Create

        public ActionResult Create()
        {
            //Pegar somente as áreas públicas do condomínio corrente no futuro
            ViewBag.IdArea = new SelectList(gAreaPublica.ObterTodos(), "IdAreaPublica", "Nome");
            return View();
        }

        //
        // POST: /ReservaAmbiente/Create

        [HttpPost]
        public ActionResult Create(ReservaAmbienteModel reservaAmbienteModel)
        {
            if (ModelState.IsValid)
            {
                gReservaAmbiente.Inserir(reservaAmbienteModel);
                return RedirectToAction("Index");
            }
            else
            {
                //Pegar somente as áreas públicas do condomínio corrente no futuro
                ViewBag.IdArea = new SelectList(gAreaPublica.ObterTodos(), "IdAreaPublica", "Nome");
                gReservaAmbiente.Inserir(reservaAmbienteModel);
                return RedirectToAction("Index");
            }

            //return View(reservaAmbienteModel);
        }

        //
        // GET: /ReservaAmbiente/Edit/5

        public ActionResult Edit(int id)
        {

            ReservaAmbienteModel reservaAmbiente = gReservaAmbiente.Obter(id);
            ViewBag.IdArea = new SelectList(gAreaPublica.ObterTodos(), "IdAreaPublica", "Nome", reservaAmbiente.IdAreaPublica);
            return View(reservaAmbiente);
        }

        //
        // POST: /ReservaAmbiente/Edit/5

        [HttpPost]
        public ActionResult Edit(ReservaAmbienteModel reservaAmbienteModel)
        {
            //TODO: corrigir, não está funcionando, mas deveria
            if (ModelState.IsValid)
            {
                gReservaAmbiente.Editar(reservaAmbienteModel);
                return RedirectToAction("Index");
            }
            
            return View(reservaAmbienteModel);
        }

        //
        // GET: /ReservaAmbiente/Delete/5

        public ActionResult Delete(int id)
        {
            ReservaAmbienteModel reservaAmbienteModel = gReservaAmbiente.Obter(id);
            return View(reservaAmbienteModel);
        }

        //
        // POST: /ReservaAmbiente/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gReservaAmbiente.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}

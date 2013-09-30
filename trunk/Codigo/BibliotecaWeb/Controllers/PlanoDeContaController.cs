using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models.Models;

namespace BibliotecaWeb.Controllers
{
    public class PlanoDeContaController : Controller
    {
        //
        // GET: /PlanoDeConta/

        private GerenciadorPlanoDeConta gPlanoDeConta;
        private GerenciadorTipoPlanoDeConta gTipoPlanoDeConta;
        
     
        public PlanoDeContaController()
        {
            gPlanoDeConta = new GerenciadorPlanoDeConta();
            gTipoPlanoDeConta = new GerenciadorTipoPlanoDeConta();
        }

        
        //
        // GET: PlanoDeConta

        public ActionResult Index()
        {
            //TODO: pegar todos da administradora corrente ou do condomínio corrente [ver]
            return View(gPlanoDeConta.ObterTodos());
        }

        //
        // GET: PlanoDeConta/Create
        public ActionResult Create()
        {
            ViewBag.IdTipoPlanoDeConta = new SelectList(gTipoPlanoDeConta.ObterTodos(), "IdTipoPlanoDeConta", "TipoPlanoDeConta");
            return View();
        }

        //
        // POST: PlanoDeConta/Create
        [HttpPost]
        public ActionResult Create(PlanoDeContaModel planoDeContaModel)
        {
            if (ModelState.IsValid)
            {
                gPlanoDeConta.Inserir(planoDeContaModel);
                return RedirectToAction("Index");
            }

            return View(planoDeContaModel);
        }

        //
        // GET: /PlanoDeConta/Details/5
        public ViewResult Details(int id)
        {
            PlanoDeContaModel planoDeConta = gPlanoDeConta.Obter(id);
            return View(planoDeConta);
        }

        //
        // GET: PlanoDeConta/Edit/5
        public ActionResult Edit(int id)
        {
            PlanoDeContaModel planoDeConta = gPlanoDeConta.Obter(id);
            ViewBag.IdTipoPlanoDeConta = new SelectList(gTipoPlanoDeConta.ObterTodos(), "IdTipoPlanoDeConta", "TipoPlanoDeConta", planoDeConta.IdTipoPlanoDeConta); 
            return View(planoDeConta);
        }

        //
        // POST: PlanoDeConta/Edit/5
        [HttpPost]
        public ActionResult Edit(PlanoDeContaModel planoDeContaModel)
        {
            if (ModelState.IsValid)
            {
                gPlanoDeConta.Editar(planoDeContaModel);
                return RedirectToAction("Index");
            }
            return View(planoDeContaModel);
        }

        //
        // GET: PlanoDeConta/Delete/5
        public ActionResult Delete(int id)
        {
            PlanoDeContaModel planoDeContaModel = gPlanoDeConta.Obter(id);
            return View(planoDeContaModel);
        }

        //
        // POST: PlanoDeConta/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gPlanoDeConta.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}

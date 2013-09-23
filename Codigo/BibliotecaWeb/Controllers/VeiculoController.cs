using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Models;
using Services;
using Microsoft.Reporting.WebForms;

namespace BibliotecaWeb
{
    [Authorize(Roles = "Morador")]
    public class VeiculoController : Controller
    {
        
        private GerenciadorVeiculo gVeiculo;
        private GerenciadorTipoVeiculo gTipoVeiculo;
     
        public VeiculoController()
        {
            gVeiculo = new GerenciadorVeiculo();
            gTipoVeiculo = new GerenciadorTipoVeiculo();
        }

        
        //
        // GET: /Veiculo/

        public ActionResult Index()
        {
            return View(gVeiculo.ObterTodos());
        }

        //
        // GET: /Veiculo/Create
        public ActionResult Create()
        {
            ViewBag.IdTipoVeiculo = new SelectList(gTipoVeiculo.ObterTodos(), "IdTipoVeiculo", "TipoVeiculo");
            return View();
        }

        //
        // POST: /Veiculo/Create
        [HttpPost]
        public ActionResult Create(VeiculoModel veiculoModel)
        {
            if (ModelState.IsValid)
            {
                gVeiculo.Inserir(veiculoModel);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.IdTipoVeiculo = new SelectList(gTipoVeiculo.ObterTodos(), "IdTipoVeiculo", "TipoVeiculo");
                gVeiculo.Inserir(veiculoModel);
                return RedirectToAction("Index");
            }

            //return View(veiculoModel);
        }

        //
        // GET: /pessoa/Details/5
        public ViewResult Details(int id)
        {
            VeiculoModel veiculo = gVeiculo.Obter(id);
            return View(veiculo);
        }

        //
        // GET: /Veiculo/Edit/5
        public ActionResult Edit(int id)
        {
            VeiculoModel veiculo = gVeiculo.Obter(id);
            ViewBag.IdSindico = new SelectList(gTipoVeiculo.ObterTodos(), "IdTipoVeiculo", "Veiculo", veiculo.IdTipoVeiculo); 
            return View(veiculo);
        }

        //
        // POST: /Veiculo/Edit/5
        [HttpPost]
        public ActionResult Edit(VeiculoModel veiculoModel)
        {
            if (ModelState.IsValid)
            {
                gVeiculo.Editar(veiculoModel);
                return RedirectToAction("Index");
            }
            return View(veiculoModel);
        }

        //
        // GET: /Veiculo/Delete/5
        public ActionResult Delete(int id)
        {
            VeiculoModel veiculoModel = gVeiculo.Obter(id);
            return View(veiculoModel);
        }

        //
        // POST: /Veiculo/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gVeiculo.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}

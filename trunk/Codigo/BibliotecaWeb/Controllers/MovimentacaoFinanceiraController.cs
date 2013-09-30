using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models.Models;

namespace BibliotecaWeb.Controllers
{
    public class MovimentacaoFinanceiraController : Controller
    {
        //
        // GET: /MovimentacaoFinanceira/

    
    public class MovimentacaoFinanceiraController : Controller
    {
        private GerenciadorMovimentacaoFinanceira gMovimentacaoFinanceira;
        private GerenciadorPlanoDeConta gPlanoDeConta;
        private GerenciadorStatusMovimentacaoFinanceira gStatusMovimentacaoFinanceira;
        

        public MovimentacaoFinanceiraController()
        {
            gMovimentacaoFinanceira = new GerenciadorMovimentacaoFinanceira();
            gPlanoDeConta = new GerenciadorPlanoDeConta();
            gStatusMovimentacaoFinanceira = new GerenciadorStatusMovimentacaoFinanceira();
        }

        //
        // GET: /MovimentacaoFinanceira/

       
        public ViewResult Index()
        {
            //TODO: obter todos do condomínio escolhido e pra essa administradora
            return View(gMovimentacaoFinanceira.ObterTodos());
        }

        //
        // GET: /MovimentacaoFinanceira/Details/5

        public ViewResult Details(int id)
        {
            MovimentacaoFinanceiraModel movimentacaoFinanceira = gMovimentacaoFinanceira.Obter(id);
            return View(movimentacaoFinanceira);
        }

        //
        // GET: /MovimentacaoFinanceira/Create

        public ActionResult Create()
        {
            //TODO: Pegar somente as movimentacoes da administradora de determinado condomínio
            ViewBag.IdPlanoDeConta = new SelectList(gPlanoDeConta.ObterTodos(), "IdPlanoDeConta", "PlanoDeConta");
            ViewBag.IdStatusMovimentacaoFinanceira = new SelectList(gStatusMovimentacaoFinanceira.ObterTodos(), 
                "IdStatusMovimentacaoFinanceira", "StatusMovimentacaoFinanceira");
            return View();
        }

        //
        // POST: /MovimentacaoFinanceira/Create

        [HttpPost]
        public ActionResult Create(MovimentacaoFinanceiraModel movimentacaoFinanceiraModel)
        {
            if (ModelState.IsValid)
            {
                gMovimentacaoFinanceira.Inserir(movimentacaoFinanceiraModel);
                return RedirectToAction("Index");
            }

            return View(movimentacaoFinanceiraModel);
        }

        //
        // GET: /MovimentacaoFinanceira/Edit/5

        public ActionResult Edit(int id)
        {
            MovimentacaoFinanceiraModel movimentacaoFinanceira = gMovimentacaoFinanceira.Obter(id);
            ViewBag.IdPlanoDeConta = new SelectList(gPlanoDeConta.ObterTodos(), "IdPlanoDeConta", "PlanoDeConta", movimentacaoFinanceira.IdPlanoDeConta);
            ViewBag.IdStatusMovimentacaoFinanceira = new SelectList(gStatusMovimentacaoFinanceira.ObterTodos(), 
                "IdStatusMovimentacaoFinanceira", "StatusMovimentacaoFinanceira", movimentacaoFinanceira.IdStatusMovimentacaoFinanceira);
            return View(movimentacaoFinanceira);
        }

        //
        // POST: /MovimentacaoFinanceira/Edit/5

        [HttpPost]
        public ActionResult Edit(MovimentacaoFinanceiraModel movimentacaoFinanceiraModel)
        {
            if (ModelState.IsValid)
            {
                gMovimentacaoFinanceira.Editar(movimentacaoFinanceiraModel);
                return RedirectToAction("Index");
            }
            
            return View(movimentacaoFinanceiraModel);
        }

        //
        // GET: /MovimentacaoFinanceira/Delete/5

        [Authorize(Roles = "Morador")]
        public ActionResult Delete(int id)
        {
            MovimentacaoFinanceiraModel movimentacaoFinanceiraModel = gMovimentacaoFinanceira.Obter(id);
            return View(movimentacaoFinanceiraModel);
        }

        //
        // POST: /MovimentacaoFinanceira/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gMovimentacaoFinanceira.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}

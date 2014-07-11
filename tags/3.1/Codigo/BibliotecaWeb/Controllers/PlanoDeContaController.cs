using System.Web.Mvc;
using Services;
using Models;

namespace BibliotecaWeb
{ 
    public class PlanoDeContaController : Controller
    {
        private GerenciadorPlanoDeConta gPlanoDeConta;

        public PlanoDeContaController()
        {
            gPlanoDeConta = new GerenciadorPlanoDeConta();
        }
        //
        // GET: /planoDeConta/

        public ViewResult Index()
        {
            return View(gPlanoDeConta.ObterTodos());
        }

        //
        // GET: /planoDeConta/Details/5

        public ViewResult Details(int id)
        {
            PlanoDeContaModel planoDeConta = gPlanoDeConta.Obter(id);
            return View(planoDeConta);
        }

        //
        // GET: /planoDeConta/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /planoDeConta/Create

        [HttpPost]
        public ActionResult Create(PlanoDeContaModel planoDeConta)
        {
            if (ModelState.IsValid)
            {
                gPlanoDeConta.Inserir(planoDeConta);
                return RedirectToAction("Index");
            }
            return View(planoDeConta);
        }

        //
        // GET: /planoDeConta/Edit/5

        public ActionResult Edit(int id)
        {
            PlanoDeContaModel planoDeConta = gPlanoDeConta.Obter(id);
            return View(planoDeConta);
        }

        //
        // POST: /planoDeConta/Edit/5

        [HttpPost]
        public ActionResult Edit(PlanoDeContaModel planoDeConta)
        {
            if (ModelState.IsValid)
            {
                gPlanoDeConta.Editar(planoDeConta);
                return RedirectToAction("Index");
            }
            return View(planoDeConta);
        }

        //
        // GET: /planoDeConta/Delete/5

        public ActionResult Delete(int id)
        {
            PlanoDeContaModel planoDeConta = gPlanoDeConta.Obter(id);
            return View(planoDeConta);
        }

        //
        // POST: /planoDeConta/Delete/5

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
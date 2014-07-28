using System.Web.Mvc;
using Models;
using Services;

namespace BibliotecaWeb
{ 
    public class GrupoPlanoDeContasController : Controller
    {
        private GerenciadorGrupoPlanoDeContas gGrupoPlanoDeContas;
        private GerenciadorPlanoDeConta gPlanoDeConta;

        public GrupoPlanoDeContasController()
        {
            gGrupoPlanoDeContas = new GerenciadorGrupoPlanoDeContas();
            gPlanoDeConta = new GerenciadorPlanoDeConta();
        }

        //
        // GET: /GrupoPlanoDeContas/

        public ActionResult Index()
        {
            return View(gGrupoPlanoDeContas.ObterTodos());
        }

        //
        // GET: /GrupoPlanoDeContas/Details/5

        public ViewResult Details(int id)
        {
            GrupoPlanoDeContasModel grupo = gGrupoPlanoDeContas.Obter(id);
            return View(grupo);
        }

        //[Authorize(Roles = "Síndico")]
        public ActionResult Create()
        {
            ViewBag.IdPlanoDeConta = new SelectList(gPlanoDeConta.ObterTodos(), "IdPlanoDeConta", "Descricao");
            return View();
        }

        //
        // POST: /GrupoPlanoDeContas/Create

        [HttpPost]
        public ActionResult Create(GrupoPlanoDeContasModel grupoModel)
        {
            if (ModelState.IsValid)
            {
                gGrupoPlanoDeContas.Inserir(grupoModel);
                return RedirectToAction("Index");
            }
            ViewBag.IdPlanoDeConta = new SelectList(gPlanoDeConta.ObterTodos(), "IdPlanoDeConta", "Descricao", grupoModel.IdPlanoDeConta);
            return View(grupoModel);
        }

        // [Authorize(Roles = "Síndico")]
        public ActionResult Edit(int id)
        {
            GrupoPlanoDeContasModel grupoModel = gGrupoPlanoDeContas.Obter(id);
            ViewBag.IdPlanoDeConta = new SelectList(gPlanoDeConta.ObterTodos(), "IdPlanoDeConta", "Descricao", grupoModel.IdPlanoDeConta);
            return View(grupoModel);
        }

        //
        // POST: /GrupoPlanoDeContas/Edit/5

        [HttpPost]
        public ActionResult Edit(GrupoPlanoDeContasModel grupoModel)
        {
            if (ModelState.IsValid)
            {
                gGrupoPlanoDeContas.Editar(grupoModel);
                return RedirectToAction("Index");
            }
            ViewBag.IdPlanoDeConta = new SelectList(gPlanoDeConta.ObterTodos(), "IdPlanoDeConta", "Descricao", grupoModel.IdPlanoDeConta);
            return View(grupoModel);
        }

        //
        // GET: /GrupoPlanoDeContas/Delete/5
        // [Authorize(Roles = "Síndico")]
        public ActionResult Delete(int id)
        {
            GrupoPlanoDeContasModel grupoModel = gGrupoPlanoDeContas.Obter(id);
            return View(grupoModel);
        }

        //
        // POST: /GrupoPlanoDeContas/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gGrupoPlanoDeContas.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
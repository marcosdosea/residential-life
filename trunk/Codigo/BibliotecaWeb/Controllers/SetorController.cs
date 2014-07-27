using System.Web.Mvc;
using Services;
using Models;

namespace BibliotecaWeb
{ 
    public class SetorController : Controller
    {
        private GerenciadorSetor gSetor;

        public SetorController()
        {
            gSetor = new GerenciadorSetor();
        }
        //
        // GET: /setor/

        public ViewResult Index()
        {
            return View(gSetor.ObterTodos());
        }

        //
        // GET: /setor/Details/5

        public ViewResult Details(int id)
        {
            SetorModel setor = gSetor.Obter(id);
            return View(setor);
        }

        //
        // GET: /setor/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /setor/Create

        [HttpPost]
        public ActionResult Create(SetorModel setorModel)
        {
            if (ModelState.IsValid)
            {
                gSetor.Inserir(setorModel);
                return RedirectToAction("Index");
            }
            return View(setorModel);
        }

        //
        // GET: /setor/Edit/5

        public ActionResult Edit(int id)
        {
            SetorModel setor = gSetor.Obter(id);
            return View(setor);
        }

        //
        // POST: /setor/Edit/5

        [HttpPost]
        public ActionResult Edit(SetorModel setorModel)
        {
            if (ModelState.IsValid)
            {
                gSetor.Editar(setorModel);
                return RedirectToAction("Index");
            }
            return View(setorModel);
        }

        //
        // GET: /setor/Delete/5

        public ActionResult Delete(int id)
        {
            SetorModel setorModel = gSetor.Obter(id);
            return View(setorModel);
        }

        //
        // POST: /setor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gSetor.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
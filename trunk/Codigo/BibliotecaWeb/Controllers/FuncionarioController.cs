using System.Web.Mvc;
using Models;
using Services;

namespace BibliotecaWeb
{ 
    public class FuncionarioController : Controller
    {
        private GerenciadorFuncionario gFuncionario;
        private GerenciadorPessoa gPessoa;
        private GerenciadorSetor gSetor;

        public FuncionarioController()
        {
            gFuncionario = new GerenciadorFuncionario();
            gPessoa = new GerenciadorPessoa();
            gSetor = new GerenciadorSetor();
        }

        //
        // GET: /Funcionario/

        public ActionResult Index()
        {
            return View(gFuncionario.ObterTodos());
        }

        //
        // GET: /Funcionario/Details/5

        public ViewResult Details(int id)
        {
            FuncionarioModel funcionario = gFuncionario.Obter(id);
            return View(funcionario);
        }

        //[Authorize(Roles = "Síndico")]
        public ActionResult Create()
        {
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            ViewBag.IdSetor = new SelectList(gSetor.ObterTodos(), "IdSetor", "Nome");
            return View();
        }

        //
        // POST: /Funcionario/Create

        [HttpPost]
        public ActionResult Create(FuncionarioModel funcionarioModel)
        {
            if (ModelState.IsValid)
            {
                gFuncionario.Inserir(funcionarioModel);
                return RedirectToAction("Index");
            }
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", funcionarioModel.IdPessoa);
            ViewBag.IdSetor = new SelectList(gSetor.ObterTodos(), "IdSetor", "Nome", funcionarioModel.IdSetor);
            return View(funcionarioModel);
        }

        // [Authorize(Roles = "Síndico")]
        public ActionResult Edit(int id)
        {
            FuncionarioModel funcionarioModel = gFuncionario.Obter(id);
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", funcionarioModel.IdPessoa);
            ViewBag.IdSetor = new SelectList(gSetor.ObterTodos(), "IdSetor", "Nome", funcionarioModel.IdSetor);
            return View(funcionarioModel);
        }

        //
        // POST: /Funcionario/Edit/5

        [HttpPost]
        public ActionResult Edit(FuncionarioModel funcionarioModel)
        {
            if (ModelState.IsValid)
            {
                gFuncionario.Editar(funcionarioModel);
                return RedirectToAction("Index");
            }
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", funcionarioModel.IdPessoa);
            ViewBag.IdSetor = new SelectList(gSetor.ObterTodos(), "IdSetor", "Nome", funcionarioModel.IdSetor);
            return View(funcionarioModel);
        }

        //
        // GET: /Funcionario/Delete/5
        // [Authorize(Roles = "Síndico")]
        public ActionResult Delete(int id)
        {
            FuncionarioModel funcionarioModel = gFuncionario.Obter(id);
            return View(funcionarioModel);
        }

        //
        // POST: /Funcionario/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gFuncionario.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
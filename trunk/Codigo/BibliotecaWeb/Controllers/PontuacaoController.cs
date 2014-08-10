using System.Web.Mvc;
using Models;
using Services;

namespace BibliotecaWeb
{
    public class PontuacaoController : Controller
    {
        private GerenciadorPontuacao gPontuacao;

        public PontuacaoController()
        {
            gPontuacao = new GerenciadorPontuacao();
        }
        //
        // GET: /pontuacao/

        public ViewResult Index()
        {
            return View(gPontuacao.ObterTodos());
        }

        //
        // GET: /pontuacao/Details/5

        public ViewResult Details(int id)
        {
            PontuacaoModel pontuacao = gPontuacao.Obter(id);
            return View(pontuacao);
        }

        //
        // GET: /pontuacao/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /pontuacao/Create

        [HttpPost]
        public ActionResult Create(PontuacaoModel pontuacaoModel)
        {
            if (ModelState.IsValid)
            {
                gPontuacao.Inserir(pontuacaoModel);
                return RedirectToAction("Index");
            }
            return View(pontuacaoModel);
        }

        //
        // GET: /pontuacao/Edit/5

        public ActionResult Edit(int id)
        {
            PontuacaoModel pontuacao = gPontuacao.Obter(id);
            return View(pontuacao);
        }

        //
        // POST: /pontuacao/Edit/5

        [HttpPost]
        public ActionResult Edit(PontuacaoModel pontuacaoModel)
        {
            if (ModelState.IsValid)
            {
                gPontuacao.Editar(pontuacaoModel);
                return RedirectToAction("Index");
            }
            return View(pontuacaoModel);
        }

        //
        // GET: /pontuacao/Delete/5

        public ActionResult Delete(int id)
        {
            PontuacaoModel pontuacaoModel = gPontuacao.Obter(id);
            return View(pontuacaoModel);
        }

        //
        // POST: /pontuacao/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gPontuacao.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
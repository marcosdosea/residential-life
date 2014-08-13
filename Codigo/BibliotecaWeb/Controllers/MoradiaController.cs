using System.Web.Mvc;
using Models;
using Services;
using System.Collections;
using System.Collections.Generic;

namespace BibliotecaWeb
{
    public class MoradiaController : Controller
    {
        
        private GerenciadorMoradia gMoradia;
        private GerenciadorBloco gBloco;
        private GerenciadorPessoa gPessoa;
        private GerenciadorCondominio gCondominio;
        private GerenciadorPessoaMoradia gPessoaMoradia;

        public MoradiaController()
        {
            gMoradia = new GerenciadorMoradia();
            gBloco = new GerenciadorBloco();
            gPessoa = new GerenciadorPessoa();
            gCondominio = new GerenciadorCondominio();
            gPessoaMoradia = new GerenciadorPessoaMoradia();
        }

        //
        // GET: /Moradia/

        public ActionResult Index()
        {
            IEnumerable<MoradiaModel> moradias;
            if (SessionController.IdRolePessoa.Equals(Global.IdPerfilSindico))
            {
                moradias = gMoradia.ObterTodosPorCondominio(SessionController.PessoaMoradia.IdCondominio);
            }
            else
            {
                moradias = gMoradia.ObterTodos();
            }
            return View(moradias);
        }

        //[Authorize(Roles = "Síndico")]
        public ActionResult Create()
        {
            int idCondominio = 0;
            if (SessionController.IdRolePessoa.Equals(Global.IdPerfilSindico))
            {
                idCondominio = SessionController.PessoaMoradia.IdCondominio;
            }
            ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(idCondominio), "IdBloco", "Nome");
            ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", idCondominio);
            return View();
        }

        //
        // POST: /Moradia/Create

        [HttpPost]
        public ActionResult Create(MoradiaModel moradia)
        {
            if (ModelState.IsValid)
            {
                gMoradia.Inserir(moradia);
                return RedirectToAction("Index");
            }
            ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(moradia.IdCondominio), "IdBloco", "Nome", moradia.IdBloco);
            ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", moradia.IdCondominio);
            return View(moradia);
        }

       // [Authorize(Roles = "Síndico")]
        public ActionResult Edit(int id)
        {
            MoradiaModel moradiaModel = gMoradia.Obter(id);
            ViewBag.IdBloco = new SelectList(gBloco.ObterTodos(), "IdBloco", "Nome", moradiaModel.IdBloco);
            return View(moradiaModel);
        }

        //
        // POST: /pessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(MoradiaModel moradiaModel)
        {
            if (ModelState.IsValid)
            {
                gMoradia.Editar(moradiaModel);
                return RedirectToAction("Index");
            }
            ViewBag.IdBloco = new SelectList(gBloco.ObterTodos(), "IdBloco", "Nome", moradiaModel.IdBloco);
            return View(moradiaModel);
        }

        //
        // GET: /pessoa/Delete/5
       // [Authorize(Roles = "Síndico")]
        public ActionResult Delete(int id)
        {
            MoradiaModel moradiaModel = gMoradia.Obter(id);
            return View(moradiaModel);
        }

        //
        // POST: /pessoa/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gMoradia.Remover(id);
            return RedirectToAction("Index");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models.Models;

namespace BibliotecaWeb.Controllers
{
    public class MoradiaController : Controller
    {

        private GerenciadorMoradia gMoradia;
        private GerenciadorBloco gBloco;
        private GerenciadorPessoa gPessoa;
        private GerenciadorTipoMoradia gTipoMoradia;
        
         public MoradiaController()
        {
            gMoradia = new GerenciadorMoradia();
            gBloco = new GerenciadorBloco();
            gPessoa = new GerenciadorPessoa();
            gTipoMoradia = new GerenciadorTipoMoradia();
        }

        //
        // GET: /Moradia/

        public ActionResult Index()
        {
            //int idBloco = gMoradia.ObterTodosPorBloco(idBloco);
            return View(gMoradia.ObterTodos());
        }

        [Authorize(Roles = "Síndico")]
        public ActionResult Create()
        {
            //Pegar somente as áreas públicas do condomínio corrente no futuro
            ViewBag.IdBloco = new SelectList(gBloco.ObterTodos(), "IdBloco", "Nome");
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            ViewBag.IdTipoMoradia = new SelectList(gTipoMoradia.ObterTodos(), "IdTipoMoradia", "TipoMoradia");
            return View();
        }

        //
        // POST: /Moradia/Create

        [HttpPost]
        public ActionResult Create(MoradiaModel moradiaModel)
        {
           
            if (ModelState.IsValid)
            {
                gMoradia.Inserir(moradiaModel);
                return RedirectToAction("Index");
            }

            return View(moradiaModel);
        }

        [Authorize(Roles = "Síndico")]
        public ActionResult Edit(int id)
        {

            MoradiaModel moradiaModel = gMoradia.Obter(id);
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", moradiaModel.IdPessoa);
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
            return View(moradiaModel);
        }

        //
        // GET: /pessoa/Delete/5
        [Authorize(Roles = "Síndico")]
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

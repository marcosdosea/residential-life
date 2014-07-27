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
        private GerenciadorCondominio gCondominio;

        public MoradiaController()
        {
            gMoradia = new GerenciadorMoradia();
            gBloco = new GerenciadorBloco();
            gPessoa = new GerenciadorPessoa();
            gCondominio = new GerenciadorCondominio();
        }

        //
        // GET: /Moradia/

        public ActionResult Index()
        {
            return View(gMoradia.ObterTodos());
        }

        //[Authorize(Roles = "Síndico")]
        public ActionResult Create()
        {
            //Pegar somente as áreas públicas do condomínio corrente no futuro
            ViewBag.IdBloco = new SelectList(gBloco.ObterTodos(), "IdBloco", "Nome");
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome");
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
            else
            {
                //ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(moradiaModel.IdCondominio), "IdBloco", "Nome");
                //ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", moradiaModel.IdPessoa);
                //ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", moradiaModel.IdCondominio);
            }
            return View(moradiaModel);
        }

       // [Authorize(Roles = "Síndico")]
        public ActionResult Edit(int id)
        {
            MoradiaModel moradiaModel = gMoradia.Obter(id);
            //ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", moradiaModel.IdPessoa);
            ViewBag.IdBloco = new SelectList(gBloco.ObterTodos(), "IdBloco", "Nome", moradiaModel.IdBloco);
            //ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", moradiaModel.IdCondominio);
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
            else
            {
                //ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(moradiaModel.IdCondominio), "IdBloco", "Nome");
                //ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", moradiaModel.IdPessoa);
                //ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", moradiaModel.IdCondominio);
            }
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

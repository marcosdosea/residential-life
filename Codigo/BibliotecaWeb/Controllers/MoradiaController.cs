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
        private GerenciadorTipoMoradia gTipoMoradia;
        
         public MoradiaController()
        {
            gMoradia = new GerenciadorMoradia();
            gBloco = new GerenciadorBloco();
            gTipoMoradia = new GerenciadorTipoMoradia();
        }

        //
        // GET: /Moradia/

        public ActionResult Index()
        {
            //int idBloco = gMoradia.ObterTodosPorBloco(idBloco);
            return View(gMoradia.ObterTodos());
        }

        [Authorize(Roles = "Morador")]
        public ActionResult Create()
        {
            //Pegar somente as áreas públicas do condomínio corrente no futuro
            ViewBag.IdBloco = new SelectList(gBloco.ObterTodos(), "IdBloco", "Bloco");
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

    }
}

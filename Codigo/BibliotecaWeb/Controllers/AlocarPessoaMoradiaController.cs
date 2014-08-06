using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Services;
using Models.Models;

namespace BibliotecaWeb.Controllers
{ 
    public class AlocarPessoaMoradiaController : Controller
    {
        private GerenciadorMoradia gMoradia;
        private GerenciadorPessoa gPessoa;
        private GerenciadorAlocarPessoaMoradia gPessoaMoradia;
        private GerenciadorCondominio gCondominio;
        private GerenciadorBloco gBloco;

        public AlocarPessoaMoradiaController()
        {
            gMoradia = new GerenciadorMoradia();
            gPessoa = new GerenciadorPessoa();
            gBloco = new GerenciadorBloco();
            gCondominio = new GerenciadorCondominio();
            gPessoaMoradia = new GerenciadorAlocarPessoaMoradia();
        }

        //
        // GET: /Moradia/

        public ActionResult Index()
        {
            return View(gPessoaMoradia.ObterTodos());
        }

        //[Authorize(Roles = "Síndico")]
        public ActionResult Create()
        {
            //Pegar somente as áreas públicas do condomínio corrente no futuro
            ViewBag.IdCondominio = new SelectList(GerenciadorCondominio.GetInstance().ObterTodos(), "IdCondominio", "Nome");
            ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(0), "IdBloco", "Nome");
            ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(0), "IdMoradia", "Numero");
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            return View();
        }

        //
        // POST: /Moradia/Create

        [HttpPost]
        public ActionResult Create(AlocarPessoaMoradiaModel alocarPessoaMoradiaModel)
        {
            if (alocarPessoaMoradiaModel.IdMoradia != 0 && alocarPessoaMoradiaModel.IdPessoa != 0)
            {
                if (ModelState.IsValid)
                {
                    gPessoaMoradia.Inserir(alocarPessoaMoradiaModel);
                    return RedirectToAction("Index");
                }
            }
            else
            {
                if (alocarPessoaMoradiaModel.IdBloco == 0)
                {
                    ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", alocarPessoaMoradiaModel.IdCondominio);
                    ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(alocarPessoaMoradiaModel.IdCondominio), "IdBloco", "Nome");
                    ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(0), "IdMoradia", "Numero");
                    ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", alocarPessoaMoradiaModel.IdPessoa);
                }
                else if (alocarPessoaMoradiaModel.IdMoradia == 0 && alocarPessoaMoradiaModel.IdBloco != 0)
                {
                    ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", alocarPessoaMoradiaModel.IdCondominio);
                    ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(alocarPessoaMoradiaModel.IdCondominio), "IdBloco", "Nome", alocarPessoaMoradiaModel.IdBloco);
                    ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(alocarPessoaMoradiaModel.IdBloco), "IdMoradia", "Numero");
                    ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", alocarPessoaMoradiaModel.IdPessoa);
                }
                else if (alocarPessoaMoradiaModel.IdMoradia != 0 &&  alocarPessoaMoradiaModel.IdBloco != 0)
                {
                    ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", alocarPessoaMoradiaModel.IdCondominio);
                    ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(alocarPessoaMoradiaModel.IdCondominio), "IdBloco", "Nome", alocarPessoaMoradiaModel.IdBloco);
                    ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(alocarPessoaMoradiaModel.IdBloco), "IdMoradia", "Numero", alocarPessoaMoradiaModel.NumeroMoradia);
                    alocarPessoaMoradiaModel.NumeroMoradia = gMoradia.Obter(alocarPessoaMoradiaModel.IdMoradia).Numero;
                    ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", alocarPessoaMoradiaModel.IdPessoa);
                }
            }
            return View(alocarPessoaMoradiaModel);
        }


        public ActionResult Edit(int idPessoa, int idMoradia)
        {
            AlocarPessoaMoradiaModel alocarPessoaMoradiaModel = gPessoaMoradia.Obter(idPessoa, idMoradia);
            ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", alocarPessoaMoradiaModel.IdCondominio);
            ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(alocarPessoaMoradiaModel.IdCondominio), "IdBloco", "Nome", alocarPessoaMoradiaModel.IdBloco);
            ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(alocarPessoaMoradiaModel.IdBloco), "IdMoradia", "Numero", alocarPessoaMoradiaModel.NumeroMoradia);
            alocarPessoaMoradiaModel.NumeroMoradia = gMoradia.Obter(alocarPessoaMoradiaModel.IdMoradia).Numero;
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", alocarPessoaMoradiaModel.IdPessoa);
            return View(alocarPessoaMoradiaModel);
        }

        [HttpPost]
        public ActionResult Edit(AlocarPessoaMoradiaModel alocarPessoaMoradiaModel)
        {
            if (ModelState.IsValid)
            {
                gPessoaMoradia.Editar(alocarPessoaMoradiaModel);
                return RedirectToAction("Index");
            }
            return View(alocarPessoaMoradiaModel);
        }

        //
        // GET: /pessoa/Delete/5
       // [Authorize(Roles = "Síndico")]
        public ActionResult Delete(int idPessoa, int idMoradia)
        {
            AlocarPessoaMoradiaModel alocarPessoaMoradiaModel = gPessoaMoradia.Obter(idPessoa, idMoradia);
            return View(alocarPessoaMoradiaModel);
        }

        //
        // POST: /pessoa/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int idPessoa, int idMoradia)
        {
            gPessoaMoradia.Remover(idPessoa, idMoradia);
            return RedirectToAction("Index");
        }

    }
}
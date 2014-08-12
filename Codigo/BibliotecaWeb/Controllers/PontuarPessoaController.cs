using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Services;

namespace BibliotecaWeb
{ 
    public class PontuarPessoaController : Controller
    {
        private GerenciadorPontuarPessoa gPontuarPessoa;
        private GerenciadorPessoa gPessoa;

        public PontuarPessoaController()
        {
            gPontuarPessoa = new GerenciadorPontuarPessoa();
            gPessoa = new GerenciadorPessoa();
        }
        //
        // GET: /pontuarPessoa/

        public ActionResult VisualizarPontuacoes(int idPessoa)
        {
            ViewBag.NomePessoa = gPessoa.Obter(idPessoa).Nome;
            return View(gPontuarPessoa.ObterPorPessoa(idPessoa));
        }
        /*
        public ViewResult Index()
        {
            return View(gPerfilPessoa.ObterProfissionaisEFuncionariosAtivos());
        }*/

        //
        // GET: /pontuarPessoa/Create

        public ActionResult Create(int idPessoa)
        {
            PontuarPessoaModel pontuarPessoa = new PontuarPessoaModel();
            pontuarPessoa.IdPessoa = idPessoa;
            pontuarPessoa.NomePessoa = gPessoa.Obter(idPessoa).Nome;
            pontuarPessoa.Comentario = "";
            pontuarPessoa.Pontuacao = pontuarPessoa.Pontuacao;
            return View(pontuarPessoa);
        }

        //
        // POST: /pontuarPessoa/Create

        [HttpPost]
        public ActionResult Create(PontuarPessoaModel pontuarPessoa)
        {
            if (ModelState.IsValid)
            {
                gPontuarPessoa.Inserir(pontuarPessoa);
                return RedirectToAction("Index");
            }
            return View(pontuarPessoa);
        }

        //
        // GET: /PontuarPessoa/Details/5

        public ViewResult Details(int id)
        {
            PontuarPessoaModel pontuarPessoa = gPontuarPessoa.Obter(id);
            return View(pontuarPessoa);
        }

        //
        // GET: /PontuarPessoa/Edit/5

        public ActionResult Edit(int id)
        {
            PontuarPessoaModel pontuarPessoa = gPontuarPessoa.Obter(id);
            return View(pontuarPessoa);
        }

        //
        // POST: /PontuarPessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(PontuarPessoaModel pontuarPessoa)
        {
            if (ModelState.IsValid)
            {
                gPontuarPessoa.Editar(pontuarPessoa);
                return RedirectToAction("Index");
            }
            return View(pontuarPessoa);
        }

        //
        // GET: /PontuarPessoa/Delete/5

        public ActionResult Delete(int id)
        {
            PontuarPessoaModel pontuarPessoa = gPontuarPessoa.Obter(id);
            return View(pontuarPessoa);
        }

        //
        // POST: /PontuarPessoa/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gPontuarPessoa.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
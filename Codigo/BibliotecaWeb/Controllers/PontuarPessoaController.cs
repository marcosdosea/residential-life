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
        private GerenciadorPerfilPessoa gPerfilPessoa;
        private GerenciadorPontuacao gPontuacao;
        private GerenciadorPessoa gPessoa;

        public PontuarPessoaController()
        {
            gPontuarPessoa = new GerenciadorPontuarPessoa();
            gPerfilPessoa = new GerenciadorPerfilPessoa();
            gPontuacao = new GerenciadorPontuacao();
            gPessoa = new GerenciadorPessoa();
        }
        //
        // GET: /pontuarPessoa/

        public ActionResult VisualizarPontuacoes(int idPessoa)
        {
            ViewBag.NomePessoa = gPessoa.Obter(idPessoa).Nome;
            return View(gPontuarPessoa.ObterPorPessoa(idPessoa));
        }

        public ViewResult Index()
        {
            return View(gPerfilPessoa.ObterProfissionaisEFuncionariosAtivos());
        }

        //
        // GET: /pontuarPessoa/Create

        public ActionResult Pontuar(int idPessoa)
        {
            PontuarPessoaModel pontuarPessoa = new PontuarPessoaModel();
            pontuarPessoa.IdPessoa = idPessoa;
            pontuarPessoa.NomePessoa = gPessoa.Obter(idPessoa).Nome;
            ViewBag.IdPontuacao = new SelectList(gPontuacao.ObterTodos(), "IdPontuacao", "Pontuacao");
            pontuarPessoa.Comentario = "";
            return View(pontuarPessoa);
        }

        //
        // POST: /pontuarPessoa/Create

        [HttpPost]
        public ActionResult Pontuar(PontuarPessoaModel pontuarPessoa)
        {
            if (ModelState.IsValid)
            {
                gPontuarPessoa.Inserir(pontuarPessoa);
                return RedirectToAction("Index");
            }
            ViewBag.IdPontuacao = new SelectList(gPontuacao.ObterTodos(), "IdPontuacao", "Pontuacao", pontuarPessoa.IdPontuacao);
            return View(pontuarPessoa);
        }
    }
}
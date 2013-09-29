﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models.Models;

namespace BibliotecaWeb.Controllers
{
    public class EnqueteController : Controller
    {
        //
        // GET: /Enquete/

        private GerenciadorEnquete gEnquete;
        private GerenciadorPessoa gPessoa;
        private GerenciadorStatusEnquete gStatusEnquete;
        private GerenciadorOpcaoEnquete gOpcao;

        public EnqueteController()
        {
            gEnquete = new GerenciadorEnquete();
            gStatusEnquete = new GerenciadorStatusEnquete();
            gPessoa = new GerenciadorPessoa();
            gOpcao = new GerenciadorOpcaoEnquete();
        }

        //[Authorize(Roles = "Síndico")]
        public ViewResult Index()
        {
            return View(gEnquete.ObterTodos());
        }
        [Authorize(Roles = "Síndico")]
        public ViewResult EmAndamento()
        {
            return View(gEnquete.ObterEnquetesAtivas());
        }
        [Authorize(Roles = "Síndico")]
        public ViewResult Finalizadas()
        {
            return View(gEnquete.ObterEnquetesFinalizadas());
        }
        //
        // GET: /enquete/Details/5
        [Authorize(Roles = "Síndico")]
        public ViewResult Details(int id)
        {
            EnqueteModel enquete = gEnquete.Obter(id);
            return View(enquete);
        }

        //
        // GET: /enquete/Create
        //[Authorize(Roles = "Síndico")]
        public ActionResult Create()
        {
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            ViewBag.IdStatusEnquete = new SelectList(gStatusEnquete.ObterTodos(), "IdStatusEnquete", "StatusEnquete");
            return View();
        }

        //
        // GET: /enquete/Votar
        //[Authorize(Roles = "Morador")]
        public ActionResult Votar()
        {
            return View(gEnquete.ObterEnquetesAtivas());
        }

        public ActionResult VotarEnquete(int id)
        {
            ViewBag.OpcoesEnquete = new SelectList(gOpcao.ObterOpcoesEnquete(id), "IdOpcao", "Descricao");
            return View();
        }

        //
        // POST: /enquete/Create

        [HttpPost]
        public ActionResult Create(OpcoesEnqueteModel opcoesEnqueteModel)
        {
            if (ModelState.IsValid)
            {
                int id_enquete = gEnquete.Inserir(opcoesEnqueteModel.Enquete);
               
                foreach (OpcaoModel opcao in opcoesEnqueteModel.Opcoes)
                {
                    gOpcao.Inserir(opcao, id_enquete);
                }
                return RedirectToAction("Index");
            }

            return View(opcoesEnqueteModel);
        }

      

        //
        // GET: /enquete/Delete/5
        [Authorize(Roles = "Síndico")]
        public ActionResult Delete(int id)
        {
            EnqueteModel enqueteModel = gEnquete.Obter(id);
            return View(enqueteModel);
        }

        //
        // POST: /enquete/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gEnquete.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


    }
}
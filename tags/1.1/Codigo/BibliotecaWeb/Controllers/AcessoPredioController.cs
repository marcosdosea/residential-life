using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models.Models;

namespace BibliotecaWeb.Controllers
{
    public class AcessoPredioController : Controller
    {
        private GerenciadorAcessoPredio gAcessoPredio;
        private GerenciadorPessoa gPessoa;


        public AcessoPredioController()
        {
            gAcessoPredio = new GerenciadorAcessoPredio();
            gPessoa = new GerenciadorPessoa();
        }



        //
        // GET: /AcessoPredio/

        public ActionResult Index()
        {
            return View(gAcessoPredio.ObterTodos());
        }


        //
        // GET: /Postagem/Create
        //  [Authorize(Roles = "Porteiro")]
        public ActionResult Create()
        {
            ViewBag.HoraAtual = DateTime.Now;
            ViewBag.Mensagem = ""; 
            return View();
        }

        //
        // POST: /Postagem/Create
        [HttpPost]
        public ActionResult Create(AcessoPredioModel acessoPredioModel)
        {
            ViewBag.HoraAtual = DateTime.Now;
            if (ModelState.IsValid)
            {
                if (gPessoa.existePessoa(acessoPredioModel.IdPessoa))
                {
                    gAcessoPredio.Inserir(acessoPredioModel);
                    return RedirectToAction("Index");
                }
                else
                    ViewBag.Mensagem = "Identificador de morador não encontrado no sistema!";
                
            }

            return View(acessoPredioModel);
        }

    }
}

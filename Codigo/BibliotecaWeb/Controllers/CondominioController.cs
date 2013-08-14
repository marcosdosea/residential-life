using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models.Models;

namespace BibliotecaWeb.Controllers
{
    public class CondominioController : Controller
    {

        private GerenciadorCondominio gCondominio;
     
        public CondominioController()
        {
            gCondominio = new GerenciadorCondominio();
        }
        //
        // GET: /Condominio/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /pessoa/Create

        [HttpPost]
        public ActionResult Create(CondominioModel condominioModel)
        {
            if (ModelState.IsValid)
            {
                gCondominio.Inserir(condominioModel);
                return RedirectToAction("Index");
            }

            return View(condominioModel);
        }


        //
        // GET: /pessoa/Edit/5

        public ActionResult Edit(int id)
        {

            CondominioModel pessoa = gCondominio.Obter(id);
            return View(pessoa);
        }

        //
        // POST: /pessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(CondominioModel pessoaModel)
        {
            if (ModelState.IsValid)
            {
                gCondominio.Editar(pessoaModel);
                return RedirectToAction("Index");
            }
            return View(pessoaModel);
        }

    }
}

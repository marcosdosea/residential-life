using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Services;

namespace BibliotecaWeb
{
    public class PerfilPessoaController : Controller
    {

        private GerenciadorPerfilPessoa gPerfilPessoa;
        private GerenciadorPessoa gPessoa;

        public PerfilPessoaController()
        {
            gPerfilPessoa = new GerenciadorPerfilPessoa();
            gPessoa = new GerenciadorPessoa();
        }

        //
        // GET: /PerfilPessoa/

        public ActionResult DefinirSindico()
        {
            return View(gPessoa.ObterTodos());
        }

        public ActionResult DefinirSindico(int idPessoa)
        {
            if (idPessoa > 0)
            {
                return RedirectToAction("DefinirSindico");
            }
            return View(gPessoa.ObterTodos());
        }

    }
}

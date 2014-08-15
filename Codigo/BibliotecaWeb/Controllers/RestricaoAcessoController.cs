using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;

namespace BibliotecaWeb
{
    public class RestricaoAcessoController : Controller
    {
        
        private GerenciadorRestricaoAcesso gRestricaoAcesso;

        public RestricaoAcessoController()
        {
            gRestricaoAcesso = new GerenciadorRestricaoAcesso();
        }

        
        //
        // GET: /RestricaoAcesso/

        public ActionResult AcessoVisitante()
        {
            return View();
        }

    }
}

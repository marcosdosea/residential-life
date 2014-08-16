using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using BibliotecaWeb;
using Models;
using Services;

namespace ResidentialWeb
{
    public class HomeController : Controller
    {

        GerenciadorPessoaMoradia gPessoaMoradia;
        GerenciadorPessoa gPessoa;

        public HomeController()
        {
            gPessoaMoradia = new GerenciadorPessoaMoradia();
            gPessoa = new GerenciadorPessoa();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Bem-Vindo ao Sistema Residential Life!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        

        public ActionResult SelecionarPerfil()
        {
            IEnumerable<PessoaMoradiaModel> pessoaMoradia = gPessoaMoradia.ObterTodosPorPessoa(
                gPessoa.ObterPessoaLogada((int)Membership.GetUser(true).ProviderUserKey).IdPessoa);
            if (pessoaMoradia.Count() == 1)
            {
                SessionController.PessoaMoradia = pessoaMoradia.ElementAtOrDefault(0);
                SessionController.IdRolePessoa = SessionController.PessoaMoradia.IdPerfil;
            }
            else
            {
                if (pessoaMoradia.Count() > 1)
                {
                    return View(pessoaMoradia);
                }
            }
            return RedirectToAction("Index");
        }

        
        public ActionResult Selecionar(int idPessoa, int idPerfil, int idMoradia)
        {
            SessionController.PessoaMoradia = gPessoaMoradia.Obter(idPessoa, idMoradia, idPerfil);
            SessionController.IdRolePessoa = idPerfil;
            return RedirectToAction("Index");
        }
    }
}

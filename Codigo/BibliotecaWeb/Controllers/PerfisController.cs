using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Services;

namespace BibliotecaWeb
{
    public class PerfisController : Controller
    {
        private GerenciadorMoradia gMoradia;
        private GerenciadorBloco gBloco;
        private GerenciadorPessoa gPessoa;
        private GerenciadorCondominio gCondominio;
        private GerenciadorPessoaMoradia gPessoaMoradia;

        public PerfisController()
        {
            gMoradia = new GerenciadorMoradia();
            gBloco = new GerenciadorBloco();
            gPessoa = new GerenciadorPessoa();
            gCondominio = new GerenciadorCondominio();
            gPessoaMoradia = new GerenciadorPessoaMoradia();
        }


        public ActionResult DefinirSindico()
        {
            ViewBag.IdCondominio = new SelectList(GerenciadorCondominio.GetInstance().ObterTodos(), "IdCondominio", "Nome");
            ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(0), "IdBloco", "Nome");
            ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(0), "IdMoradia", "Numero");
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            return View();
        }


        [HttpPost]
        public ActionResult DefinirSindico(PessoaMoradiaModel pessoaMoradia)
        {
            if (pessoaMoradia.IdMoradia != 0 && pessoaMoradia.IdPessoa != 0)
            {
                pessoaMoradia.IdPerfil = Global.IdPerfilSindico;
                pessoaMoradia.Ativo = true;
                if (ModelState.IsValid)
                {
                    gPessoaMoradia.InserirEditar(pessoaMoradia);
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                if (pessoaMoradia.IdBloco == 0)
                {
                    ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", pessoaMoradia.IdCondominio);
                    ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(pessoaMoradia.IdCondominio), "IdBloco", "Nome");
                    ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(0), "IdMoradia", "Numero");
                    ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", pessoaMoradia.IdPessoa);
                }
                else if (pessoaMoradia.IdMoradia == 0 && pessoaMoradia.IdBloco != 0)
                {
                    ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", pessoaMoradia.IdCondominio);
                    ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(pessoaMoradia.IdCondominio), "IdBloco", "Nome",
                        pessoaMoradia.IdBloco);
                    ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(pessoaMoradia.IdBloco), "IdMoradia", "Numero");
                    ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", pessoaMoradia.IdPessoa);
                }
                else if (pessoaMoradia.IdMoradia != 0 && pessoaMoradia.IdBloco != 0)
                {
                    ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", pessoaMoradia.IdCondominio);
                    ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(pessoaMoradia.IdCondominio), "IdBloco", "Nome",
                        pessoaMoradia.IdBloco);
                    ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(pessoaMoradia.IdBloco), "IdMoradia", "Numero",
                        pessoaMoradia.NumeroMoradia);
                    pessoaMoradia.NumeroMoradia = gMoradia.Obter(pessoaMoradia.IdMoradia).Numero;
                    ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", pessoaMoradia.IdPessoa);
                }
            }
            return View(pessoaMoradia);
        }


        public ActionResult RemoverSindico()
        {
            return View(gPessoaMoradia.ObterPorPerfilAtivo(Global.IdPerfilSindico));
        }

        //[HttpPost]
        public ActionResult Remover(int idPessoa, int idMoradia, int idPerfil)
        {
            PessoaMoradiaModel pessoaMoradia = new PessoaMoradiaModel();
            pessoaMoradia.IdPessoa = idPessoa;
            pessoaMoradia.IdMoradia = idMoradia;
            pessoaMoradia.IdPerfil = idPerfil;
            pessoaMoradia.Ativo = false;
            gPessoaMoradia.Editar(pessoaMoradia);
            return RedirectToAction("RemoverSindico", "Perfis");
        }

        public ActionResult Proprietario()
        {
            return View(gPessoaMoradia.ObterPorPerfilCondominioAtivo(Global.IdPerfilProprietario,
                SessionController.PessoaMoradia.IdCondominio));
        }


        public ActionResult DefinirProprietario()
        {
            ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(SessionController.PessoaMoradia.IdCondominio), "IdBloco", "Nome");
            ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(0), "IdMoradia", "Numero");
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult DefinirProprietario(PessoaMoradiaModel pessoaMoradia)
        {
            pessoaMoradia.IdPerfil = Global.IdPerfilProprietario;
            pessoaMoradia.Ativo = true;
            if (pessoaMoradia.IdBloco > 0 && pessoaMoradia.IdMoradia > 0)
            {
                if (ModelState.IsValid)
                {
                    gPessoaMoradia.InserirEditar(pessoaMoradia);
                    return RedirectToAction("Proprietario", "Perfis");
                }
            }
            ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(SessionController.PessoaMoradia.IdCondominio), "IdBloco", "Nome",
                pessoaMoradia.IdBloco);
            ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(pessoaMoradia.IdBloco), "IdMoradia", "Numero",
                pessoaMoradia.IdMoradia);
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", pessoaMoradia.IdPessoa);
            return View(pessoaMoradia);
        }

        public ActionResult RemoverProprietario(int idPessoa, int idMoradia, int idPerfil)
        {
            PessoaMoradiaModel pessoaMoradia = new PessoaMoradiaModel();
            pessoaMoradia.IdPessoa = idPessoa;
            pessoaMoradia.IdMoradia = idMoradia;
            pessoaMoradia.IdPerfil = idPerfil;
            pessoaMoradia.Ativo = false;
            gPessoaMoradia.Editar(pessoaMoradia);
            return RedirectToAction("Proprietario", "Perfis");
        }

        public ActionResult Responsavel()
        {
            return View(gPessoaMoradia.ObterPorMoradiaPerfilAtivo(SessionController.PessoaMoradia.IdMoradia, Global.IdPerfilResponsavel));
        }

        public ActionResult DefinirResponsavel()
        {
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            return View();
        }


        [HttpPost]
        public ActionResult DefinirResponsavel(PessoaMoradiaModel pessoaMoradia)
        {
            pessoaMoradia.IdPerfil = Global.IdPerfilResponsavel;
            pessoaMoradia.IdMoradia = SessionController.PessoaMoradia.IdMoradia;
            pessoaMoradia.Ativo = true;
            if (ModelState.IsValid)
            {
                gPessoaMoradia.InserirEditar(pessoaMoradia);
                return RedirectToAction("Responsavel", "Perfis");
            }
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", pessoaMoradia.IdPessoa);
            return View(pessoaMoradia);
        }


        //[HttpPost]
        public ActionResult RemoverResponsavel(int idPessoa, int idMoradia, int idPerfil)
        {
            PessoaMoradiaModel pessoaMoradia = new PessoaMoradiaModel();
            pessoaMoradia.IdPessoa = idPessoa;
            pessoaMoradia.IdMoradia = idMoradia;
            pessoaMoradia.IdPerfil = idPerfil;
            pessoaMoradia.Ativo = false;
            gPessoaMoradia.Editar(pessoaMoradia);
            return RedirectToAction("Responsavel", "Perfis");
        }
    }
}

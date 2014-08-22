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
        private GerenciadorRestricaoAcesso gRestricaoAcesso;

        public PerfisController()
        {
            gMoradia = new GerenciadorMoradia();
            gBloco = new GerenciadorBloco();
            gPessoa = new GerenciadorPessoa();
            gCondominio = new GerenciadorCondominio();
            gPessoaMoradia = new GerenciadorPessoaMoradia();
            gRestricaoAcesso = new GerenciadorRestricaoAcesso();
        }

        public ActionResult Sindico()
        {
            return View(gPessoaMoradia.ObterPorPerfilAtivo(Global.IdPerfilSindico));
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
                    return RedirectToAction("Sindico");
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

        //[HttpPost]
        public ActionResult RemoverSindico(int idPessoa, int idMoradia, int idPerfil)
        {
            PessoaMoradiaModel pessoaMoradia = new PessoaMoradiaModel();
            pessoaMoradia.IdPessoa = idPessoa;
            pessoaMoradia.IdMoradia = idMoradia;
            pessoaMoradia.IdPerfil = idPerfil;
            pessoaMoradia.Ativo = false;
            gPessoaMoradia.Editar(pessoaMoradia);
            return RedirectToAction("Sindico");
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
                    return RedirectToAction("Proprietario");
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
            return RedirectToAction("Proprietario");
        }

        ////////////////////////////////////////////////////
        // Funcionarios
        ///////////////////////////////////////////////////

        public ActionResult Funcionario()
        {
            return View(gPessoaMoradia.ObterTodosPorMoradiaPerfilAtivo(SessionController.PessoaMoradia.IdMoradia, Global.IdPerfilFuncionario));
        }

        //[Authorize(Roles = "Síndico")]
        public ActionResult DefinirFuncionario()
        {
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult DefinirFuncionario(PessoaMoradiaModel pessoaMoradia)
        {
            pessoaMoradia.IdPerfil = Global.IdPerfilFuncionario;
            pessoaMoradia.IdMoradia = SessionController.PessoaMoradia.IdMoradia;
            pessoaMoradia.Ativo = true;
            if (ModelState.IsValid)
            {
                gPessoaMoradia.InserirEditar(pessoaMoradia);
                return RedirectToAction("Funcionario");
            }
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", pessoaMoradia.IdPessoa);
            return View(pessoaMoradia);
        }

        //
        // POST: /pessoa/Delete/5

        public ActionResult RemoverFuncionario(int idPessoa, int idMoradia, int idPerfil)
        {
            PessoaMoradiaModel pessoaMoradia = gPessoaMoradia.Obter(idPessoa, idMoradia, idPerfil);
            pessoaMoradia.Ativo = false;
            gPessoaMoradia.Editar(pessoaMoradia);
            return RedirectToAction("Funcionario");
        }

        public ActionResult RestricoesFuncionario(int idMoradia, int idPessoa)
        {
            SessionController.IdFuncionario = idPessoa;
            return View(gRestricaoAcesso.ObterPorMoradiaPessoa(idMoradia, idPessoa));
        }

        public ActionResult NovaRestricaoFuncionario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NovaRestricaoFuncionario(RestricaoAcessoModel restricaoAcesso)
        {
            restricaoAcesso.IdMoradia = SessionController.PessoaMoradia.IdMoradia;
            restricaoAcesso.IdPessoa = SessionController.IdFuncionario;
            restricaoAcesso.Restrito = true;
            if (ModelState.IsValid)
            {
                if (restricaoAcesso.Segunda == true)
                {
                    restricaoAcesso.Dia = ListaDia.Segunda;
                    gRestricaoAcesso.Inserir(restricaoAcesso);
                }
                if (restricaoAcesso.Terca == true)
                {
                    restricaoAcesso.Dia = ListaDia.Terca;
                    gRestricaoAcesso.Inserir(restricaoAcesso);
                }
                if (restricaoAcesso.Quarta == true)
                {
                    restricaoAcesso.Dia = ListaDia.Quarta;
                    gRestricaoAcesso.Inserir(restricaoAcesso);
                }
                if (restricaoAcesso.Quinta == true)
                {
                    restricaoAcesso.Dia = ListaDia.Quinta;
                    gRestricaoAcesso.Inserir(restricaoAcesso);
                }
                if (restricaoAcesso.Sexta == true)
                {
                    restricaoAcesso.Dia = ListaDia.Sexta;
                    gRestricaoAcesso.Inserir(restricaoAcesso);
                }
                if (restricaoAcesso.Sabado == true)
                {
                    restricaoAcesso.Dia = ListaDia.Sabado;
                    gRestricaoAcesso.Inserir(restricaoAcesso);
                }
                if (restricaoAcesso.Domingo == true)
                {
                    restricaoAcesso.Dia = ListaDia.Domingo;
                    gRestricaoAcesso.Inserir(restricaoAcesso);
                }
                return View("RestricoesFuncionario", gRestricaoAcesso.ObterPorMoradiaPessoa(restricaoAcesso.IdMoradia,
                    restricaoAcesso.IdPessoa));
            }
            return View(restricaoAcesso);
        }

        public ActionResult RemoverRestricaoAcessoFuncionario(int idRestricaoAcesso, int idMoradia, int idPessoa)
        {
            gRestricaoAcesso.Remover(idRestricaoAcesso);
            return View("RestricoesFuncionario", gRestricaoAcesso.ObterPorMoradiaPessoa(idMoradia, idPessoa));
        }

        ///////////////////////////////////////
        // Fim Funcionario
        //////////////////////////////////////

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
                return RedirectToAction("Responsavel");
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
            return RedirectToAction("Responsavel");
        }
    }
}

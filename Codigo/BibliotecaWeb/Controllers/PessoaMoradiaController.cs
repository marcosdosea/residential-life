using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using Models;
using Services;

namespace BibliotecaWeb
{
    public class PessoaMoradiaController : Controller
    {
        private GerenciadorMoradia gMoradia;
        private GerenciadorPessoa gPessoa;
        private GerenciadorPessoaMoradia gPessoaMoradia;
        private GerenciadorCondominio gCondominio;
        private GerenciadorBloco gBloco;
        private GerenciadorRestricaoAcesso gRestricaoAcesso;

        public PessoaMoradiaController()
        {
            gMoradia = new GerenciadorMoradia();
            gPessoa = new GerenciadorPessoa();
            gBloco = new GerenciadorBloco();
            gCondominio = new GerenciadorCondominio();
            gPessoaMoradia = new GerenciadorPessoaMoradia();
            gRestricaoAcesso = new GerenciadorRestricaoAcesso();
        }

        public ActionResult Morador()
        {
            return View(gPessoaMoradia.ObterTodosPorMoradiaPerfilAtivo(SessionController.PessoaMoradia.IdMoradia, Global.IdPerfilMorador));
        }

        //[Authorize(Roles = "Síndico")]
        public ActionResult DefinirMorador()
        {
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult DefinirMorador(PessoaMoradiaModel pessoaMoradia)
        {
            pessoaMoradia.IdPerfil = Global.IdPerfilMorador;
            pessoaMoradia.IdMoradia = SessionController.PessoaMoradia.IdMoradia;
            pessoaMoradia.Ativo = true;
            if (ModelState.IsValid)
            {
                PessoaMoradiaModel pm = gPessoaMoradia.Obter(pessoaMoradia.IdPessoa, pessoaMoradia.IdMoradia, pessoaMoradia.IdPerfil);
                if (pm == null)
                {
                    RestricaoAcessoModel restricaoAcesso = new RestricaoAcessoModel();
                    restricaoAcesso.IdMoradia = SessionController.PessoaMoradia.IdMoradia;
                    restricaoAcesso.IdPessoa = pessoaMoradia.IdPessoa;
                    restricaoAcesso.Restrito = false;
                    gPessoaMoradia.Inserir(pessoaMoradia);
                    gRestricaoAcesso.Inserir(restricaoAcesso);
                }
                else
                {
                    gPessoaMoradia.Editar(pessoaMoradia);
                }
                return RedirectToAction("Morador");
            }
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", pessoaMoradia.IdPessoa);
            return View(pessoaMoradia);
        }

        //
        // POST: /pessoa/Delete/5

        public ActionResult RemoverMorador(int idPessoa, int idMoradia, int idPerfil)
        {
            PessoaMoradiaModel pessoaMoradia = gPessoaMoradia.Obter(idPessoa, idMoradia, idPerfil);
            pessoaMoradia.Ativo = false;
            gPessoaMoradia.Editar(pessoaMoradia);
            return RedirectToAction("Morador");
        }

        public ActionResult Visitante()
        {
            return View(gPessoaMoradia.ObterTodosPorMoradiaPerfilAtivo(SessionController.PessoaMoradia.IdMoradia, Global.IdPerfilVisitante));
        }

        //[Authorize(Roles = "Síndico")]
        public ActionResult DefinirVisitante()
        {
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult DefinirVisitante(PessoaMoradiaModel pessoaMoradia)
        {
            pessoaMoradia.IdPerfil = Global.IdPerfilVisitante;
            pessoaMoradia.IdMoradia = SessionController.PessoaMoradia.IdMoradia;
            pessoaMoradia.Ativo = true;
            if (ModelState.IsValid)
            {
                gPessoaMoradia.InserirEditar(pessoaMoradia);
                return RedirectToAction("Visitante");
            }
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", pessoaMoradia.IdPessoa);
            return View(pessoaMoradia);
        }

        //
        // POST: /pessoa/Delete/5

        public ActionResult RemoverVisitante(int idPessoa, int idMoradia, int idPerfil)
        {
            PessoaMoradiaModel pessoaMoradia = gPessoaMoradia.Obter(idPessoa, idMoradia, idPerfil);
            pessoaMoradia.Ativo = false;
            gPessoaMoradia.Editar(pessoaMoradia);
            return RedirectToAction("Visitante");
        }

        public ActionResult RestricoesVisitante(int idMoradia, int idPessoa)
        {
            SessionController.IdVisitante = idPessoa;
            return View(gRestricaoAcesso.ObterPorMoradiaPessoa(idMoradia, idPessoa));
        }

        public ActionResult NovaRestricaoVisitante()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NovaRestricaoVisitante(RestricaoAcessoModel restricaoAcesso)
        {
            restricaoAcesso.IdMoradia = SessionController.PessoaMoradia.IdMoradia;
            restricaoAcesso.IdPessoa = SessionController.IdVisitante;
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
                return View("RestricoesVisitante", gRestricaoAcesso.ObterPorMoradiaPessoa(restricaoAcesso.IdMoradia, 
                    restricaoAcesso.IdPessoa));
            }
            return View(restricaoAcesso);
        }

        public ActionResult RemoverRestricaoAcessoVisitante(int idRestricaoAcesso, int idMoradia, int idPessoa)
        {
            gRestricaoAcesso.Remover(idRestricaoAcesso);
            return View("RestricoesVisitante", gRestricaoAcesso.ObterPorMoradiaPessoa(idMoradia, idPessoa));
        }

        public ActionResult ReportPessoaMoradia()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Relatorios/ReportPessoaMoradia.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetPessoaMoradia", gPessoaMoradia.ObterTodos()));

            string reportType = "PDF";
            string mimeType;
            string encoding;
            string fileNameExtension;

            string deviceInfo =
             "<DeviceInfo>" +
             " <OutputFormat>PDF</OutputFormat>" +
             " <PageWidth>9in</PageWidth>" +
             " <PageHeight>11in</PageHeight>" +
             " <MarginTop>0.7in</MarginTop>" +
             " <MarginLeft>2in</MarginLeft>" +
             " <MarginRight>2in</MarginRight>" +
             " <MarginBottom>0.7in</MarginBottom>" +
             "</DeviceInfo>";

            Warning[] warnings;
            string[] streams;
            byte[] bytes;

            //Renderiza o relatório em bytes
            bytes = relatorio.Render(
            reportType,
            deviceInfo,
            out mimeType,
            out encoding,
            out fileNameExtension,
            out streams,
            out warnings);

            return File(bytes, mimeType);

        }
    }
}
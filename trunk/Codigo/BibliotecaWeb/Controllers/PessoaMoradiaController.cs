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
        private GerenciadorAcessoCondominio gAcessoCondominio;

        public PessoaMoradiaController()
        {
            gMoradia = new GerenciadorMoradia();
            gPessoa = new GerenciadorPessoa();
            gBloco = new GerenciadorBloco();
            gCondominio = new GerenciadorCondominio();
            gPessoaMoradia = new GerenciadorPessoaMoradia();
            gAcessoCondominio = new GerenciadorAcessoCondominio();
        }

        public ActionResult Morador()
        {
            return View(gPessoaMoradia.ObterTodosPorMoradiaPerfil(SessionController.PessoaMoradia.IdMoradia, Global.IdPerfilMorador));
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
                    gPessoaMoradia.Inserir(pessoaMoradia);
                    /*
                    AcessoCondominioModel acessoCondominio = new AcessoCondominioModel()
                    acessoCondominio.
                    gAcessoCondominio.Inserir(); */
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
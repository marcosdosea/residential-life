using System;
using System.Web.Mvc;
using System.Web.Security;
using Models;
using Services;

namespace BibliotecaWeb
{
    public class EnqueteController : Controller
    {
        //
        // GET: /Enquete/

        private GerenciadorEnquete gEnquete;
        private GerenciadorPessoa gPessoa;

        public EnqueteController()
        {
            gEnquete = new GerenciadorEnquete();
            gPessoa = new GerenciadorPessoa();
        }

        // [Authorize(Roles = "Síndico")]
        public ViewResult Index()
        {
            return View(gEnquete.ObterTodos());
        }

        //
        // GET: /enquete/Details/5
        // [Authorize(Roles = "Síndico")]
        public ViewResult Details(int id)
        {
            EnqueteModel enquete = gEnquete.Obter(id);
            return View(enquete);
        }

        //
        // GET: /enquete/Create
        // [Authorize(Roles = "Síndico")]
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /enquete/Create
        [HttpPost]
        public ActionResult Create(EnqueteModel enquente)
        {
            enquente.IdPessoa = gPessoa.ObterPessoaLogada((int)Membership.GetUser(true).ProviderUserKey).IdPessoa;
            enquente.DataInicio = DateTime.Now;
            if (ModelState.IsValid)
            {
                gEnquete.Inserir(enquente);
                return RedirectToAction("Index");
            }
            return View(enquente);
        }

        public ActionResult Edit(int id)
        {
            EnqueteModel enqueteModel = gEnquete.Obter(id);
            return View(enqueteModel);
        }


        [HttpPost]
        public ActionResult Edit(EnqueteModel enquente)
        {
            if (ModelState.IsValid)
            {
                gEnquete.Editar(enquente);
                return RedirectToAction("Index");
            }
            return View(enquente);
        }

        //
        // GET: /enquete/Delete/5
        //[Authorize(Roles = "Síndico")]
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

        /*
        public ActionResult RelatorioVotosEnquete(int id)
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Relatorios/ReportVotosEnquete.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetVotosEnquete", gVoto.ObterVotosEnquetes(id)));

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

        }*/
    }
}

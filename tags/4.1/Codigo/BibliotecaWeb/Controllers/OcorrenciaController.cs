using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using Models;
using Services;

namespace BibliotecaWeb
{
    public class OcorrenciaController : Controller
    {
        private GerenciadorOcorrencia gOcorrencia;
        private GerenciadorPessoa gPessoa;

        public OcorrenciaController()
        {
            gOcorrencia = new GerenciadorOcorrencia();
            gPessoa = new GerenciadorPessoa();

        }

        //
        // GET: /Ocorrencia/

        public ActionResult Index()
        {
            //int idPessoa = gPessoa.ObterPorUsername(Membership.GetUser(true).UserName).IdPessoa;
            //return View(gOcorrencia.ObterTodosPorPessoa(idPessoa));
            return View(gOcorrencia.ObterTodos());
        }

        //
        // GET: /Ocorrencia/Details/5
        public ViewResult Details(int id)
        {
            OcorrenciaModel Ocorrencia = gOcorrencia.Obter(id);
            return View(Ocorrencia);
        }

        //
        // GET: /Ocorrencia/Create 
        public ActionResult Create()
        {
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            return View();
        }

        //
        // POST: /Ocorrencia/Create

        [HttpPost]
        public ActionResult Create(OcorrenciaModel ocorrenciaModel)
        {
            //ocorrenciaModel.IdPessoa = gPessoa.ObterPorUsername(Membership.GetUser(true).UserName).IdPessoa;
            if (ModelState.IsValid)
            {
                gOcorrencia.Inserir(ocorrenciaModel);
                return RedirectToAction("Index");
            }

            return View(ocorrenciaModel);
        }

        //
        // GET: /Ocorrencia/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            OcorrenciaModel Ocorrencia = gOcorrencia.Obter(id);

            return View(Ocorrencia);
        }

        //
        // POST: /Ocorrencia/Edit/5

        [HttpPost]
        public ActionResult Edit(OcorrenciaModel OcorrenciaModel)
        {
            if (ModelState.IsValid)
            {
                gOcorrencia.Editar(OcorrenciaModel);
                return RedirectToAction("Index");
            }
            return View(OcorrenciaModel);
        }

        //
        // GET: /Ocorrencia/Delete/5
        public ActionResult Delete(int id)
        {
            OcorrenciaModel OcorrenciaModel = gOcorrencia.Obter(id);
            return View(OcorrenciaModel);
        }

        //
        // POST: /Ocorrencia/Delete/5
        public ActionResult DeleteConfirmed(int id)
        {
            gOcorrencia.Remover(id);
            return RedirectToAction("Index");
        }

        public ActionResult RelatorioOcorrencia()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Relatorios/Ocorrencia.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("RegistroOcorrencia", gOcorrencia.ObterTodos()));

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

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}

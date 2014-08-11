using System.Web.Mvc;
using Services;
using Models.Models;
using Microsoft.Reporting.WebForms;

namespace BibliotecaWeb.Controllers
{ 
    public class AcessoVeiculoController : Controller
    {
        private GerenciadorAcessoVeiculo gAcessoVeiculo;
        private GerenciadorVeiculo gVeiculo;

        public AcessoVeiculoController()
        {
            gAcessoVeiculo = new GerenciadorAcessoVeiculo();
            gVeiculo = new GerenciadorVeiculo();
        }

        //
        // GET: /GrupoPlanoDeContas/

        public ActionResult Index()
        {
            return View(gAcessoVeiculo.ObterTodos());
        }

        //
        // GET: /GrupoPlanoDeContas/Details/5

        public ViewResult Details(int id)
        {
            AcessoVeiculoModel grupo = gAcessoVeiculo.Obter(id);
            return View(grupo);
        }

        //[Authorize(Roles = "Síndico")]
        public ActionResult Create()
        {
            ViewBag.IdVeiculo = new SelectList(gVeiculo.ObterTodos(), "IdVeiculo", "Placa");
            return View();
        }

        //
        // POST: /GrupoPlanoDeContas/Create

        [HttpPost]
        public ActionResult Create(AcessoVeiculoModel acessoVeiculo)
        {
            if (ModelState.IsValid)
            {
                gAcessoVeiculo.Inserir(acessoVeiculo);
                return RedirectToAction("Index");
            }
            ViewBag.IdVeiculo = new SelectList(gVeiculo.ObterTodos(), "IdVeiculo", "Placa");
            return View(acessoVeiculo);
        }

        // [Authorize(Roles = "Síndico")]
        public ActionResult Edit(int id)
        {
            AcessoVeiculoModel acessoVeiculo = gAcessoVeiculo.Obter(id);
            ViewBag.IdVeiculo = new SelectList(gVeiculo.ObterTodos(), "IdVeiculo", "Placa", acessoVeiculo.IdVeiculo);
            return View(acessoVeiculo);
        }

        //
        // POST: /GrupoPlanoDeContas/Edit/5

        [HttpPost]
        public ActionResult Edit(AcessoVeiculoModel acessoVeiculo)
        {
            if (ModelState.IsValid)
            {
                gAcessoVeiculo.Editar(acessoVeiculo);
                return RedirectToAction("Index");
            }
            ViewBag.IdVeiculo = new SelectList(gVeiculo.ObterTodos(), "IdVeiculo", "Placa");
            return View(acessoVeiculo);
        }

        //
        // GET: /GrupoPlanoDeContas/Delete/5
        // [Authorize(Roles = "Síndico")]
        public ActionResult Delete(int id)
        {
            AcessoVeiculoModel acessoVeiculo = gAcessoVeiculo.Obter(id);
            return View(acessoVeiculo);
        }

        //
        // POST: /GrupoPlanoDeContas/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gAcessoVeiculo.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public ActionResult ReportAcessoVeiculo()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Relatorios/ReportAcessoVeiculo.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetAcessoVeiculo", gAcessoVeiculo.ObterTodos()));

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models.Models;
using Microsoft.Reporting.WebForms;

namespace BibliotecaWeb.Controllers
{
    public class AreaPublicaController : Controller
    {
        private GerenciadorAreaPublica gAreaPublica;
        private GerenciadorCondominio gCondominio;
        private GerenciadorStatusAreaPublica gStatusAreaPublica;

        public AreaPublicaController()
        {
            gAreaPublica = new GerenciadorAreaPublica();
            gCondominio = new GerenciadorCondominio();
            gStatusAreaPublica = new GerenciadorStatusAreaPublica();
        }
        //
        // GET: /AreaPublica/

        public ViewResult Index()
        {
            return View(gAreaPublica.ObterTodos());
        }

        
        //
        // GET: /AreaPublica/Details/5

        public ViewResult Details(int id)
        {
            AreaPublicaModel AreaPublica = gAreaPublica.Obter(id);
            return View(AreaPublica);
        }

        //
        // GET: /AreaPublica/Create

        public ActionResult Create()
        {
            ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome");
            ViewBag.IdStatusAreaPublica = new SelectList(gStatusAreaPublica.ObterTodos(), "IdStatusAreaPublica", "Status");
            return View();
        }

        //
        // POST: /AreaPublica/Create

        [HttpPost]
        public ActionResult Create(AreaPublicaModel AreaPublicaModel)
        {
            if (ModelState.IsValid)
            {
                gAreaPublica.Inserir(AreaPublicaModel);
                return RedirectToAction("Index");
            }

            return View(AreaPublicaModel);
        }

        //
        // GET: /AreaPublica/Edit/5

        public ActionResult Edit(int id)
        {

            AreaPublicaModel AreaPublica = gAreaPublica.Obter(id);


            ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IDCondominio", "Nome", AreaPublica.IdCondominio);
            ViewBag.IdStatusAreaPublica = new SelectList(gStatusAreaPublica.ObterTodos(), "IdStatusAreaPublica", "Status");
            return View(AreaPublica);
        }

        //
        // POST: /AreaPublica/Edit/5

        [HttpPost]
        public ActionResult Edit(AreaPublicaModel AreaPublicaModel)
        {
            if (ModelState.IsValid)
            {
                gAreaPublica.Editar(AreaPublicaModel);
                return RedirectToAction("Index");
            }
            return View(AreaPublicaModel);
        }

        //
        // GET: /AreaPublica/Delete/5

        public ActionResult Delete(int id)
        {
            AreaPublicaModel AreaPublicaModel = gAreaPublica.Obter(id);
            return View(AreaPublicaModel);
        }

        //
        // POST: /AreaPublica/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gAreaPublica.Remover(id);
            return RedirectToAction("Index");
        }

       
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public ActionResult RelatorioAreaPublica()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Relatorios/ReportListaAreaPublica.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetAreaPublica", gAreaPublica.ObterTodos()));

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
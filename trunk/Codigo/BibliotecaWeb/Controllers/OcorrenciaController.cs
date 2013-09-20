using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models;
using Microsoft.Reporting.WebForms;

namespace BibliotecaWeb.Controllers
{
    public class OcorrenciaController : Controller
    {

        private GerenciadorPessoa gPessoa;
        private GerenciadorOcorrencia gOcorrencia;
        private GerenciadorStatusOcorrencia gStatusOcorrencia;
        private GerenciadorTipoOcorrencia gTipoOcorrencia;

        public OcorrenciaController()
        {
            gOcorrencia = new GerenciadorOcorrencia();
            gPessoa = new GerenciadorPessoa();
            gStatusOcorrencia = new GerenciadorStatusOcorrencia();
            gTipoOcorrencia = new GerenciadorTipoOcorrencia();

        }


        //
        // GET: /Ocorrencia/

        public ActionResult Index()
        {
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
            ViewBag.IdTipoOcorrencia = new SelectList(gTipoOcorrencia.ObterTodos(), "IdTipoOcorrencia", "TipoOcorrencia");
            ViewBag.IdStatusOcorrencia = new SelectList(gStatusOcorrencia.ObterTodos(), "IdStatusOcorrencia", "StatusOcorrencia");
            return View();
        }

        //
        // POST: /Ocorrencia/Create

        [HttpPost]
        public ActionResult Create(OcorrenciaModel OcorrenciaModel)
        {
            if (ModelState.IsValid)
            {
                gOcorrencia.Inserir(OcorrenciaModel);
                return RedirectToAction("Index");
            }

            return View(OcorrenciaModel);
        }

        //
        // GET: /Ocorrencia/Edit/5

        public ActionResult Edit(int id)
        {

            OcorrenciaModel Ocorrencia = gOcorrencia.Obter(id);

            ViewBag.IdTipoOcorrencia = new SelectList(gTipoOcorrencia.ObterTodos(), "IdTipoOcorrencia", "TipoOcorrencia", Ocorrencia.IdTipoOcorrencia);
            ViewBag.IdStatusOcorrencia = new SelectList(gStatusOcorrencia.ObterTodos(), "IdStatusOcorrencia", "StatusOcorrencia");

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
        [HttpPost, ActionName("Delete")]
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

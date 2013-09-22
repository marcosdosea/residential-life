using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Models;
using Services;
using Microsoft.Reporting.WebForms;

namespace BibliotecaWeb.Controllers
{
    public class PostagemController : Controller
    {

         private GerenciadorPostagem gPostagem;
     
        public PostagemController()
        {
            gPostagem = new GerenciadorPostagem();
        }

        //
        // GET: /Postagem/

        public ActionResult Index()
        {
            return View(gPostagem.ObterTodos());
        }

        //
        // GET: /Postagem/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Postagem/Create
        [HttpPost]
        public ActionResult Create(PostagemModel postagemModel)
        {
            if (ModelState.IsValid)
            {
                gPostagem.Inserir(postagemModel);
                return RedirectToAction("Index");
            }

            return View(gPostagem);
        }

        //
        // GET: /pessoa/Details/5
        public ViewResult Details(int id)
        {
            PostagemModel postagem = gPostagem.Obter(id);
            return View(postagem);
        }

        //
        // GET: /Postagem/Edit/5
        public ActionResult Edit(int id)
        {
            PostagemModel postagem = gPostagem.Obter(id);
            return View(postagem);
        }

        //
        // POST: /Postagem/Edit/5
        [HttpPost]
        public ActionResult Edit(PostagemModel postagemModel)
        {
            if (ModelState.IsValid)
            {
                gPostagem.Editar(postagemModel);
                return RedirectToAction("Index");
            }
            return View(postagemModel);
        }

        //
        // GET: /Postagem/Delete/5
        public ActionResult Delete(int id)
        {
            PostagemModel postagemModel = gPostagem.Obter(id);
            return View(postagemModel);
        }

        //
        // POST: /Postagem/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gPostagem.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public ActionResult RelatorioPostagemPorData()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Relatorios/ReportListaPostagemPorData.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetPostagemPorData", gPostagem.ObterTodos()));

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

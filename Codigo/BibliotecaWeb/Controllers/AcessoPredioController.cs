using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models.Models;
using Models;
using Microsoft.Reporting.WebForms;

namespace BibliotecaWeb.Controllers
{
    public class AcessoPredioController : Controller
    {
        private GerenciadorAcessoPredio gAcessoPredio;
        private GerenciadorPessoa gPessoa;
        private GerenciadorPessoaMoradia gPessoaMoradia;

        public AcessoPredioController()
        {
            gAcessoPredio = new GerenciadorAcessoPredio();
            gPessoa = new GerenciadorPessoa();
            gPessoaMoradia = new GerenciadorPessoaMoradia();
        }



        //
        // GET: /AcessoPredio/

        public ActionResult Index()
        {
            return View(gAcessoPredio.ObterTodos());
        }


        //
        // GET: /Postagem/Create
        public ActionResult Create()
        {
            ViewBag.HoraAtual = DateTime.Now;
            SessionController.AlertBox = 0;
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodosPorCPF(), "IdPessoa", "CPF");
            return View();
        }

        //
        // POST: /Postagem/Create
        [HttpPost]
        public ActionResult Create(AcessoPredioModel acessoPredioModel)
        {
            acessoPredioModel.Data = DateTime.Now;
            PessoaMoradiaModel pessoaMoradia = gPessoaMoradia.ObterPessoaMoradia(acessoPredioModel.IdPessoa);
            if (pessoaMoradia == null)
            {
                SessionController.AlertBox = 1;
                ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodosPorCPF(), "IdPessoa", "CPF", acessoPredioModel.IdPessoa);
                return View(acessoPredioModel);
            }
            acessoPredioModel.IdCondominio = pessoaMoradia.IdCondominio;
            if (ModelState.IsValid)
            {
                if (gPessoa.existePessoa(acessoPredioModel.IdPessoa))
                {
                    gAcessoPredio.Inserir(acessoPredioModel);
                    return RedirectToAction("Index");
                }
                else
                    SessionController.AlertBox = 2;
                
            }

            return View(acessoPredioModel);
        }


        public ActionResult ReportAcessoPredio()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Relatorios/ReportAcessoPessoa.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetAcessoPessoa", gAcessoPredio.ObterTodos()));

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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Services;
using Microsoft.Reporting.WebForms;
using System.Web.Security;

namespace BibliotecaWeb.Controllers
{ 
    public class PessoaController : Controller
    {
        private GerenciadorPessoa gPessoa;
     
        public PessoaController()
        {
            gPessoa = new GerenciadorPessoa();
        }
        //
        // GET: /pessoa/

        public ViewResult Index()
        {
            return View(gPessoa.ObterTodos());
        }

        //
        // GET: /pessoa/Details/5

        public ViewResult Details(int id)
        {
            PessoaModel pessoa = gPessoa.Obter(id);
            return View(pessoa);
        }

        //
        // GET: /pessoa/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /pessoa/Create

        [HttpPost]
        public ActionResult Create(PessoaModel pessoaModel)
        {
            if (ModelState.IsValid)
            {
                gPessoa.Inserir(pessoaModel);
                return RedirectToAction("Index");  
            }
            return View(pessoaModel);
        }
        
        //
        // GET: /pessoa/Edit/5
 
        public ActionResult Edit(int id)
        {
            PessoaModel pessoa = gPessoa.Obter(id);
            return View(pessoa);
        }

        //
        // POST: /pessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(PessoaModel pessoaModel)
        {
            if (ModelState.IsValid)
            {
                gPessoa.Editar(pessoaModel);
                return RedirectToAction("Index");
            }
            return View(pessoaModel);
        }

        //
        // GET: /pessoa/Delete/5
 
        public ActionResult Delete(int id)
        {
            PessoaModel pessoaModel = gPessoa.Obter(id);
            return View(pessoaModel);
        }

        //
        // POST: /pessoa/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gPessoa.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public ActionResult RelatorioPessoasPorEstado()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Relatorios/RepostListaPessoasPorEstado.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetPessoasPorEstado", gPessoa.ObterTodos()));

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


        public ActionResult RelatorioPessoa()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Relatorios/ReportListaPessoas.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetPessoa", gPessoa.ObterTodos()));

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


        #region Status Codes
        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
            // a full list of status codes.
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "User name already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
        #endregion
    }
}
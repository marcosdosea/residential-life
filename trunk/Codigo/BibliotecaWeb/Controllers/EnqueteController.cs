using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models.Models;
using System.Web.Security;
using Microsoft.Reporting.WebForms;

namespace BibliotecaWeb.Controllers
{
    public class EnqueteController : Controller
    {
        //
        // GET: /Enquete/

        private GerenciadorEnquete gEnquete;
        private GerenciadorPessoa gPessoa;
        private GerenciadorStatusEnquete gStatusEnquete;
        private GerenciadorOpcaoEnquete gOpcao;
        private GerenciadorVotoEnquete gVoto;

        public EnqueteController()
        {
            gEnquete = new GerenciadorEnquete();
            gStatusEnquete = new GerenciadorStatusEnquete();
            gPessoa = new GerenciadorPessoa();
            gOpcao = new GerenciadorOpcaoEnquete();
            gVoto = new GerenciadorVotoEnquete();
        }

        [Authorize(Roles = "Síndico")]
        public ViewResult Index()
        {
            return View(gEnquete.ObterTodos());
        }
        [Authorize(Roles = "Síndico")]
        public ViewResult EmAndamento()
        {
            return View(gEnquete.ObterEnquetesAtivas());
        }
        [Authorize(Roles = "Síndico")]
        public ViewResult Finalizadas()
        {
            return View(gEnquete.ObterEnquetesFinalizadas());
        }
        //
        // GET: /enquete/Details/5
        [Authorize(Roles = "Síndico")]
        public ViewResult Details(int id)
        {
            EnqueteModel enquete = gEnquete.Obter(id);
            return View(enquete);
        }

        //
        // GET: /enquete/Create
        [Authorize(Roles = "Síndico")]
        public ActionResult Create()
        {

            //ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            ViewBag.IdStatusEnquete = new SelectList(gStatusEnquete.ObterTodos(), "IdStatusEnquete", "StatusEnquete");
            return View();
        }
        //
        // POST: /enquete/Create

        [HttpPost]
        public ActionResult Create(OpcoesEnqueteModel opcoesEnqueteModel)
        {
            opcoesEnqueteModel.Enquete.IdPessoa = gPessoa.ObterPorUsername(Membership.GetUser(true).UserName).IdPessoa;
            if (ModelState.IsValid)
            {
                int id_enquete = gEnquete.Inserir(opcoesEnqueteModel.Enquete);

                foreach (OpcaoModel opcao in opcoesEnqueteModel.Opcoes)
                {
                    gOpcao.Inserir(opcao, id_enquete);
                }
                return RedirectToAction("Index");
            }

            return View(opcoesEnqueteModel);
        }

        //
        // GET: /enquete/Votar
        [Authorize(Roles = "Morador")]
        public ActionResult Votar()
        {
            return View(gEnquete.ObterEnquetesAtivas());
        }
        [Authorize(Roles = "Morador")]
        public ActionResult VotarEnquete(int id)
        {
            ViewBag.Enquete = gEnquete.Obter(id);
            ViewBag.IdEnquete = id;
            ViewBag.IdOpcao = gOpcao.ObterOpcoesEnquete(id);
            ViewBag.MensagemVoto = "";
            return View();
        }

        [HttpPost]
        public ActionResult VotarEnquete(VotoEnqueteModel votoModel)
        {
            votoModel.IdPessoa = gPessoa.ObterPorUsername(Membership.GetUser(true).UserName).IdPessoa;
            votoModel.DataVoto = DateTime.Now;
            ViewBag.MensagemVoto = "";
            if (ModelState.IsValid)
            {
                if (!gVoto.UsuarioVotouEnquete(votoModel.IdEnquete, votoModel.IdPessoa))
                {
                    gVoto.Inserir(votoModel);
                    return RedirectToAction("Index");
                }
                else
                    ViewBag.MensagemVoto = "Usuário já votou nessa enquete!";
                
            }
            ViewBag.Enquete = gEnquete.Obter(votoModel.IdEnquete);
            ViewBag.IdEnquete = votoModel.IdEnquete;
            ViewBag.IdOpcao = gOpcao.ObterOpcoesEnquete(votoModel.IdEnquete);
            return View();
        }
       

      

        //
        // GET: /enquete/Delete/5
        [Authorize(Roles = "Síndico")]
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

        }
    }
}

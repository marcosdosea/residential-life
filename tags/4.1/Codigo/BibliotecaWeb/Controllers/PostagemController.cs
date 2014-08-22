using System;
using System.Web.Mvc;
using System.Web.Security;
using Microsoft.Reporting.WebForms;
using Models;
using Services;

namespace BibliotecaWeb
{
    public class PostagemController : Controller
    {
        private GerenciadorPostagem gPostagem;
        private GerenciadorPessoa gPessoa;

        public PostagemController()
        {
            gPostagem = new GerenciadorPostagem();
            gPessoa = new GerenciadorPessoa();
        }

        //
        // GET: /Postagem/

        public ActionResult Index()
        {
            ViewBag.IdPessoa = gPessoa.ObterPessoaLogada((int)Membership.GetUser(true).ProviderUserKey).IdPessoa;
            return View(gPostagem.ObterTodos());
        }


        public ActionResult MinhasPostagens()
        {
            int idPessoa = gPessoa.ObterPessoaLogada((int)Membership.GetUser(true).ProviderUserKey).IdPessoa;
            ViewBag.IdPessoa = idPessoa;
            return View("Index", gPostagem.ObterTodosPorPessoa(idPessoa));
        }
        
        //
        // GET: /Postagem/Create
        //[Authorize(Roles = "Morador")]     
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Postagem/Create
        [HttpPost]
        public ActionResult Create(PostagemModel postagemModel)
        {
            postagemModel.IdPessoa = gPessoa.ObterPessoaLogada((int)Membership.GetUser(true).ProviderUserKey).IdPessoa;
            postagemModel.DataPublicacao = DateTime.Now;
            if (ModelState.IsValid)
            {
                gPostagem.Inserir(postagemModel);
                return RedirectToAction("Index");
            }
            return View(gPostagem);
        }

        //
        // GET: /pessoa/Details/5
        //[Authorize(Roles = "Morador")]
        //[Authorize(Roles = "Síndico")]
        public ViewResult Details(int id)
        {
            PostagemModel postagem = gPostagem.Obter(id);
            return View(postagem);
        }

        //
        // GET: /Postagem/Edit/5
        //[Authorize(Roles = "Morador")]
        //[Authorize(Roles = "Síndico")]
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
        //[Authorize(Roles = "Morador")]
        //[Authorize(Roles = "Síndico")]
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

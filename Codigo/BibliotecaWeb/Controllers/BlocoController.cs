using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using Models;
using Services;
using System.Collections;
using System.Collections.Generic;

namespace BibliotecaWeb
{
    public class BlocoController : Controller
    {
        private GerenciadorBloco gBloco;
        private GerenciadorCondominio gCondominio;

        public BlocoController()
        {
            gBloco = new GerenciadorBloco();
            gCondominio = new GerenciadorCondominio();
        }
        //
        // GET: /bloco/

        public ViewResult Index()
        {
            IEnumerable<BlocoModel> blocos;
            if (SessionController.IdRolePessoa.Equals(Global.IdPerfilSindico))
            {
                blocos = gBloco.ObterPorCondominio(SessionController.PessoaMoradia.IdCondominio);
            }
            else
            {
                blocos = gBloco.ObterTodos();
            }
            return View(blocos);
        }

        //
        // GET: /bloco/Details/5

        public ViewResult Details(int id)
        {
            BlocoModel bloco = gBloco.Obter(id);
            return View(bloco);
        }

        //
        // GET: /bloco/Create

        public ActionResult Create()
        {
            int idCondominio = 0;
            if (SessionController.IdRolePessoa.Equals(Global.IdPerfilSindico)) 
            {
                idCondominio = SessionController.PessoaMoradia.IdCondominio;
            }
            ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", idCondominio);
            return View();
        }

        //
        // POST: /bloco/Create

        [HttpPost]
        public ActionResult Create(BlocoModel blocoModel)
        {
            if (ModelState.IsValid)
            {
                gBloco.Inserir(blocoModel);
                return RedirectToAction("Index");
            }
            ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", blocoModel.IdCondominio);
            return View(blocoModel);
        }

        //
        // GET: /bloco/Edit/5

        public ActionResult Edit(int id)
        {
            BlocoModel bloco = gBloco.Obter(id);
            return View(bloco);
        }

        //
        // POST: /bloco/Edit/5

        [HttpPost]
        public ActionResult Edit(BlocoModel blocoModel)
        {
            if (ModelState.IsValid)
            {
                gBloco.Editar(blocoModel);
                return RedirectToAction("Index");
            }
            ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", blocoModel.IdCondominio);
            return View(blocoModel);
        }

        //
        // GET: /bloco/Delete/5

        public ActionResult Delete(int id)
        {
            BlocoModel blocoModel = gBloco.Obter(id);
            return View(blocoModel);
        }

        //
        // POST: /bloco/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gBloco.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public ActionResult RelatorioBloco()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Relatorios/ReportListaBlocos.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetBlocos", gBloco.ObterTodos()));

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

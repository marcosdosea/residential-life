using System.Web.Mvc;
using Microsoft.Reporting.WebForms;
using Models;
using Services;

namespace BibliotecaWeb
{ 
    public class PessoaMoradiaController : Controller
    {
        private GerenciadorMoradia gMoradia;
        private GerenciadorPessoa gPessoa;
        private GerenciadorPessoaMoradia gPessoaMoradia;
        private GerenciadorCondominio gCondominio;
        private GerenciadorBloco gBloco;

        public PessoaMoradiaController()
        {
            gMoradia = new GerenciadorMoradia();
            gPessoa = new GerenciadorPessoa();
            gBloco = new GerenciadorBloco();
            gCondominio = new GerenciadorCondominio();
            gPessoaMoradia = new GerenciadorPessoaMoradia();
        }

        //
        // GET: /Moradia/

        public ActionResult Index()
        {
            return View(gPessoaMoradia.ObterTodos());
        }

        //[Authorize(Roles = "Síndico")]
        public ActionResult Create()
        {
            //Pegar somente as áreas públicas do condomínio corrente no futuro
            ViewBag.IdCondominio = new SelectList(GerenciadorCondominio.GetInstance().ObterTodos(), "IdCondominio", "Nome");
            ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(0), "IdBloco", "Nome");
            ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(0), "IdMoradia", "Numero");
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome");
            return View();
        }

        //
        // POST: /Moradia/Create

        [HttpPost]
        public ActionResult Create(PessoaMoradiaModel alocarPessoaMoradiaModel)
        {
            if (alocarPessoaMoradiaModel.IdMoradia != 0 && alocarPessoaMoradiaModel.IdPessoa != 0)
            {
                alocarPessoaMoradiaModel.IdPessoa = Global.IdPerfilMorador;
                if (ModelState.IsValid)
                {
                    gPessoaMoradia.Inserir(alocarPessoaMoradiaModel);
                    return RedirectToAction("Index");
                }
            }
            else
            {
                if (alocarPessoaMoradiaModel.IdBloco == 0)
                {
                    ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", alocarPessoaMoradiaModel.IdCondominio);
                    ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(alocarPessoaMoradiaModel.IdCondominio), "IdBloco", "Nome");
                    ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(0), "IdMoradia", "Numero");
                    ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", alocarPessoaMoradiaModel.IdPessoa);
                }
                else if (alocarPessoaMoradiaModel.IdMoradia == 0 && alocarPessoaMoradiaModel.IdBloco != 0)
                {
                    ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", alocarPessoaMoradiaModel.IdCondominio);
                    ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(alocarPessoaMoradiaModel.IdCondominio), "IdBloco", "Nome", alocarPessoaMoradiaModel.IdBloco);
                    ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(alocarPessoaMoradiaModel.IdBloco), "IdMoradia", "Numero");
                    ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", alocarPessoaMoradiaModel.IdPessoa);
                }
                else if (alocarPessoaMoradiaModel.IdMoradia != 0 &&  alocarPessoaMoradiaModel.IdBloco != 0)
                {
                    ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", alocarPessoaMoradiaModel.IdCondominio);
                    ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(alocarPessoaMoradiaModel.IdCondominio), "IdBloco", "Nome", alocarPessoaMoradiaModel.IdBloco);
                    ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(alocarPessoaMoradiaModel.IdBloco), "IdMoradia", "Numero", alocarPessoaMoradiaModel.NumeroMoradia);
                    alocarPessoaMoradiaModel.NumeroMoradia = gMoradia.Obter(alocarPessoaMoradiaModel.IdMoradia).Numero;
                    ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", alocarPessoaMoradiaModel.IdPessoa);
                }
            }
            return View(alocarPessoaMoradiaModel);
        }


        public ActionResult Edit(int idPessoa, int idMoradia, int idPerfil)
        {
            PessoaMoradiaModel alocarPessoaMoradiaModel = gPessoaMoradia.Obter(idPessoa, idMoradia, idPerfil);
            ViewBag.IdCondominio = new SelectList(gCondominio.ObterTodos(), "IdCondominio", "Nome", alocarPessoaMoradiaModel.IdCondominio);
            ViewBag.IdBloco = new SelectList(gBloco.ObterPorCondominio(alocarPessoaMoradiaModel.IdCondominio), "IdBloco", "Nome", alocarPessoaMoradiaModel.IdBloco);
            ViewBag.IdMoradia = new SelectList(gMoradia.ObterTodosPorBloco(alocarPessoaMoradiaModel.IdBloco), "IdMoradia", "Numero", alocarPessoaMoradiaModel.NumeroMoradia);
            alocarPessoaMoradiaModel.NumeroMoradia = gMoradia.Obter(alocarPessoaMoradiaModel.IdMoradia).Numero;
            ViewBag.IdPessoa = new SelectList(gPessoa.ObterTodos(), "IdPessoa", "Nome", alocarPessoaMoradiaModel.IdPessoa);
            return View(alocarPessoaMoradiaModel);
        }

        [HttpPost]
        public ActionResult Edit(PessoaMoradiaModel alocarPessoaMoradiaModel)
        {
            if (ModelState.IsValid)
            {
                gPessoaMoradia.Editar(alocarPessoaMoradiaModel);
                return RedirectToAction("Index");
            }
            return View(alocarPessoaMoradiaModel);
        }

        //
        // GET: /pessoa/Delete/5
       // [Authorize(Roles = "Síndico")]
        public ActionResult Delete(int idPessoa, int idMoradia, int idPerfil)
        {
            PessoaMoradiaModel alocarPessoaMoradiaModel = gPessoaMoradia.Obter(idPessoa, idMoradia, idPerfil);
            return View(alocarPessoaMoradiaModel);
        }

        //
        // POST: /pessoa/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int idPessoa, int idMoradia, int idPerfil)
        {
            gPessoaMoradia.Remover(idPessoa, idMoradia, idPerfil);
            return RedirectToAction("Index");
        } 


        public ActionResult ReportPessoaMoradia()
        {
            LocalReport relatorio = new LocalReport();

            //Caminho onde o arquivo do Report Viewer está localizado
            relatorio.ReportPath = Server.MapPath("~/Relatorios/ReportPessoaMoradia.rdlc");
            //Define o nome do nosso DataSource e qual rotina irá preenche-lo, no caso, nosso método criado anteriormente
            relatorio.DataSources.Add(new ReportDataSource("DataSetPessoaMoradia", gPessoaMoradia.ObterTodos()));

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
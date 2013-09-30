using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;
using Models.Models;
using System.Web.Security;

namespace BibliotecaWeb.Controllers
{
    public class AdministradoraController : Controller
    {
        //
        // GET: /Administradora/

        private GerenciadorAdministradora gAdministradora;
        
        public AdministradoraController()
        {
            gAdministradora = new GerenciadorAdministradora();
        }

        
        //
        // GET: /Administradora/

        public ActionResult Index()
        {
            return View(gAdministradora.ObterTodos());
        }

        //
        // GET: /Administradora/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Administradora/Create
        [HttpPost]
        public ActionResult Create(AdministradoraModel administradoraModel)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                MembershipCreateStatus createStatus;
                Membership.CreateUser(administradoraModel.Login, administradoraModel.Senha, administradoraModel.Email, "-", "-", true, out createStatus);

                if (createStatus == MembershipCreateStatus.Success)
                {
                    FormsAuthentication.SetAuthCookie(administradoraModel.Login, false /* createPersistentCookie */);
                }
                else
                {
                    ModelState.AddModelError("", ErrorCodeToString(createStatus));
                }
                Roles.AddUserToRole(administradoraModel.Login, "Administradora");

                gAdministradora.Inserir(administradoraModel);
                return RedirectToAction("Index");
            }

            return View(administradoraModel);
        }

        //
        // GET: /pessoa/Details/5
        public ViewResult Details(int id)
        {
            AdministradoraModel veiculo = gAdministradora.Obter(id);
            return View(veiculo);
        }

        //
        // GET: /Administradora/Edit/5
        public ActionResult Edit(int id)
        {
            AdministradoraModel veiculo = gAdministradora.Obter(id);
            return View(veiculo);
        }

        //
        // POST: /Administradora/Edit/5
        [HttpPost]
        public ActionResult Edit(AdministradoraModel administradoraModel)
        {
            if (ModelState.IsValid)
            {
                gAdministradora.Editar(administradoraModel);
                return RedirectToAction("Index");
            }
            return View(administradoraModel);
        }

        //
        // GET: /Administradora/Delete/5
        public ActionResult Delete(int id)
        {
            AdministradoraModel administradoraModel = gAdministradora.Obter(id);
            return View(administradoraModel);
        }

        //
        // POST: /Administradora/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gAdministradora.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
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

using System.Web;
using Models;

namespace BibliotecaWeb
{
    public class SessionController
    {
        public static PessoaModel Pessoa
        {
            get
            {
                return (PessoaModel)HttpContext.Current.Session["_Pessoa"];
            }
            set
            {
                HttpContext.Current.Session["_Pessoa"] = value;
            }
        }

        public static PessoaMoradiaModel PessoaMoradia
        {
            get
            {
                return (PessoaMoradiaModel)HttpContext.Current.Session["_PessoaMoradia"];
            }
            set
            {
                HttpContext.Current.Session["_PessoaMoradia"] = value;
            }
        }

        public static int IdRolePessoa
        {
            get
            {
                return (int)HttpContext.Current.Session["_IdRole"];
            }
            set
            {
                HttpContext.Current.Session["_IdRole"] = value;
            }
        }

        public static int AlertBox
        {
            get
            {
                return (int)HttpContext.Current.Session["_AlertBox"];
            }
            set
            {
                HttpContext.Current.Session["_AlertBox"] = value;
            }
        }
    }
}

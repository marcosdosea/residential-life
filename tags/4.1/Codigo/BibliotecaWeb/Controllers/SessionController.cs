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

        public static string Perfil
        {
            get
            {
                return (string)HttpContext.Current.Session["_Perfil"];
            }
            set
            {
                HttpContext.Current.Session["_Perfil"] = value;
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

        public static int IdVisitante
        {
            get
            {
                return (int)HttpContext.Current.Session["_IdVisitante"];
            }
            set
            {
                HttpContext.Current.Session["_IdVisitante"] = value;
            }
        }

        public static int IdProfissional
        {
            get
            {
                return (int)HttpContext.Current.Session["_IdProfissional"];
            }
            set
            {
                HttpContext.Current.Session["_IdProfissional"] = value;
            }
        }

        public static int IdFuncionario
        {
            get
            {
                return (int)HttpContext.Current.Session["_IdFuncionario"];
            }
            set
            {
                HttpContext.Current.Session["_IdFuncionario"] = value;
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

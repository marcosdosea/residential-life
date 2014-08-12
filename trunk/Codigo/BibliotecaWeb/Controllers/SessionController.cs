using System.Web;
using Models;

namespace BibliotecaWeb
{
    public class SessionController
    {
        public static string Teste
        {
            get
            {
                return (string)HttpContext.Current.Session["_Teste"];
            }
            set
            {
                HttpContext.Current.Session["_Teste"] = value;
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
    }
}

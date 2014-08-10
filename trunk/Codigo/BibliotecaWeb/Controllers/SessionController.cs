using System.Web;

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
    }
}

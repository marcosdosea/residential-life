using System.Web;

namespace BibliotecaWeb
{
    public class SessionController
    {
        public static int Teste
        {
            get
            {
                return (int)HttpContext.Current.Session["_Teste"];
            }
            set
            {
                HttpContext.Current.Session["_Teste"] = value;
            }
        }
    }
}

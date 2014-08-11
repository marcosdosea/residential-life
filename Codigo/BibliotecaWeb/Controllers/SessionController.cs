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

        public static int PessoaLogada
        {
            get
            {
                return (int)HttpContext.Current.Session["_PessoaLogada"];
            }
            set
            {
                HttpContext.Current.Session["_PessoaLogada"] = value;
            }
        }
    }
}

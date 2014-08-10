using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class PontuacaoModel
    {
        public enum ListaPontuacao
        {
            Zero = 0, Um = 1, Dois = 2, Tres = 3, Quatro = 4, Cinco = 5, Seis = 6,
            Sete = 7, Oito = 8, Nove = 9, Dez = 10
        }

        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public int IdPontuacao { get; set; }

        [Display(Name = "pontuacao", ResourceType = typeof(Mensagem))]
        public ListaPontuacao Pontuacao { get; set; }
    }
}

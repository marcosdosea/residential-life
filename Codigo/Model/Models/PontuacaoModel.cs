using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class PontuacaoModel
    {
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public int IdPontuacao { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "pontuacao", ResourceType = typeof(Mensagem))]
        public int Pontuacao { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class MoradiaModel
    {
        public enum ListaTipoMoradia { Cobertura = 0, Padrao = 1, Duplex = 2, Triplex = 3, Casa = 4 }

        [Display(Name = "condominio", ResourceType = typeof(Mensagem))]
        public int IdCondominio { get; set; }

        public string Condominio { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public int IdMoradia { get; set; }

        [Display(Name = "bloco", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public int IdBloco { get; set; }

        public string NomeBloco { get; set; }

        [Display(Name = "andar", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public string Andar { get; set; }

        [Display(Name = "numero", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public string Numero { get; set; }

        [Display(Name = "tipoMoradia", ResourceType = typeof(Mensagem))]
        public ListaTipoMoradia TipoMoradia { get; set; }

    }
}

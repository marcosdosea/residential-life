using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class SetorModel
    {
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public int IdSetor { get; set; }

        [Display(Name = "nome", ResourceType = typeof(Mensagem))]
        [StringLength(45)]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public string Nome { get; set; }

        [Display(Name = "descricao", ResourceType = typeof(Mensagem))]
        [StringLength(45)]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public string Descricao { get; set; }
    }
}

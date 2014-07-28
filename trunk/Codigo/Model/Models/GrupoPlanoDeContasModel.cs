using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class GrupoPlanoDeContasModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdTipoPlanoDeConta { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdPlanoDeConta { get; set; }

        [Display(Name = "descricaoPlanoDeConta", ResourceType = typeof(Mensagem))]
        [StringLength(500)]
        public string DescricaoPlanoDeConta { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "tipoPlanoDeConta", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string TipoPlanoDeConta { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "descricao", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string Descricao { get; set; }

    }
}

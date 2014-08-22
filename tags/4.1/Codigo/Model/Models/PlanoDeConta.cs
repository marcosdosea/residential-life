using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class PlanoDeContaModel
    {
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public int IdPlanoDeConta { get; set; }

        [Display(Name = "descricao", ResourceType = typeof(Mensagem))]
        [StringLength(500)]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public string Descricao { get; set; }

        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdGrupoPlanoDeConta { get; set; }

        [Display(Name = "descricaoGrupoPlanoContas", ResourceType = typeof(Mensagem))]
        public string DescricaoGrupoPlanoContas { get; set; }
    }
}

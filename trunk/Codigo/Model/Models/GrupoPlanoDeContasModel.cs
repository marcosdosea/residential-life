using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public enum ListaTipoPlanoConta { Receita = 0, Despesa = 1 }

    public class GrupoPlanoDeContasModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdGrupoPlanoDeConta { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "tipoPlanoDeConta", ResourceType = typeof(Mensagem))]
        public ListaTipoPlanoConta TipoPlanoDeConta { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "descricaoGrupoPlanoContas", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Descricao { get; set; }

    }
}

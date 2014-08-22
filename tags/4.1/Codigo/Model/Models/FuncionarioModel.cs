using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class FuncionarioModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdFuncionario { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdSetor { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdPessoa { get; set; }

        [Display(Name = "nomeSetor", ResourceType = typeof(Mensagem))]
        [StringLength(45)]
        public string NomeSetor { get; set; }

        [Display(Name = "nomePessoa", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string NomePessoa { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "ocupacao", ResourceType = typeof(Mensagem))]
        [StringLength(45)]
        public string Ocupacao { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "frequencia", ResourceType = typeof(Mensagem))]
        [StringLength(45)]
        public string Frequencia { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "horarioPermitido", ResourceType = typeof(Mensagem))]
        [StringLength(45)]
        public string HorarioPermitido { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "pontuacao", ResourceType = typeof(Mensagem))]
        public decimal Pontuacao { get; set; }

    }
}

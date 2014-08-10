using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class PerfilPessoaModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdPessoa { get; set; }

        [Display(Name = "nomePessoa", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string NomePessoa { get; set; }
        
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdPerfil { get; set; }

        [Display(Name = "perfil", ResourceType = typeof(Mensagem))]
        [StringLength(255)]
        public string Perfil { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "ativo", ResourceType = typeof(Mensagem))]
        public bool Ativo { get; set; }

        [Display(Name = "cpf", ResourceType = typeof(Mensagem))]
        [StringLength(11)]
        public string CPF { get; set; }

        [Display(Name = "rg", ResourceType = typeof(Mensagem))]
        [StringLength(15)]
        public string RG { get; set; }
    }
}

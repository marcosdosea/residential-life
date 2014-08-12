using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class PessoaMoradiaModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "moradia", ResourceType = typeof(Mensagem))]
        public int IdMoradia { get; set; }

        [Display(Name = "numero", ResourceType = typeof(Mensagem))]
        public string NumeroMoradia { get; set; }

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

        public int IdCondominio { get; set; }

        [Display(Name = "condominio", ResourceType = typeof(Mensagem))]
        public string Condominio { get; set; }

        public int IdBloco { get; set; }

        [Display(Name = "bloco", ResourceType = typeof(Mensagem))]
        public string Bloco { get; set; }
    }
}

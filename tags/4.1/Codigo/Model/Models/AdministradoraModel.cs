using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class AdministradoraModel
    {
        public int IdAdministradora { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "nome", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "senha", ResourceType = typeof(Mensagem))]
        [StringLength(16)]
        public string Senha { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "login", ResourceType = typeof(Mensagem))]
        [StringLength(16)]
        public string Login { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "email", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string Email { get; set; }
    }
}

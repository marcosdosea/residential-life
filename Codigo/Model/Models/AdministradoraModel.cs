using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class AdministradoraModel
    {
        public int IdAdministradora { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "nome", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }
    }
}

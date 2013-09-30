using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class MoradiaModel
    {

        public int IdMoradia { get; set; }
               

        [Display(Name = "bloco", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public int IdBloco { get; set; }

        public int IdPessoa { get; set; }

        [Display(Name = "predio", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
           ErrorMessageResourceName = "required")]
        public string Predio { get; set; }


        [Display(Name = "andar", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
           ErrorMessageResourceName = "required")]
        public string Andar { get; set; }

        [Display(Name = "numero", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
           ErrorMessageResourceName = "required")]
        public string Numero { get; set; }       
        
        [Display(Name = "idTipoMoradia", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public int IdTipoMoradia { get; set; }


        [Display(Name = "tipoMoradia", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string TipoMoradia { get; set; }

    }
}

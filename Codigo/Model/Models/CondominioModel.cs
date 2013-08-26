using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class CondominioModel
    {
        public int IdCondominio { get; set;}
        public int IdSindico { get; set; } 
        public string NomeSindico {get; set;}

        [Required]
        [Display(Name = "nome", ResourceType=typeof(Mensagem))]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "rua", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Rua { get; set; }

        [Required]
        [Display(Name = "numero", ResourceType = typeof(Mensagem))]
        [StringLength(10)]
        public string Numero { get; set; }

        [Required]
        [Display(Name = "bairro", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string Bairro { get; set; }

        [Display(Name = "complemento", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Complemento { get; set; }

        [Required]
        [Display(Name = "cep", ResourceType = typeof(Mensagem))]
        [StringLength(8)]
        public string Cep { get; set; }

        [Required]
        [Display(Name = "cidade", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string Cidade { get; set; }

        [Required]
        [Display(Name = "estado", ResourceType = typeof(Mensagem))]
        [StringLength(2)]
        public String Estado { get; set; }
    }
}

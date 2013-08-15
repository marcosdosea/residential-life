using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class CondominioModel
    {
        public int idCondominio { get; set;}
        public int idSindico { get; set; } // depois mudar aqui, pois vai referenciar um Id de pessoa

        [Required]
        [Display(Name = "Nome")]
        [StringLength(100)]
        public string nome { get; set; }

        [Required]
        [Display(Name = "Rua")]
        [StringLength(100)]
        public string rua { get; set; }

        [Required]
        [Display(Name = "Número")]
        [StringLength(6)]
        public string numero { get; set; }

        [Required]
        [Display(Name = "Bairro")]
        [StringLength(30)]
        public string bairro { get; set; }

        [Display(Name = "Complemento")]
        [StringLength(100)]
        public string complemento { get; set; }

        [Required]
        [Display(Name = "CEP")]
        [StringLength(10)]
        public string cep { get; set; }

        [Required]
        [Display(Name = "Cidade")]
        [StringLength(30)]
        public string cidade { get; set; }

        [Required]
        [Display(Name = "Estado")]
        [StringLength(30)]
        public string estado { get; set; }
    }
}

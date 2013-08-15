using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class CondominioModel
    {
        public int IDCondominio { get; set;}
        public int IDSindico { get; set; } // depois mudar aqui, pois vai referenciar um Id de pessoa

        [Required]
        [Display(Name = "Nome")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Rua")]
        [StringLength(100)]
        public string Rua { get; set; }

        [Required]
        [Display(Name = "Número")]
        [StringLength(6)]
        public string Numero { get; set; }

        [Required]
        [Display(Name = "Bairro")]
        [StringLength(30)]
        public string Bairro { get; set; }

        [Display(Name = "Complemento")]
        [StringLength(100)]
        public string Complemento { get; set; }

        [Required]
        [Display(Name = "CEP")]
        [StringLength(10)]
        public string Cep { get; set; }

        [Required]
        [Display(Name = "Cidade")]
        [StringLength(30)]
        public string Cidade { get; set; }

        [Required]
        [Display(Name = "Estado")]
        [StringLength(30)]
        public string Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class BlocoModel
    {
        public int IdBloco { get; set; }
        public int IdCondominio { get; set; }
       
        [Required]
        [Display(Name = "Nome")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Quantidade de Andares")]
        [Range(1, 1000)]
        public int QuantidadeAndares { get; set; }

        [Required]
        [Display(Name = "Quantidade de Moradias")]
        [Range(1, 500)]
        public int QuantidadeMoradias { get; set; }


    }
}

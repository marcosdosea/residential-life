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
        public int QuantidadeAndares { get; set; }

        [Required]
        [Display(Name = "Quantidade de Moradias")]
        public int QuantidadeMoradias { get; set; }


    }
}

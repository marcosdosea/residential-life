using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class BlocoModel
    {
        public int idBloco { get; set; }
        public int idCondominio { get; set; }
       
        [Required]
        [Display(Name = "Nome")]
        [StringLength(100)]
        public string nome { get; set; }

        [Required]
        [Display(Name = "Quantidade de Andares")]
        public int quantAndares { get; set; }

        [Required]
        [Display(Name = "Quantidade de Moradias")]
        public int quantMoradias { get; set; }


    }
}

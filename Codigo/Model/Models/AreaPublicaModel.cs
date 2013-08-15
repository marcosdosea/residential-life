using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class AreaPublicaModel
    {
        public int idAreaPublica { get; set; }
        public int idCondominio { get; set; }
        public string Estado { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [StringLength(100)]
        public string nome { get; set; }

        [Required]
        [Display(Name = "Local")]
        public string local { get; set; }

        [Required]
        [Display(Name = "Tamanho")]
        public string tamanho { get; set; }

        [Required]
        [Display(Name = "Valor Pagamento")]
        public decimal valorPagamento { get; set; }

    }
}

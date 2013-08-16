using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class AreaPublicaModel
    {
        public int idAreaPublica { get; set; }
        public int idCondominio { get; set; }
       
        [Required]
        public string Estado { get; set; }
       
        [Display(Name = "nome", ResourceType= typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Local")]
        //[Required(ErrorMessageResourceType = typeof(Mensagem),
        //    ErrorMessageResourceName = "required")]
        [StringLength(50)]
        public string Local { get; set; }

        [Required]
        [Display(Name = "Tamanho")]
        //[Required(ErrorMessageResourceType = typeof(Mensagem),
        //    ErrorMessageResourceName = "required")]
        [StringLength(10)]
        public string Tamanho { get; set; }

        [Required]
        [Display(Name = "Valor Pagamento")]
        //[Required(ErrorMessageResourceType = typeof(Mensagem),
        //    ErrorMessageResourceName = "required")]
        //[StringLength(10)]
        public decimal ValorPagamento { get; set; }

    }
}

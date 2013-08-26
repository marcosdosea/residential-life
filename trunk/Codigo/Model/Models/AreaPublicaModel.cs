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
        public int IdAreaPublica { get; set; }


        [Display(Name = "condominio", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public int IdCondominio { get; set; }


         [Display(Name = "estado", ResourceType = typeof(Mensagem))]
         [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public int IdStatus{ get; set; }

         public string StatusAreaPublica { get; set; }

        [Display(Name = "nome", ResourceType= typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [StringLength(100)]
        public string Nome { get; set; }


        [Display(Name = "local", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]      
        [StringLength(50)]
        public string Local { get; set; }

   
        [Display(Name = "tamanho", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [StringLength(10)]
        public string Tamanho { get; set; }

      
        [Display(Name = "valorPagamento", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public decimal ValorReserva { get; set; }

    }
}

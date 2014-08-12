using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class AcessoPredioModel
    {
        public int IdAcesoPredio { get; set; }

        public string Pessoa { get; set; }

        public string CPF { get; set; }

        [Display(Name = "condominio", ResourceType = typeof(Mensagem))]
        public int IdCondominio { get; set; }

        [Display(Name = "pessoa", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public int IdPessoa { get; set; }

        [Display(Name = "data", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public DateTime Data { get; set; }

        [Display(Name = "tipo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public ListaTipoAcesso TipoAcesso { get; set; }
    }
}

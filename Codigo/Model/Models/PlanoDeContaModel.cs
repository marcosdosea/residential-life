using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class PlanoDeContaModel
    {
        public int IdPlanoDeConta { get; set; }

        [Display(Name = "descricao", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public string Descricao { get; set; }

        public int IdTipoPlanoDeConta { get; set; }

        public string TipoPlanoDeConta { get; set; } 
    }
}

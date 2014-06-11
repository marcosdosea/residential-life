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

        public int IdPessoa { get; set; }

        [Display(Name = "dataEntrada", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [StringLength(100)]
        public string DataEntrada { get; set; }

        [Display(Name = "dataSaida", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [StringLength(100)]
        public string DataSaida { get; set; }
    }
}

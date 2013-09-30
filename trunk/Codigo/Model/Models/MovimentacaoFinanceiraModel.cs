using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class MovimentacaoFinanceiraModel
    {
        public int IdMovimentacaoFinanceira { get; set; }

        public int IdAdministradora { get; set; }

        public string NomeAdministradora { get; set; }

        [Display(Name = "valorPagamento", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public decimal Valor { get; set; }

        [Display(Name = "data", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        [Display(Name = "competencia", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [StringLength(30)]
        public string Competencia { get; set; }

        [Display(Name = "descricao", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [StringLength(200)]
        public string Descricao { get; set; }

        public int IdStatusMovimentacaoFinanceira { get; set; }

        public string StatusMovimentacaoFinanceira { get; set; }

        public int IdPlanoDeConta { get; set; }

        public string PlanoDeConta { get; set; }
    }
}

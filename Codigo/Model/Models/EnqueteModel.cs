using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class EnqueteModel
    {
        public int IdEnquete { get; set; }

        [Required]
        [Display(Name = "pessoa", ResourceType = typeof(Mensagem))]
        public int IdPessoa { get; set; }

        [Required]
        [Display(Name = "titulo", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Required]
        [Display(Name = "descricao", ResourceType = typeof(Mensagem))]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "dataInicio", ResourceType = typeof(Mensagem))]
        public DateTime DataInicio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "dataFim", ResourceType = typeof(Mensagem))]
        public DateTime DataFim { get; set; }

        [Required]
        [Display(Name = "status", ResourceType = typeof(Mensagem))]
        public int IdStatusEnquete { get; set; }


        public string StatusEnquete { get; set; }
        public string NomeCriador { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class VeiculoModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public int IdPessoa { get; set; }

        public int IdVeiculo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "placa", ResourceType = typeof(Mensagem))]
        [StringLength(7)]
        public string Placa { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "modelo", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string Modelo { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "cor", ResourceType = typeof(Mensagem))]
        [StringLength(20)]
        public string Cor { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "tipoVeiculo", ResourceType = typeof(Mensagem))]
        [StringLength(45)]
        public string Tipo { get; set; }

        public int IdTipoVeiculo { get; set; }
    }
}

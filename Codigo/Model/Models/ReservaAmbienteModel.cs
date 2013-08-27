﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class ReservaAmbienteModel
    {
        public int IdReservaAmbiente { get; set; }


        [Display(Name = "idArea", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public int IdAreaPublica { get; set; }

        [Display(Name="areaPublica", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string NomeAreaPublica { get; set; }


        [Display(Name = "idPessoa", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public int IdPesssoa { get; set; }


        [Display(Name = "dataInicio", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        //[Range(typeof(DateTime), "1/1/1900", "31/12/2200")]
        public DateTime DataInicio { get; set; }


        [Display(Name = "dataFim", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        //[Range(typeof(DateTime), "1/1/1900", "31/12/2200")]
        public DateTime DataFim { get; set; }

        //[Display(Name = "idStatusPagamento", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public int IdStatusPagamento { get; set; }

        [Display(Name = "statusPagamento", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [StringLength(50)]
        public string StatusPagamento { get; set; }


    }
}

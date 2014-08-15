using System;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public enum ListaTipoAcesso { Entrada = 0, Saida = 1 }

    public class AcessoVeiculoModel
    {
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public int IdAcessoVeiculo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [DataType(DataType.Date)]
        [Display(Name = "data", ResourceType = typeof(Mensagem))]
        public DateTime Data { get; set; }

        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdVeiculo { get; set; }

        public string PlacaVeiculo { get; set; }

        [Display(Name = "acesso", ResourceType = typeof(Mensagem))]
        public ListaTipoAcesso TipoAcesso { get; set; }
    }
}

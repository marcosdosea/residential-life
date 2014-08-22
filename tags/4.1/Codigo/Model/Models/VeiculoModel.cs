using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public enum ListaTipoVeiculo { Carro = 0, Motocicleta = 1 }

    public class VeiculoModel
    {
        
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdPessoa { get; set; }

        [Display(Name = "nomePessoa", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string NomePessoa { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdVeiculo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "placa", ResourceType = typeof(Mensagem))]
        [StringLength(7)]
        public string Placa { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "modelo", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string Modelo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "cor", ResourceType = typeof(Mensagem))]
        [StringLength(20)]
        public string Cor { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "tipoVeiculo", ResourceType = typeof(Mensagem))]
        public ListaTipoVeiculo TipoVeiculo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdMoradia { get; set; }

        [Display(Name = "moradia", ResourceType = typeof(Mensagem))]
        public string Moradia { get; set; }

        public int IdCondominio { get; set; }

        [Display(Name = "condominio", ResourceType = typeof(Mensagem))]
        public string Condominio { get; set; }

        public int IdBloco { get; set; }

        [Display(Name = "bloco", ResourceType = typeof(Mensagem))]
        public string Bloco { get; set; }
    }
}

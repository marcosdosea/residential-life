using System;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class EnqueteModel
    {
        public enum ListaStatusEnquente { EmVotacao = 0, Pausada = 1, Finalizada = 2 }

        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public int IdEnquete { get; set; }

        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public int IdPessoa { get; set; }

        [Display(Name = "nomePessoa", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string NomePessoa { get; set; }

        [Display(Name = "titulo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Display(Name = "descricao", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Display(Name = "dataInicio", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [Display(Name = "dataFim", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [DataType(DataType.Date)]
        public DateTime DataFim { get; set; }

        [Display(Name = "statusEnquente", ResourceType = typeof(Mensagem))]
        public ListaStatusEnquente StatusEnquete { get; set; }
    }
}

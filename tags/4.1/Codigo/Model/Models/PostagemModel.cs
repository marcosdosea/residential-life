using System;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class PostagemModel
    {

        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public int IdPostagem { get; set; }

        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        public int IdPessoa { get; set; }

        [Display(Name = "nomePessoa", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string NomePessoa { get; set; }
        
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [StringLength(100)]
        [Display(Name = "titulo", ResourceType = typeof(Mensagem))]
        public string Titulo { get; set; }
        
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [StringLength(500)]
        [Display(Name = "descricao", ResourceType = typeof(Mensagem))]
        public string Descricao { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [DataType(DataType.Date)]
        [Display(Name = "dataPublicacao", ResourceType = typeof(Mensagem))]
        public DateTime DataPublicacao { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "dataExclusao", ResourceType = typeof(Mensagem))]
        public DateTime DataExclusao { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class PostagemModel
    {

        public int IdPostagem { get; set; }

        public int IdPessoa { get; set; }

        [Display(Name = "titulo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [StringLength(100)]
        public string titulo { get; set; }

        [Display(Name = "descricao", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [StringLength(1000)]
        public string descricao { get; set; }
               

        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [DataType(DataType.Date)]
        [Display(Name = "dataAutomatica", ResourceType = typeof(Mensagem))]
        public DateTime dataPublAutomatica { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [DataType(DataType.Date)]
        [Display(Name = "dataExclusao", ResourceType = typeof(Mensagem))]
        public DateTime dataExclusaoAutomatica { get; set; }


    }
}

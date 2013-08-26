using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class RegistrarOcorrenciaModel
    {

        public int IdOcorrencia { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem),
          ErrorMessageResourceName = "required")]
        public int IdPessoa { get; set; }

        [Display(Name = "titulo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Display(Name = "descricao", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [StringLength(50)]
        public string Descricao { get; set; }

        [Display(Name = "data", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        public int IdTipo { get; set; }

        [Display(Name = "tipo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        public string Tipo { get; set; }

        //[Display(Name = "status", ResourceType = typeof(Mensagem))]
        // [Required(ErrorMessageResourceType = typeof(Mensagem),
        //     ErrorMessageResourceName = "required")]
        public string Status { get; set; }
        public int IdStatus { get; set; }


    }
}

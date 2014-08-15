using System;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class OcorrenciaModel
    {
        public enum ListaTipoOcorrencia { Barulho = 0, Roubo = 1, DanoAoPatrimonio = 2, Outros = 3 }

        public enum ListaStatusOcorrencia { EmAnalise = 0, EmExecucao = 1, Rresolvida = 2, Finalizada = 3 }

        public int IdOcorrencia { get; set; }

        [Display(Name = "pessoa", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
          ErrorMessageResourceName = "required")]
        public int IdPessoa { get; set; }

        [Display(Name = "pessoa", ResourceType = typeof(Mensagem))]
        public string NomePessoa { get; set; }

        [Display(Name = "titulo", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [StringLength(50)]
        public string Titulo { get; set; }

        [Display(Name = "descricao", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Display(Name = "data", ResourceType = typeof(Mensagem))]
        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        [Display(Name = "status_ocorrencia", ResourceType = typeof(Mensagem))]
        public ListaStatusOcorrencia StatusOcorrencia { get; set; }

        [Display(Name = "tipo_ocorrencia", ResourceType = typeof(Mensagem))]
        public ListaTipoOcorrencia TipoOcorrencia { get; set; }

        [Display(Name = "outros_tipos_ocorrencia", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string OutrosTiposOcorrencia { get; set; }


    }
}

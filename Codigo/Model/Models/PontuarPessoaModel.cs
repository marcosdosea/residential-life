using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class PontuarPessoaModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdPessoa { get; set; }

        [Display(Name = "nomePessoa", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string NomePessoa { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdPontuacao { get; set; }

        [Display(Name = "pontuacao", ResourceType = typeof(Mensagem))]
        public int Pontuacao { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "comentario", ResourceType = typeof(Mensagem))]
        [StringLength(250)]
        public string Comentario { get; set; }
    }
}

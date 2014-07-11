using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class BlocoModel
    {
        [Display(Name = "id", ResourceType = typeof(Mensagem))]
        public int IdBloco { get; set; }

        [Display(Name = "idCondominio", ResourceType = typeof(Mensagem))]
        public int IdCondominio { get; set; }

        [Required]
        [Display(Name = "nome", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Nome { get; set; }

        public string NomeCondominio { get; set; }

        [Required]
        [Display(Name = "qtdeAndares", ResourceType = typeof(Mensagem))]
        [Range(1, 1000)]
        public int QuantidadeAndares { get; set; }

        [Required]
        [Display(Name = "qtdeMoradias", ResourceType = typeof(Mensagem))]
        [Range(1, 500)]
        public int QuantidadeMoradias { get; set; }


    }
}

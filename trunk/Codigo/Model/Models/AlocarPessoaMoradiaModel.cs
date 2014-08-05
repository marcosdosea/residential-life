using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models.Models
{
    public class AlocarPessoaMoradiaModel
    {
        public enum ListaTipoPessoaMoradia { Morador = 0, Visitante = 1 }

        [Required]
        [Display(Name = "nome_pessoa", ResourceType = typeof(Mensagem))]
        public int IdPessoa {get;set;}

        public string NomePessoa { get; set; }

        public int IdCondominio { get; set; }

        [Display(Name = "condominio", ResourceType = typeof(Mensagem))]
        public string Condominio { get; set; }

        public int IdBloco { get; set; }

        [Display(Name = "bloco", ResourceType = typeof(Mensagem))]
        public string Bloco { get; set; }

        [Required]
        [Display(Name = "moradia", ResourceType = typeof(Mensagem))]
        public int IdMoradia { get; set; }

        [Display(Name = "numero", ResourceType = typeof(Mensagem))]
        public string NumeroMoradia { get; set; }

        [Required]
        [Display(Name = "tipoMoradia", ResourceType = typeof(Mensagem))]
        public ListaTipoPessoaMoradia Tipo { get; set; }
    }
}

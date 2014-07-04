using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class AtendimentoModel
    {
        public enum ListaStatusAtendimento { Resolvido = 0, EmAnalise = 1 }

        [Display(Name = "id", ResourceType = typeof(Mensagem))]
        public int IdAtendimento { get; set; }

        [Display(Name = "id", ResourceType = typeof(Mensagem))]
        public int IdPessoa { get; set; }

        [Display(Name = "nome_pessoa", ResourceType = typeof(Mensagem))]
        public string NomePessoa { get; set; }

        [Display(Name = "titulo", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Display(Name = "descricao", ResourceType = typeof(Mensagem))]
        [StringLength(1000)]
        public string Descricao { get; set; }

        [Display(Name = "status_atentimento", ResourceType = typeof(Mensagem))]
        public ListaStatusAtendimento StatusAtendimento { get; set; }
    }
}

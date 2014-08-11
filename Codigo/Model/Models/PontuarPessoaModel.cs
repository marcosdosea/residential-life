using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public enum ListaPontuacao
    {
        Zero = 0, Um = 1, Dois = 2, Tres = 3, Quatro = 4, Cinco = 5, Seis = 6, Sete = 7,
        Oito = 8, Nove = 9, Dez = 10
    }
    public class PontuarPessoaModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdPontuacaoPessoa { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdPessoa { get; set; }

        [Display(Name = "nomePessoa", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string NomePessoa { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "comentario", ResourceType = typeof(Mensagem))]
        [StringLength(250)]
        public string Comentario { get; set; }

        [Display(Name = "pontuacao", ResourceType = typeof(Mensagem))]
        public ListaPontuacao Pontuacao { get; set; }
    }
}

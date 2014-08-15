using System;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    
    public enum ListaDia { Segunda = 0, Terca = 1, Quarta = 2, Quinta = 3, Sexta = 4, Sabado = 5, Domingo = 6 }
    public enum ListaHora { Zero = 0, Uma = 1, Duas = 2, Tres = 3, Quatro = 4, Cinco = 5, Seis = 6, Sete = 7, Oito = 8, 
        Nove = 9, Dez = 10, Onze = 11, Doze = 12, Treze = 13, Quatorze = 14, Quinze = 15, Dezesseis = 16, Dezessete = 17,
        Dezoito = 18, Dezenove = 19, Vinte = 20, VinteUm = 21, VinteDuas = 22, VinteTres = 23, VinteQuatro = 24 }

    public class RestricaoAcessoModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdRestricaoAcesso { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdPessoa { get; set; }

        [Display(Name = "nomePessoa", ResourceType = typeof(Mensagem))]
        public string NomePessoa { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdCondominio { get; set; }

        [Display(Name = "condominio", ResourceType = typeof(Mensagem))]
        public string Condominio { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "restrito", ResourceType = typeof(Mensagem))]
        public bool Restrito { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "dia", ResourceType = typeof(Mensagem))]
        public ListaDia Dia { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "horaEntrada", ResourceType = typeof(Mensagem))]
        public ListaHora HoraEntrada { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "horaSaida", ResourceType = typeof(Mensagem))]
        public ListaHora HoraSaida { get; set; }
    }
}

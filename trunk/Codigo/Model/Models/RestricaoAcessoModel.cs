using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    
    public enum ListaDia { Segunda = 0, Terca = 1, Quarta = 2, Quinta = 3, Sexta = 4, Sabado = 5, Domingo = 6 }
    public enum ListaHora
    {
        ZeroHora = 0, UmaHora = 1, DuasHora = 2, TresHora = 3, QuatroHora = 4, CincoHora = 5, SeisHora = 6, SeteHora = 7,
        OitoHora = 8, NoveHora = 9, DezHora = 10, OnzeHora = 11, DozeHora = 12, TrezeHora = 13, QuatorzeHora = 14, QuinzeHora = 15,
        DezesseisHora = 16, DezesseteHora = 17, DezoitoHora = 18, DezenoveHora = 19, VinteHora = 20, VinteUmHora = 21, VinteDuasHora = 22,
        VinteTresHora = 23, VinteQuatroHora = 24
    }

    public class RestricaoAcessoModel
    {
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

        [Display(Name = "dia", ResourceType = typeof(Mensagem))]
        public ListaDia Dia { get; set; }

        [Display(Name = "horaEntrada", ResourceType = typeof(Mensagem))]
        public ListaHora HoraEntrada { get; set; }

        [Display(Name = "horaSaida", ResourceType = typeof(Mensagem))]
        public ListaHora HoraSaida { get; set; }

        
        //////////////////////////////////////////////////////////
        

        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdMoradia { get; set; }

        [Display(Name = "ativo", ResourceType = typeof(Mensagem))]
        public bool Ativo { get; set; }
    }
}

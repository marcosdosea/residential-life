using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class OpcaoModel
    {
        public int IdEnquete { get; set; }
        public int IdOpcao { get; set; }

        [Required]
        [Display(Name = "descricao", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string Descricao { get; set; }
    }
}

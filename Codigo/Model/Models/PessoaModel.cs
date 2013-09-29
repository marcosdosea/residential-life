using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Models.App_GlobalResources;

namespace Models
{
    public class PessoaModel
    {
        [Display(Name = "id", ResourceType = typeof(Mensagem))]
        public int IdPessoa{ get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "nome", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Nome { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "cpf", ResourceType = typeof(Mensagem))]
        [StringLength(11)]
        public string CPF { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "rg", ResourceType = typeof(Mensagem))]
        [StringLength(15)]
        public string RG { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "sexo", ResourceType = typeof(Mensagem))]
        [StringLength(1)]
        public string Sexo { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "email", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string Email { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "login", ResourceType = typeof(Mensagem))]
        [StringLength(16)]
        public string Login { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [DataType(DataType.Password)]
        [Display(Name = "senha", ResourceType = typeof(Mensagem))]
        [StringLength(16)]
        public string Senha { get; set; }


        [Display(Name = "telefoneFixo", ResourceType = typeof(Mensagem))]
        [StringLength(12)]
        public string TelefoneFixo { get; set; }


        [Display(Name = "telefoneCelular", ResourceType = typeof(Mensagem))]
        [StringLength(12)]
        public string TelefoneCelular { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "rua", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Rua { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "numero", ResourceType = typeof(Mensagem))]
        [StringLength(10)]
        public string Numero { get; set; }


        [Display(Name = "complemento", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Complemento { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "bairro", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string Bairro { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "cep", ResourceType = typeof(Mensagem))]
        [StringLength(8)]
        public string CEP { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "cidade", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string Cidade { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagem),
            ErrorMessageResourceName = "required")]
        [Display(Name = "estado", ResourceType = typeof(Mensagem))]
        [StringLength(2)]
        public string Estado { get; set; }

        
    }
}

using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Models.App_GlobalResources;


namespace Models
{

    public class ChangePasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "senhaAtual", ResourceType = typeof(Mensagem))]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O {0} deve ter ao menos {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "novaSenha", ResourceType = typeof(Mensagem))]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "confirmaNovaSenha", ResourceType = typeof(Mensagem))]
        [Compare("NewPassword", ErrorMessage = "A senha e a confirmação de senha não combinam.")]
        public string ConfirmPassword { get; set; }
    }

    public class LogOnModel
    {
        [Required]
        [Display(Name = "login", ResourceType = typeof(Mensagem))]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "senha", ResourceType = typeof(Mensagem))]
        public string Password { get; set; }

        [Display(Name = "manterConectado", ResourceType = typeof(Mensagem))]
        public bool RememberMe { get; set; }
    }





    public class RegisterModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "campo_requerido")]
        [Display(Name = "nomeUsuario", ResourceType = typeof(Mensagem))]
        public string UserName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "campo_requerido")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "email_invalido")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "enderecoEmail", ResourceType = typeof(Mensagem))]
        public string Email { get; set; }

        [Display(Name = "confirmarEmail", ResourceType = typeof(Mensagem))]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "email_invalido")]
        [Compare("Email", ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "emailNaoCoincidem")]
        public string ConfirmaEmail { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "campo_requerido")]
        [StringLength(100, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "senhaCurta", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "senha", ResourceType = typeof(Mensagem))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "confirmeSenha", ResourceType = typeof(Mensagem))]
        [Compare("Password", ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "senhaConfSenhaNaoCoincidem")]
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// parte da pessoa
        /// </summary>

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdPessoa { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagem))]
        public int IdUser { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "nome", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "cpf", ResourceType = typeof(Mensagem))]
        [StringLength(11)]
        public string CPF { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "rg", ResourceType = typeof(Mensagem))]
        [StringLength(15)]
        public string RG { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "sexo", ResourceType = typeof(Mensagem))]
        [StringLength(1)]
        public string Sexo { get; set; }

        [Display(Name = "telefoneFixo", ResourceType = typeof(Mensagem))]
        [StringLength(12)]
        public string TelefoneFixo { get; set; }

        [Display(Name = "telefoneCelular", ResourceType = typeof(Mensagem))]
        [StringLength(12)]
        public string TelefoneCelular { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "rua", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Rua { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "numero", ResourceType = typeof(Mensagem))]
        [StringLength(10)]
        public string Numero { get; set; }

        [Display(Name = "complemento", ResourceType = typeof(Mensagem))]
        [StringLength(100)]
        public string Complemento { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "bairro", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string Bairro { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "cep", ResourceType = typeof(Mensagem))]
        [StringLength(8)]
        public string CEP { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "cidade", ResourceType = typeof(Mensagem))]
        [StringLength(50)]
        public string Cidade { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "required")]
        [Display(Name = "estado", ResourceType = typeof(Mensagem))]
        [StringLength(2)]
        public string Estado { get; set; }
    }
}

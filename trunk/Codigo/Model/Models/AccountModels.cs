using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
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
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "nome", ResourceType = typeof(Mensagem))]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O {0} deve ter ao menos {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "senha", ResourceType = typeof(Mensagem))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "confirmaSenha", ResourceType = typeof(Mensagem))]
        [Compare("Password", ErrorMessage = "A senha e a confirmação de senha não combinam.")]
        public string ConfirmPassword { get; set; }
    }
}

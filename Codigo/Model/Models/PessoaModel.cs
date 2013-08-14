using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class PessoaModel
    {
        [Required]
        public int PesId { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "CPF")]
        [StringLength(100)]
        public string CPF { get; set; }

        [Required]
        [Display(Name = "RG")]
        [StringLength(100)]
        public string RG { get; set; }

        [Required]
        [Display(Name = "Sexo")]
        [StringLength(100)]
        public string Sexo { get; set; }

        [Required]
        [Display(Name = "Email")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Login")]
        [StringLength(100)]
        public string Login { get; set; }

        [Required]
        [Display(Name = "Senha")]
        [StringLength(100)]
        public string Senha { get; set; }

        [Required]
        [Display(Name = "Telefone Fixo")]
        [StringLength(100)]
        public string TelefoneFixo { get; set; }

        [Required]
        [Display(Name = "Telefone Celular")]
        [StringLength(100)]
        public string TelefoneCelular { get; set; }

        [Required]
        [Display(Name = "Rua")]
        [StringLength(100)]
        public string Rua { get; set; }

        [Required]
        [Display(Name = "Número")]
        [StringLength(100)]
        public string Numero { get; set; }

        [Required]
        [Display(Name = "Complemento")]
        [StringLength(100)]
        public string Complemento { get; set; }

        [Required]
        [Display(Name = "Bairro")]
        [StringLength(100)]
        public string Bairro { get; set; }

        [Required]
        [Display(Name = "CEP")]
        [StringLength(100)]
        public string CEP { get; set; }

        [Required]
        [Display(Name = "Cidade")]
        [StringLength(100)]
        public string Cidade { get; set; }

        [Required]
        [Display(Name = "Estado")]
        [StringLength(100)]
        public string Estado { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        [StringLength(100)]
        public string Tipo { get; set; }

    }
}

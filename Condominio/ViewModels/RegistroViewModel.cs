using System.ComponentModel.DataAnnotations;

namespace Condominio.ViewModels
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        [Display (Name ="Celular")]
        public string Telefone { get; set; }


        public string? Foto { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigátorio")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme sua senha")]
        [Compare("Senha", ErrorMessage = "As senhas não conferem")]
        public string SenhaConfirmada { get; set; }
    }
}

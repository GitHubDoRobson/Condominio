using System.ComponentModel.DataAnnotations;

namespace Condominio.ViewModels
{
    public class RegistroViewModel
    {
        [Required (ErrorMessage =" O campo {0} é obrigatório.")]
        [StringLength (40, ErrorMessage = "Utilize até 40 caracteres")]
        public string Nome { get; set; }

        [Required (ErrorMessage = " O campo {0} é obrigatório.")]
        public string CPF { get; set; }

        [Required (ErrorMessage = " O campo {0} é obrigatório.")]
        public string Telefone { get; set; }

        public string Foto { get; set; }

        [Required (ErrorMessage = " O campo {0} é obrigatório.")]
        [StringLength (40, ErrorMessage = "Utilize até 40 caracteres.")]
        [EmailAddress (ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required (ErrorMessage = " O campo {0}  é obrigatório.")]
        [StringLength (30, ErrorMessage = "Utilize até 40 caracteres.")]
        [DataType (DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = " O campo {0}  é obrigatório.")]
        [StringLength(30, ErrorMessage = "Utilize até 40 caracteres.")]
        [DataType(DataType.Password)]
        [Display (Name = "Confirme sua senha")]
        [Compare ("Senha", ErrorMessage = " As senhas não conferem")]
        public string SenhaConfirmada { get; set; }

    }
}

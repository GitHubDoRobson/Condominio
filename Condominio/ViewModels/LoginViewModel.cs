using System.ComponentModel.DataAnnotations;

namespace Condominio.ViewModels
{
    public class LoginViewModel
    {
        [Required (ErrorMessage = " O campo {0} é obrigatório.")]
        [EmailAddress (ErrorMessage =" E-mail inválido.")]
        public string Email { get; set; }

        [Required (ErrorMessage = "O campo {0} é obrigatório.")]
        [DataType (DataType.Password)]

        public string Senha { get; set; }
    }
}

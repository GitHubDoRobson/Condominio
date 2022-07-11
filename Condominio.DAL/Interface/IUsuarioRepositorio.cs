using Condominio.BLL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.DAL.Interface
{
    public interface IUsuarioRepositorio : IRepositorioGenerico<Usuario>
    {
        int VerificarExisteRegistro();

        Task LogarUsuario(Usuario usuario, bool lembrar);

        Task<IdentityResult> CriarUsuario(Usuario usuario, String senha);

        Task IncluirUsuarioFuncao (Usuario usuario, string funcao);
    }
}

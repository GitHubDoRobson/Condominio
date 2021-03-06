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
        int VerificarseExisteRegistro();
        Task LogarUsuario(Usuario usuario, bool lembrar);

        Task DeslogarUsuario();
        Task<IdentityResult> CriarUsuario(Usuario usuario, string senha);
        Task IncluirUsuarioEmFuncao(Usuario usuario, string funcao);

        Task <Usuario> PegarUsuarioPeloEmail(string email);

        Task AtualizarUsuario (Usuario usuario);
        Task<Usuario> PegarUsuarioPeloId(string usuarioId);

        Task<bool> VerificarSeUsuarioEstaEmFuncao(Usuario usuario, string funcao);

        Task<IEnumerable<string>> PegarFuncoesUsuario(Usuario usuario);

        Task<IdentityResult> RemoverFuncoesUsuario(Usuario usuario, IEnumerable<string> funcoes);

        Task<IdentityResult>IncluirUsuarioEmFuncoes(Usuario usuario, IEnumerable<string>funcoes);


    }
}

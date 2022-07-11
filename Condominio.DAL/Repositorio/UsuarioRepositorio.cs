using Condominio.BLL.Models;
using Condominio.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.DAL.Repositorio
{
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}

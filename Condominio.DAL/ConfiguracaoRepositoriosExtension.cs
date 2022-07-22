using Condominio.DAL.Interface;
using Condominio.DAL.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.DAL
{
    public static class ConfiguracaoRepositoriosExtension
    {
        public static void ConfiguracaoRepositorios(this IServiceCollection services)        {

            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();            
            services.AddTransient<IFuncaoRepositorio, FuncaoRepositorio>();
            
        }
    }
}

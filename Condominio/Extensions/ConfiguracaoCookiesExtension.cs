namespace Condominio.Extensions
{
    public static class ConfiguracaoCookiesExtension
    {
        public static void ConfigurarCookies(this IServiceCollection services)
        {
            services.ConfigureApplicationCookie(opcoes => {
                opcoes.Cookie.Name = "Condominio";
                opcoes.Cookie.HttpOnly = true;
                opcoes.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                opcoes.LoginPath = "/Usuarios/Login";

            });
        }
    }
}

using Condominio.BLL.Models;
using Condominio.DAL.Mapeamento;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Condominio.DAL
{
    public class Contexto : IdentityDbContext <Usuario, Funcao, string>
    {
        public DbSet<Aluguel> Tb_Alugueis { get; set; }
        public DbSet<Apartamento> Tb_Apartamentos { get; set; }
        public DbSet<Evento> Tb_Evento { get; set; }
        public DbSet<Funcao> Tb_Funcoes { get; set; }
        public DbSet<HistoricoRecurso> Tb_HistoricoRecursos { get; set; }
        public DbSet<Mes> Tb_Meses { get; set; }
        public DbSet<Pagamento> Tb_Pagamentos { get; set; }
        public DbSet<Servico> Tb_Servicos { get; set; }
        public DbSet<ServicoPredio> Tb_ServicoPredios { get; set; }
        public DbSet<Usuario> Tb_Usuarios { get; set; }
        public DbSet<Veiculo> Tb_Veiculos { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AluguelMap());
            builder.ApplyConfiguration(new ApartamentoMap());
            builder.ApplyConfiguration(new EventoMap());
            builder.ApplyConfiguration(new FuncaoMap());
            builder.ApplyConfiguration(new HistoricoRecursoMap());
            builder.ApplyConfiguration(new MesMap());
            builder.ApplyConfiguration(new ServicoMap());
            builder.ApplyConfiguration(new ServicoPredioMap());
            builder.ApplyConfiguration(new UsuarioMap());
            builder.ApplyConfiguration(new VeiculoMap());
        }
    }
}
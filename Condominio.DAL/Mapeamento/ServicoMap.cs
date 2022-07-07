using Condominio.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.DAL.Mapeamento
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.Property(s => s.ServicoId);
            builder.Property(s => s.Nome).IsRequired().HasMaxLength(50);
            builder.Property(s => s.Valor).IsRequired();
            builder.Property(s => s.Status).IsRequired();
            builder.Property(s => s.UsuarioId).IsRequired();

            //Relecionamento das tabelas
            builder.HasOne(s => s.Usuario).WithMany(s => s.Servicos).HasForeignKey(s => s.UsuarioId);
            builder.HasMany(s => s.ServicoPredios).WithOne(s => s.Servico);

            //criando classe
            builder.ToTable("Tb_Servicos");
        }
    }
}

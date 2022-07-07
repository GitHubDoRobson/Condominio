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
    public class ServicoPredioMap : IEntityTypeConfiguration<ServicoPredio>
    {
        public void Configure(EntityTypeBuilder<ServicoPredio> builder)
        {
            builder.HasKey(sp => sp.ServicoPredioId);
            builder.Property(sp => sp.ServicoId).IsRequired();
            builder.Property(sp => sp.DataExecucao).IsRequired();

            //Relação da tabela
            builder.HasOne(sp => sp.Servico).WithMany(sp => sp.ServicoPredios).HasForeignKey(sp => sp.ServicoId);

            //Criação da tabela
            builder.ToTable("Tb_ServicoPredios");
        }
    }
}

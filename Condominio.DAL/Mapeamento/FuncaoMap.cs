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
    public class FuncaoMap : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(30);
            builder.HasData(
        new Funcao
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Morador",
            NormalizedName = "MORADOR",
            Descricao = "Morador do prédio"
        },
        new Funcao
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Sindico",
            NormalizedName = "SINDICO",
            Descricao = "Síndico do prédio"
        },

        new Funcao
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Adminstrador",
            NormalizedName = "Administrador",
            Descricao = "Administrador do prédio"
        });
            //Criando nome da tabela
            builder.ToTable("Tb_Funcoes");
            }
    }
}


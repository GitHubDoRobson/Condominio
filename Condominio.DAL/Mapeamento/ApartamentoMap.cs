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
    public class ApartamentoMap : IEntityTypeConfiguration<Apartamento>
    {
        public void Configure(EntityTypeBuilder<Apartamento> builder)
        {
            builder.HasKey(a => a.ApartamentoId);
            builder.Property(a => a.Numero).IsRequired();
            builder.Property(a => a.Andar).IsRequired();
            builder.Property(a => a.Foto).IsRequired();
            builder.Property(a => a.ProprietarioId).IsRequired();
            builder.Property(a => a.MoradorId).IsRequired(false);//o Apartamento pode está vazio.


            //Relacionamento da classe. Observação foi necessário adicionar o atributo onDelete pq o relacionamento poderia causar uma exclusão em casacata.

            builder.HasOne(a => a.Proprietario).WithMany(a => a.ProprietariosApartamentos).
                HasForeignKey(a => a.ProprietarioId).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.Morador).WithMany(a => a.MoradoresApartamentos).
                HasForeignKey(a => a.MoradorId).OnDelete(DeleteBehavior.NoAction);

            //Criação da tabela
            builder.ToTable("Tb_Apartamentos");
        }
    }
}

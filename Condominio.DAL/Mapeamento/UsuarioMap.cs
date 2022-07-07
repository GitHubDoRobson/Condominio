﻿using Condominio.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.DAL.Mapeamento
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.CPF).IsRequired().HasMaxLength(13);
            builder.HasIndex(u => u.CPF).IsUnique();
            builder.Property(u => u.Foto).IsRequired();
            builder.Property(u => u.PrimeiroAcesso).IsRequired();
            builder.Property(u => u.Status).IsRequired();

            //Relacionamento das classes 
            builder.HasMany(u => u.ProprietariosApartamentos).WithOne(u => u.Proprietario);
            builder.HasMany(u => u.MoradoresApartamentos).WithOne(u => u.Morador);
            builder.HasMany(u => u.Veiculos).WithOne(u => u.Usuario);
            builder.HasMany(u => u.Eventos).WithOne(u => u.Usuario);
            builder.HasMany(u => u.Pagamentos).WithOne(u => u.Usuario);
            builder.HasMany(u => u.Servicos).WithOne(u => u.Usuario);

            //Criação tabela
            builder.ToTable("Tb_Usuarios");
        }
    }
}

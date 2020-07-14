using AirLiquede.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirLiquede.Infra.Dados.Mapeamento
{
    public class ClienteMap : MapeamentoBasico<Cliente>
    {
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);
            builder.ToTable("Clientes");
            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");

            builder.Property(c => c.Nome).HasMaxLength(100).HasColumnName("Nome");
            builder.Property(c => c.Idade).HasColumnName("Idade");
        }
    }
}

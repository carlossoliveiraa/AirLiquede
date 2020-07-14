using AirLiquede.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirLiquede.Infra.Dados.Mapeamento
{
    public class MapeamentoBasico<T> : IEntityTypeConfiguration<T> where T : EntidadeBasica
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
        }
    }
}

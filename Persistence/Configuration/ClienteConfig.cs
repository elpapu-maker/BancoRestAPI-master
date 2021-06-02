using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configuration
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> Builder)
        {
            Builder.ToTable("Clientes");

            Builder.HasKey(p => p.id);

            Builder.Property(p => p.Nombre)
                   .HasMaxLength(80)
                   .IsRequired();

            Builder.Property(p => p.Apellido)
                   .HasMaxLength(80)
                   .IsRequired();

            Builder.Property(p => p.Telefono)
                   .HasMaxLength(9)
                   .IsRequired();

            Builder.Property(p => p.Email)
                   .HasMaxLength(100);

            Builder.Property(p => p.Direccion)
                   .HasMaxLength(120)
                   .IsRequired();

            Builder.Property(p => p.Edad);

            Builder.Property(p => p.CreatedBy)
                   .HasMaxLength(30);

            Builder.Property(p => p.LastModifiedBy)
                   .HasMaxLength(30);

        }
    }
}

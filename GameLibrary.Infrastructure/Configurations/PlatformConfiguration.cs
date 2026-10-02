using GameLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Infrastructure.Configurations
{
    /// <summary>
    /// Esta classe será responsável por configurar como a entidade Platform será mapeada pelo Entity Framework
    /// </summary>
    public class PlatformConfiguration : IEntityTypeConfiguration<Platform>
    {
         public void Configure(EntityTypeBuilder<Platform> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
        }  
    }
}
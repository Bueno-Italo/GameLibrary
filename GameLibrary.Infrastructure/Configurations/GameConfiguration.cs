using GameLibrary.Domain.Entities;
using GameLibrary.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Infrastructure.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        /// <summary>
        /// Essa classe é responsável por configurar a entidade Game no Entity Framework Core.
        /// Ela implementa a interface IEntityTypeConfiguration<Game> e define as regras de mapeamento para a tabela correspondente no banco de dados.
        /// </summary>
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(g => g.Description)
                .IsRequired(false)
                .HasMaxLength(200);

            builder.Property(g => g.Type)
                .IsRequired();

            builder.Property(g => g.ReleaseDate)
                .IsRequired(false);

            builder.Property(g => g.PlatformId)
                .IsRequired();

            builder.HasOne(g => g.Platform)
                .WithMany(p => p.Games)
                .HasForeignKey(g=> g.PlatformId);
        }
    }
}
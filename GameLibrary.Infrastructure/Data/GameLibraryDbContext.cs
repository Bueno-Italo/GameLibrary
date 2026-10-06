using GameLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Infrastructure.Data
{
    public class GameLibraryDbContext : DbContext
    {
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Game> Games { get; set; }

        public GameLibraryDbContext(DbContextOptions<GameLibraryDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GameLibraryDbContext).Assembly);
        }
    }
}
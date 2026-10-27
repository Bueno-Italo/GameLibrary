using GameLibrary.Application.Interfaces;
using GameLibrary.Domain.Entities;
using GameLibrary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Infrastructure.Repositories
{   
    public class PlatformRepository : IPlatformRepository
    {
        private readonly GameLibraryDbContext _context;
        public PlatformRepository(GameLibraryDbContext context)
        {
            _context = context;
        }

        public async Task<Platform> AddAsync(Platform platform)
        {
            _context.Platforms.Add(platform);
            await _context.SaveChangesAsync();
            return platform;
        }

        public async Task<List<Platform>> GetAllAsync()
        {
            return await _context.Platforms.ToListAsync();
        }

        public async Task<Platform?> GetByIdAsync(int id)
        {
            return await _context.Platforms.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Platform> UpdateAsync(Platform platform)
        {
            var existingPlatform = await _context.Platforms.FirstOrDefaultAsync(p => p.Id == platform.Id);
            if (existingPlatform == null)
            {
                throw new Exception($"Plataforma {platform.Id} não encontrada.");
            }

            existingPlatform.UpdateName(platform.Name);
            await _context.SaveChangesAsync();
            return existingPlatform;
        }
    }
}
using GameLibrary.Application.Interfaces;
using GameLibrary.Domain.Entities;
using GameLibrary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Infrastructure.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly GameLibraryDbContext _context;
        public GameRepository(GameLibraryDbContext context)
        {
            _context = context;
        }

        public async Task<List<Game>> GetAllGamesAsync()
        {
            return await _context.Games.ToListAsync();
        }
    }
}
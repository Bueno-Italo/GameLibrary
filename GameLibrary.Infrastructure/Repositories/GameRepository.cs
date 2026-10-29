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

        public async Task<Game> AddGameAsync(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();
            return game;
        }

        public async Task<List<Game>> GetAllGamesAsync()
        {
            var games = _context.Games.Include(g => g.Platform);
            return await games.ToListAsync();
        }

        public async Task<Game?> GetByIdAsync(int id)
        {
            return await _context.Games.Include(g => g.Platform).FirstOrDefaultAsync(g => g.Id == id);
        }
    }
}
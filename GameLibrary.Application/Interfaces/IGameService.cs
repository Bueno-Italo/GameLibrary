using GameLibrary.Domain.Entities;
using GameLibrary.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Application.Interfaces
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGamesAsync();
        Task<Game?> GetByIdAsync(int id);
        Task<Game?> AddGameAsync(Game game);
        Task<bool> UpdateGameAsync(
            int id,
            string name,
            int platformId,
            GameType type,
            string? description,
            DateOnly? releaseDate);
    }
}
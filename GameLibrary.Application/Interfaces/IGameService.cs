using GameLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Application.Interfaces
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGamesAsync();
        Task<Game?> GetByIdAsync(int id);
    }
}
using GameLibrary.Application.Interfaces;
using GameLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Application.Services
{
    public  class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task<List<Game>> GetAllGamesAsync()
        {
            return await _gameRepository.GetAllGamesAsync();
        }
    }
}

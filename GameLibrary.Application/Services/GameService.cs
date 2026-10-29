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

        public async Task<Game> AddGameAsync(Game game)
        {
            return await _gameRepository.AddGameAsync(game);
        }

        public async Task<List<Game>> GetAllGamesAsync()
        {
            return await _gameRepository.GetAllGamesAsync();
        }

        public async Task<Game?> GetByIdAsync(int id)
        {
            return await _gameRepository.GetByIdAsync(id);
        }
    }
}

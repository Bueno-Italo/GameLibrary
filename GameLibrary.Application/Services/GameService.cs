using GameLibrary.Application.Interfaces;
using GameLibrary.Domain.Entities;
using GameLibrary.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Application.Services
{
    public  class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        private readonly IPlatformService _platformService;
        public GameService(IGameRepository gameRepository, IPlatformService platformService)
        {
            _gameRepository = gameRepository;
            _platformService = platformService;
        }

        public async Task<Game?> AddGameAsync(Game game)
        {
            var platform = await _platformService.GetPlatformByIdAsync(game.PlatformId);
            if (platform == null)
            {
                return null;
            }
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

        public async Task<bool> UpdateGameAsync(
            int id,
            string name,
            int platformId,
            GameType type,
            string? description,
            DateOnly? releaseDate)
        {
           var updateGame =  await _gameRepository.GetByIdAsync(id);
            if (updateGame == null)
                return false;

           var platform = await _platformService.GetPlatformByIdAsync(platformId);
            if(platform == null)
                return false;

            updateGame.Update(name, platformId, type, description, releaseDate);
            await _gameRepository.UpdateGameAsync(updateGame);
            return true;
        }
    }
}
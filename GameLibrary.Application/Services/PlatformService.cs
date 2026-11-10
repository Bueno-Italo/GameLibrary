using GameLibrary.Application.Enums;
using GameLibrary.Application.Interfaces;
using GameLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Application.Services
{
    public class PlatformService : IPlatformService
    {
        private readonly IPlatformRepository _platformRepository;
        private readonly IGameRepository _gameRepository;

        public PlatformService(IPlatformRepository platformRepository, IGameRepository gameRepository)
        {
            _platformRepository = platformRepository;
            _gameRepository = gameRepository;
        }

        public Task<Platform> AddPlatformAsync(Platform platform)
        {
            return _platformRepository.AddAsync(platform);
        }

        public async Task<PlatformDeletionResult> DeletePlatformAsync(int id)
        {
            var platform = await _platformRepository.GetByIdAsync(id);
            if(platform == null)
            {
                return PlatformDeletionResult.NotFound;
            }

            var gamesUsingPlatform = await _gameRepository.ExistsByPlatformIdAsync(id);
            if(gamesUsingPlatform)
            {
                return PlatformDeletionResult.HasLinkedGames;
            }

             await _platformRepository.DeleteAsync(id);

            return PlatformDeletionResult.Deleted;

        }

        public async Task<List<Platform>> GetAllPlatformsAsync()
        {
            return await _platformRepository.GetAllAsync();
        }

        public async Task<Platform?> GetPlatformByIdAsync(int id)
        {
           return await _platformRepository.GetByIdAsync(id);

        }

        public async Task<Platform> UpdatePlatformAsync(Platform platform)
        {
            return await _platformRepository.UpdateAsync(platform);
        }

        //Task<PlatformDeletionResult> IPlatformService.DeletePlatformAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

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

        public PlatformService(IPlatformRepository platformRepository)
        {
            _platformRepository = platformRepository;
        }

        public Task<Platform> AddPlatformAsync(Platform platform)
        {
            return _platformRepository.AddAsync(platform);
        }

        public async Task<List<Platform>> GetAllPlatformsAsync()
        {
            return await _platformRepository.GetAllAsync();
        }

        public async Task<Platform?> GetPlatformByIdAsync(int id)
        {
           return await _platformRepository.GetByIdAsync(id);

        }
    }
}

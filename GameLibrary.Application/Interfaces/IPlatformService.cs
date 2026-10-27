using GameLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Application.Interfaces
{
    public interface IPlatformService
    {
        Task<List<Platform>> GetAllPlatformsAsync();
        Task<Platform> AddPlatformAsync(Platform platform);
        Task<Platform?> GetPlatformByIdAsync(int id);
    }
}
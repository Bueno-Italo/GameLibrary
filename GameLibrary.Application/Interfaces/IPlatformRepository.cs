using GameLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Application.Interfaces

{
    /// <summary>
    /// Define as operações de acesso aos dados de Platform
    /// </summary>
    public interface IPlatformRepository
    {
        //GetByIdAsync
        Task<Platform?> GetByIdAsync(int id);
        Task<List<Platform>> GetAllAsync();
        Task<Platform> AddAsync(Platform platform);
    }
}
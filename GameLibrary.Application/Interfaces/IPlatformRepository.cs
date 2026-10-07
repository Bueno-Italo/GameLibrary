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
        Task<List<Platform>> GetAllAsync();

    }
}

using GameLibrary.Application.Interfaces;
using GameLibrary.Domain.Entities;
using GameLibrary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary.Infrastructure.Repositories
{   
    public class PlatformRepository : IPlatformRepository
    {
        private readonly GameLibraryDbContext _context;
        public PlatformRepository(GameLibraryDbContext context)
        {
            _context = context;
        }

        public Task<List<Platform>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}

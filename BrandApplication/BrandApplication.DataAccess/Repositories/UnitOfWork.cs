﻿using BrandApplication.DataAccess.Interfaces;

namespace BrandApplication.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BrandDbContext _dbContext;

        public UnitOfWork(BrandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}

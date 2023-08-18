using Microsoft.EntityFrameworkCore;
using MyAPI.Entities;
using MyAPI.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyAPI.Services
{
    public class StoreService : IStoreService
    {
        private MyAPI.Entities.MyAPIDbContext myAPIDbContext;

        public StoreService(MyAPIDbContext myAPIDbContext)
        {
            this.myAPIDbContext = myAPIDbContext;
        }

        public async Task<List<Store>> GetStores()
        {
            var stores = myAPIDbContext.Stores;
            return await stores.ToListAsync();
        }
    }
}

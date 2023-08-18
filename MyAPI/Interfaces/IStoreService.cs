using MyAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyAPI.Interfaces
{
    public interface IStoreService
    {
        Task<List<Store>> GetStores();
    }
}

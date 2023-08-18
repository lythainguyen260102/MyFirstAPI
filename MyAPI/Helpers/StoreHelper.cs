using MyAPI.Entities;
using MyAPI.Models;
using System.Collections.Generic;

namespace MyAPI.Helpers
{
    public class StoreHelper
    {
        public static List<StoreModel> ConvertStores(List<Store> list)
        {
            var storeModels = list.ConvertAll(a => new StoreModel
            {
                Id = a.Id,
                Name = a.Name,
                Address = a.Address,
                Wallet = a.Wallet
            });

            return storeModels;
        }
    }
}

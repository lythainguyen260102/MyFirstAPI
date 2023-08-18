using MyAPI.Entities;
using MyAPI.Models;

namespace MyAPI.Helpers
{
    public class AIOHelper
    {
        public static AIOModel ConvertAIO(AIO list)
        {
            var accountList = list.Accounts;
            var storeList = list.Stores;
            var customerList = list.Customers;
            var goodsList = list.Goods;
            var orderList = list.Orders;
            var orderDetailList = list.OrdersDetails;

            AIOModel aioModel = new AIOModel();

            aioModel.accountModels = accountList.ConvertAll(a => new AccountModel
            {
                Id = a.Id,
                Password = a.Password,
                AccountType = a.AccountType
            });

            aioModel.storeModels = storeList.ConvertAll(a => new StoreModel
            {
                Id = a.Id,
                Name = a.Name,
                Address = a.Address,
                Wallet = a.Wallet
            });

            aioModel.customerModels = customerList.ConvertAll(a => new CustomerModel
            {
                Id = a.Id,
                Name = a.Name,
                Address = a.Address,
                Wallet = a.Wallet
            });

            aioModel.goodsModels = goodsList.ConvertAll(a => new GoodsModel
            {
                Id = a.Id,
                Image = a.Image,
                Name = a.Name,
                Description = a.Description,
                Discount = a.Discount,
                Price = a.Price,
                StoreID = a.StoreID
            });

            aioModel.orderModels = orderList.ConvertAll(a => new OrderModel
            {
                Id = a.Id,
                StoreID = a.StoreID,
                CustomerID = a.CustomerID
            });

            aioModel.ordersDetailModels = orderDetailList.ConvertAll(a => new OrdersDetailModel
            {
                OrderID = a.OrderID,
                GoodsID = a.GoodsID,
                Amount = a.Amount
            });

            return aioModel;
        }
    }
}

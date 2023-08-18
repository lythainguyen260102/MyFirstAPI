using System.Collections.Generic;

namespace MyAPI.Models
{
    public class AIOModel
    {
        public List<AccountModel> accountModels;
        public List<StoreModel> storeModels;
        public List<CustomerModel> customerModels;
        public List<GoodsModel> goodsModels;
        public List<OrderModel> orderModels;
        public List<OrdersDetailModel> ordersDetailModels;

        public Dictionary<string, object> Dict { get; set; }

        public AIOModel()
        {
            Dict = new Dictionary<string, object>();
        }

        public void setDict()
        {
            Dict.Add("accounts", accountModels);
            Dict.Add("stores", storeModels);
            Dict.Add("customers", customerModels);
            Dict.Add("goods", goodsModels);
            Dict.Add("orders", orderModels);
            Dict.Add("ordersdetails", ordersDetailModels);
        }
    }
}

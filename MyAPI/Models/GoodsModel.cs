namespace MyAPI.Models
{
    public class GoodsModel
    {
        public string Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Discount { get; set; }
        public float Price { get; set; }
        public string StoreID { get; set; }
    }
}

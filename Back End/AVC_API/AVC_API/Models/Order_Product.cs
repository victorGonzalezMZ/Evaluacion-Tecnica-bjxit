namespace AVC_API.Models
{
    public class Order_Product
    {
        public int ID { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
    }
}

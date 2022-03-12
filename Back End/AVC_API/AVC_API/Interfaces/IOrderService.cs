using AVC_API.Models;

namespace AVC_API.Interfaces
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrders();
        Task<Order> GetOrder(string id);
        Task<List<Product>> GetOrderProducts(string id);
        Task AddOrder(Order order);
        Task AddOrderProducts(Product product);
        Task UpdateOrder(Order order);
        Task DeleteOrder(Order order);
    }
}

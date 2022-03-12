using AVC_API.Interfaces;
using AVC_API.Models;

namespace AVC_API.Services
{
    public class OrderService : IOrderService
    {
        public OrderService()
        {

        }

        public Task AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Task AddOrderProducts(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrder(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetOrderProducts(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}

using Core.Entities;
using System.Collections.Generic;

namespace Core.Interfaces
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);

        IEnumerable<Order> GetAllOrders(bool includeItems);
        //IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems);
        //Order GetOrderById(string username, int id);
        void AddOrder(Order newOrder);

        bool SaveAll();
        void AddEntity(object model);
    }
}
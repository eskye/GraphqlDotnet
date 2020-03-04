using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Orders.Models;

namespace Orders.Services
{
    public interface IOrderService
    {
        Task<Order> GetOrderByIdAsync(string id);
        Task<IEnumerable<Order>> GetOrdersAsync();
    }
   public class OrderService : IOrderService
   {
       private IList<Order> _orders;
        public OrderService()
        {
            _orders = new List<Order>();
            _orders.Add(new Order("1000","250 conference brochures", DateTime.Now, 1,"FAEBD971-CBA5-4CED-8AD5-CC0B8D4B7827"));
            _orders.Add(new Order("2000","20 conference brochures", DateTime.Now.AddHours(1), 2,"FAEBE971-CBA5-4CED-8AD5-CC0B8D4B7827"));
            _orders.Add(new Order("3000","450 conference brochures", DateTime.Now.AddDays(3), 3,"FAEBD971-CBA5-4CED-8AD5-CC0B8D4B7827"));
            _orders.Add(new Order("4000","550 conference brochures", DateTime.Now, 4,"FAEBD171-CBA5-4CED-8AD5-CC0B8D4B7827"));
        }
        public Task<Order> GetOrderByIdAsync(string id)
        {
            return Task.FromResult(_orders.Single(o => o.Id == id));
        }

        public Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return Task.FromResult(_orders.AsEnumerable());
        }
    }
}

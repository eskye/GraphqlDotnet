using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Orders.Models;

namespace Orders.Services
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int id);
        Task<Customer> GetCustomerByIdAsync(int id);

        Task<IEnumerable<Customer>> GetCustomers();
    }

   public class CustomerService : ICustomerService
   {
       private IList<Customer> _customers;
        public CustomerService()
        {
            _customers = new List< Customer>();
            _customers.Add(new Customer( 1, "Andrew"));
            _customers.Add(new Customer( 2, "John"));
            _customers.Add(new Customer( 3, "Joe"));
            _customers.Add(new Customer( 4, "Dutch"));
        }
        public Customer GetCustomerById(int id)
        {
            return GetCustomerByIdAsync(id).Result;
        }

        public Task<Customer> GetCustomerByIdAsync(int id)
        {
            return Task.FromResult(_customers.Single(p => p.Id == id));
        }

        public Task<IEnumerable<Customer>> GetCustomers()
        {
            return Task.FromResult(_customers.AsEnumerable());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MudBlazorApp.Data
{
    public class CustomService : ICustomerService
    {
        private readonly ApplicationDbContext _dbContext;
        public CustomService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public void DeleteCustomer(int Id)
        {
            var customer = _dbContext.Customers.FirstOrDefault(x => x.Id == Id);
            if (customer != null)
            {
                _dbContext.Customers.Remove(customer);
                _dbContext.SaveChanges();
            }
        }

        public Customer GetCustomerById(int Id)
        {
            var customer = _dbContext.Customers.SingleOrDefault(x => x.Id == Id);
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            return _dbContext.Customers.ToList();
        }

        public void SaveCustomer(Customer customer) {
            if (customer.Id == 0)
                _dbContext.Customers.Add(customer);
            else
                _dbContext.Customers.Update(customer);

            _dbContext.SaveChanges();
        }
    }
}

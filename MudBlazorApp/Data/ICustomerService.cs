using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MudBlazorApp.Data
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(int Id);
        void SaveCustomer(Customer customer);
        void DeleteCustomer(int Id);
    }
}

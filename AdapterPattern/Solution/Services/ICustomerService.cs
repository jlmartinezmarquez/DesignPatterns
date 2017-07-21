using System.Collections.Generic;
using AdapterPattern.Models;

namespace AdapterPattern.Solution.Services
{
    public interface ICustomerService
    {
        IList<Customer> GetAllCustomers();
    }
}
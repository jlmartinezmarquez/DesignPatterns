using System.Collections.Generic;
using AdapterPattern.Models;

namespace AdapterPattern.Solution.Repository
{
    public interface ICustomerRepository
    {
        IList<Customer> GetCustomers();
    }
}

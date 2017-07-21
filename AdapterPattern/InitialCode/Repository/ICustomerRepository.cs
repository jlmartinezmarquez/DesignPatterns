using System.Collections.Generic;

namespace AdapterPattern.InitialCode.Repository
{
    public interface ICustomerRepository
    {
        IList<Models.Customer> GetCustomers();
    }
}

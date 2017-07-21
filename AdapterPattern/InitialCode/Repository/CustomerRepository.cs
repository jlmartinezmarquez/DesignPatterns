using System.Collections.Generic;

namespace AdapterPattern.InitialCode.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public IList<Models.Customer> GetCustomers()
        {
            //simulate database operation
            return new List<Models.Customer>();
        }
    }
}

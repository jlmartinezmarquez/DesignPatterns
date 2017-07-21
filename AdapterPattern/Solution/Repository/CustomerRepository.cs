using System.Collections.Generic;
using AdapterPattern.Models;
using AdapterPattern.Models.Builders;

namespace AdapterPattern.Solution.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public IList<Customer> GetCustomers()
        {
            //simulate database operation
            var alfredo = CustomerBuilder.New().WithFullName("Alfredo Landa").Build();
            var luis = CustomerBuilder.New().WithFullName("Luis Landero").Build();

            return new List<Customer> { alfredo, luis };
        }
    }
}

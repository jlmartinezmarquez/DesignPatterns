using System.Collections.Generic;
using System.Web;
using AdapterPattern.InitialCode.Repository;

namespace AdapterPattern.InitialCode
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IList<Models.Customer> GetAllCustomers()
        {
            IList<Models.Customer> customers;
            string storageKey = "GetAllCustomers";
            customers = (List<Models.Customer>)HttpContext.Current.Cache.Get(storageKey);
            if (customers == null)
            {
                customers = _customerRepository.GetCustomers();
                HttpContext.Current.Cache.Insert(storageKey, customers);
            }

            return customers;
        }
    }
}

using System.Collections.Generic;
using AdapterPattern.Solution.Repository;
using AdapterPattern.Models;
using AdapterPattern.Solution.Modules;

namespace AdapterPattern.Solution.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICacheAdapter _cacheAdapter;

        public string StorageKey = "GetAllCustomers";

        public CustomerService(ICustomerRepository customerRepository, ICacheAdapter cacheAdapter)
        {
            _customerRepository = customerRepository;
            _cacheAdapter = cacheAdapter;
        }

        public IList<Customer> GetAllCustomers()
        {
            IList<Customer> customers = (List<Customer>)_cacheAdapter.Get(StorageKey);

            if (customers == null)
            {
                customers = _customerRepository.GetCustomers();
                _cacheAdapter.Insert(StorageKey, customers);
            }

            return customers;
        }
    }
}

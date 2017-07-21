using System;
using System.Collections.Generic;
using AdapterPattern.Models;
using AdapterPattern.Solution.Modules;
using AdapterPattern.Solution.Repository;
using AdapterPattern.Solution.Services;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICacheAdapter cacheAdapter = new CacheAdapter();
            ICustomerRepository customerRepository = new CustomerRepository();

            var customerService = new CustomerService(customerRepository, cacheAdapter);

            customerService.GetAllCustomers();

            var cachedCustomers = (List<Customer>)cacheAdapter.Get(customerService.StorageKey);

            cachedCustomers.ForEach(x => Console.WriteLine(x.FullName));
        }
    }
}

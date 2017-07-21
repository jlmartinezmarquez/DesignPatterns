namespace AdapterPattern.Models.Builders
{
    public class CustomerBuilder
    {
        private Customer _customer;

        public CustomerBuilder()
        {
            _customer = new Customer();
        }

        public static CustomerBuilder New()
        {
            return new CustomerBuilder();
        }

        public CustomerBuilder WithFullName(string name)
        {
            _customer.FullName = name;
            return this;
        }

        public Customer Build()
        {
            return _customer;
        }
    }
}

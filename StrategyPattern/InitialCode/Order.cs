namespace StrategyPattern.InitialCode
{
    public class Order
    {
        public ShippingOptionsEnum ShippingMethod { get; set; }
        public Address Destination { get; set; }
        public Address Origin { get; set; }
    }
}

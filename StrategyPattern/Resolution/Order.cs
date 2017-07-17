using StrategyPattern.InitialCode;

namespace StrategyPattern.Resolution
{
    public class Order
    {
        public ShippingOptionsEnum ShippingMethod { get; set; }
        public InitialCode.Address Destination { get; set; }
        public InitialCode.Address Origin { get; set; }
    }
}

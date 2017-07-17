namespace StrategyPattern.Resolution.ShippingStrategy
{
    public class ShippingStrategySchenker : IShippingStrategy
    {
        public double CalculateShippingCost()
        {
            return 3.00d;
        }
    }
}

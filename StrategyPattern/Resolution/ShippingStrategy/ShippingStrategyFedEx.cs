namespace StrategyPattern.Resolution.ShippingStrategy
{
    public class ShippingStrategyFedEx : IShippingStrategy
    {
        public double CalculateShippingCost()
        {
            return 5.00d;
        }
    }
}

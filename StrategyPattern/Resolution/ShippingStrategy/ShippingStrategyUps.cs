namespace StrategyPattern.Resolution.ShippingStrategy
{
    public class ShippingStrategyUps : IShippingStrategy
    {
        public double CalculateShippingCost()
        {
            return 4.25d;
        }
    }
}

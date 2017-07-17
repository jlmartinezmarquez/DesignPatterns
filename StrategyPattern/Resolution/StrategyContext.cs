using StrategyPattern.Resolution.ShippingStrategy;

namespace StrategyPattern.Resolution
{
    public class StrategyContext
    {
        private readonly IShippingStrategy _shippingStrategy;

        public StrategyContext(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost()
        {
            return _shippingStrategy.CalculateShippingCost();
        }
    }
}

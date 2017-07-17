using StrategyPattern.Resolution.ShippingStrategy;

namespace StrategyPattern.Resolution
{
    public class Context
    {
        private readonly IShippingStrategy _shippingStrategy;

        public Context(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost()
        {
            return _shippingStrategy.CalculateShippingCost();
        }
    }
}

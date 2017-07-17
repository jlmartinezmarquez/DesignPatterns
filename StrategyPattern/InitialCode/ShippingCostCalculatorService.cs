using System;

namespace StrategyPattern.InitialCode
{
    public class ShippingCostCalculatorService
    {
        public double CalculateShippingCost(Order order)
        {
            switch (order.ShippingMethod)
            {
                case ShippingOptionsEnum.FedEx:
                    return CalculateForFedEx(order);

                case ShippingOptionsEnum.UPS:
                    return CalculateForUPS(order);

                case ShippingOptionsEnum.Schenker:
                    return CalculateForSchenker(order);

                default:
                    throw new Exception("Unknown carrier");

            }

        }

        double CalculateForSchenker(Order order)
        {
            return 3.00d;
        }

        double CalculateForUPS(Order order)
        {
            return 4.25d;
        }

        double CalculateForFedEx(Order order)
        {
            return 5.00d;
        }
    }
}

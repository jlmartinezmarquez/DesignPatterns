using System;
using System.Linq;
using System.Reflection;
using StrategyPattern.Resolution;
using StrategyPattern.Resolution.ShippingStrategy;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfCarrier = Console.ReadLine();

            if (string.IsNullOrEmpty(typeOfCarrier)) return;

            var shippingStrategies = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.GetInterface(nameof(IShippingStrategy)) != null).ToList();

            var shippingStrategyToInstantiate = shippingStrategies.FirstOrDefault(x => x.Name.ToLower().Contains(typeOfCarrier.ToLower()));

            if (shippingStrategyToInstantiate == null) return;

            var shippingStrategyToInject = Activator.CreateInstance(shippingStrategyToInstantiate) as IShippingStrategy;

            var context = new StrategyContext(shippingStrategyToInject);

            Console.WriteLine(context.CalculateShippingCost());

            Console.ReadKey();
        }
    }
}

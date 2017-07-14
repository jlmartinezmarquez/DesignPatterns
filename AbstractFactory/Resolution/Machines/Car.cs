using System;

namespace AbstractFactory.Resolution.Machines
{
    public class Car : IMachine
    {
        public string Name => "car";

        public void TurnOn()
        {
            Console.WriteLine("Car is starting.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Car is stopping.");
        }
    }
}
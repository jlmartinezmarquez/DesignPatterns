using System;

namespace AbstractFactory.Resolution.Machines
{
    public class Robot : IMachine
    {
        public string Name => "robot";

        public void TurnOn()
        {
            Console.WriteLine("Robot is starting.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Robot is stopping.");
        }
    }
}
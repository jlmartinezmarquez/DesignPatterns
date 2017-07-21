using System;

namespace CompositePattern.InitialCode
{
    public class Player
    {
        public string Name { get; set; }
        public int Gold { get; set; }

        public void Stats()
        {
            Console.WriteLine("{0} has {1} coins.", Name, Gold);
        }
    }
}

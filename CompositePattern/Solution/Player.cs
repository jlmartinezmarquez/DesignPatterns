using System;

namespace CompositePattern.Solution
{
    public class Player : IComponentGroup
    {
        public string Name { get; set; }
        public int Gold { get; set; }

        public void Stats()
        {
            Console.WriteLine("{0} has {1} coins.", Name, Gold);
        }

        public void Add(Player player)
        {
            Console.WriteLine("You can't add players to a player");
        }
    }
}

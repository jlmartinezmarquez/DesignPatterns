using System;

namespace CompositePattern.Solution
{
    public class PlayerComponent : IParticipant
    {
        public string Name { get; set; }

        public int Gold { get; set; }

        public void Stats()
        {
            Console.WriteLine("{0} has {1} coins.", Name, Gold);
        }

        public void Add(PlayerComponent player)
        {
            Console.WriteLine("A player can't be add to a player");
        }

        public void Remove(PlayerComponent player)
        {
            Console.WriteLine("A player can't be add to a player");
        }
    }
}

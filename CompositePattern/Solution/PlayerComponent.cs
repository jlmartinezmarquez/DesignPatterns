using System;

namespace CompositePattern.Solution
{
    public class PlayerComponent : IPlayerComponent
    {
        public void Add(PlayerComponent player)
        {
            Console.WriteLine("A player can;t be add to a player");
        }

        public void Remove(PlayerComponent player)
        {
            Console.WriteLine("A player can;t be add to a player");
        }
    }
}

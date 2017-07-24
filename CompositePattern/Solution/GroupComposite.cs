using System.Collections.Generic;

namespace CompositePattern.Solution
{
    public class GroupComposite : IPlayerComponent
    {
        private List<PlayerComponent> _players = new List<PlayerComponent>();

        public void Add(PlayerComponent player)
        {
            _players.Add(player);
        }

        public void Remove(PlayerComponent player)
        {
            _players.Remove(player);
        }
    }
}

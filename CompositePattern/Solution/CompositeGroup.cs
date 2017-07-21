using System.Collections.Generic;

namespace CompositePattern.Solution
{
    public class CompositeGroup : IComponentGroup
    {
        public List<Player> Members { get; set; }

        private string _name;

        public CompositeGroup(string name)
        {
            _name = name;
            Members = new List<Player>();
        }

        public void Add(Player player)
        {
            Members.Add(player);
        }
    }
}

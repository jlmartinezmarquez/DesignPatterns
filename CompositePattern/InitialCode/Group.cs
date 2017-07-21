using System.Collections.Generic;

namespace CompositePattern.InitialCode
{
    public class Group
    {
        public string Name { get; set; }
        public List<Player> Members { get; set; }

        public Group()
        {
            Members = new List<Player>();
        }
    }
}

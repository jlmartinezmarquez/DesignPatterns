using System.Collections.Generic;
using System.Linq;

namespace CompositePattern.Solution
{
    public class Group : IParticipant
    {
        public Group()
        {
            Members = new List<IParticipant>();
        }

        public int Gold
        {
            get
            {
                return Members.Sum(member => member.Gold);
            }
            set
            {
                if (Members.Count == 0) return;

                var goldPerMember = value/Members.Count;
                foreach (var member in Members)
                {
                    member.Gold = goldPerMember;
                }

                var leftOver = value % Members.Count;
                Members[0].Gold += leftOver;
            }
        }

        public string Name { get; set; }
      
        public List<IParticipant> Members { get; set; }

        public void Stats()
        {
            foreach (IParticipant member in Members)
            {
                member.Stats();
            }
        }
    }
}

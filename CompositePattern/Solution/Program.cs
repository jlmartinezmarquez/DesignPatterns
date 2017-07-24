using System;
using System.Collections.Generic;

namespace CompositePattern.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldForKill = 1023;
            Console.WriteLine("You have killed the Monster and gained {0} coins!", goldForKill);

            var individuals = new Group();
            individuals.Members.Add(new PlayerComponent() {Name = "Ann" });
            individuals.Members.Add(new PlayerComponent() { Name = "Edith" });

            var developers = new Group { Name = "Developers" };
            developers.Members.Add(new PlayerComponent() { Name = "Andy" });
            developers.Members.Add(new PlayerComponent() { Name = "Jane" });
            developers.Members.Add(new PlayerComponent() { Name = "Eve" });

            var composite = new Group {Members = new List<IParticipant> {individuals, developers}};
            composite.Gold += goldForKill;

            foreach (var element in composite.Members)
            {
                element.Stats();
            }

            Console.ReadKey();
        }
    }
}

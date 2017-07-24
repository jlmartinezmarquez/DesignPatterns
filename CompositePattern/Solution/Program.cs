using System;
using System.Collections.Generic;
using CompositePattern.InitialCode;

namespace CompositePattern.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldForKill = 1023;
            Console.WriteLine("You have killed the Monster and gained {0} coins!", goldForKill);

            PlayerComponent andy = new PlayerComponent { Name = "Andy" };
            PlayerComponent jane = new PlayerComponent { Name = "Jane" };
            PlayerComponent eve = new PlayerComponent { Name = "Eve" };
            PlayerComponent ann = new PlayerComponent { Name = "Ann" };
            PlayerComponent edith = new PlayerComponent { Name = "Edith" };
            GroupComposite developers = new GroupComposite { Name = "Developers", Members = { andy, jane, eve } };

            List<PlayerComponent> individuals = new List<PlayerComponent> { ann, edith };
            List<GroupComposite> groups = new List<GroupComposite> { developers };

            double totalToSplitBy = individuals.Count + groups.Count;
            double amountForEach = goldForKill / totalToSplitBy;
            double leftOver = goldForKill % totalToSplitBy;

            foreach (PlayerComponent individual in individuals)
            {
                individual.Gold += Convert.ToInt32(amountForEach + leftOver);
                leftOver = 0;
                individual.Stats();
            }

            foreach (GroupComposite group in groups)
            {
                double amountForEachGroupMember = amountForEach / group.Members.Count;
                double leftOverForGroup = amountForEachGroupMember % group.Members.Count;
                foreach (PlayerComponent member in group.Members)
                {
                    member.Gold += Convert.ToInt32(amountForEachGroupMember + leftOverForGroup);
                    leftOverForGroup = 0;
                    member.Stats();
                }
            }

            Console.ReadKey();
        }
    }
}

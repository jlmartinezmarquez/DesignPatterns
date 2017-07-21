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

            Player andy = new Player { Name = "Andy" };
            Player jane = new Player { Name = "Jane" };
            Player eve = new Player { Name = "Eve" };
            Player ann = new Player { Name = "Ann" };
            Player edith = new Player { Name = "Edith" };

            CompositeGroup developers = new CompositeGroup("Developers") { Members = { andy, jane, eve } };

            CompositeGroup individuals = new CompositeGroup("Individuals") { Members = { ann, edith } };

            List<CompositeGroup> groups = new List<CompositeGroup> { developers };

            double totalToSplitBy = individuals.Count + groups.Count;
            double amountForEach = goldForKill / totalToSplitBy;
            double leftOver = goldForKill % totalToSplitBy;

            foreach (var individual in individuals)
            {
                individual.Gold += Convert.ToInt32(amountForEach + leftOver);
                leftOver = 0;
                individual.Stats();
            }

            foreach (CompositeGroup group in groups)
            {
                double amountForEachGroupMember = amountForEach / group.Members.Count;
                double leftOverForGroup = amountForEachGroupMember % group.Members.Count;
                foreach (Player member in group.Members)
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

using System;
using System.Collections.Generic;
using System.Reflection;
using AbstractFactory.Resolution.Machines;

namespace AbstractFactory.Resolution.Factory
{
    public class MachineFactory : IMachineFactory
    {
        public IMachine GetMachine(string machineName)
        {
            var machine = GetTypeToCreate(machineName);

            if (machine == null) return new UnknownMachine();

            return Activator.CreateInstance(machine) as IMachine;
        }

        private Type GetTypeToCreate(string machineName)
        {
            var machines = LoadMachineTypes();

            foreach (var machine in machines)
            {
                if (machine.Key.Contains(machineName)) return machines[machine.Key];
            }

            return null;
        }

        private Dictionary<string, Type> LoadMachineTypes()
        {
            var machines = new Dictionary<string, Type>();

            var typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var t in typesInThisAssembly)
            {
                if (t.GetInterface(nameof(IMachine)) != null)
                {
                    machines.Add(t.Name.ToLower(), t);
                }
            }

            return machines;
        }
    }
}

using System;
using AbstractFactory.Resolution.Factory;

namespace AbstractFactory.Resolution
{
    public class MachineClient
    {
        private readonly IMachineFactory _machineFactory;

        public MachineClient(IMachineFactory machineFactory)
        {
            _machineFactory = machineFactory;
        }

        public void PutMachineToWorkAndStop()
        {
            var description = Console.ReadLine();

            var machine = _machineFactory.GetMachine(description);

            machine.TurnOn();

            machine.TurnOff();

            Console.ReadKey();
        }
    }
}

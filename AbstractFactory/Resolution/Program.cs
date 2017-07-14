using AbstractFactory.Resolution.Factory;
using AbstractFactory.Resolution.Machines;

namespace AbstractFactory.Resolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var machineFactory = new MachineFactory();

            var client = new MachineClient(machineFactory);

            client.PutMachineToWorkAndStop();
        }
    }
}

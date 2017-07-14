using AbstractFactory.Resolution.Machines;

namespace AbstractFactory.Resolution.Factory
{
    public interface IMachineFactory
    {
        IMachine GetMachine(string description);
    }
}

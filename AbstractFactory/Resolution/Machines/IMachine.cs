namespace AbstractFactory.Resolution.Machines
{
    public interface IMachine
    {
        string Name { get; }

        void TurnOn();

        void TurnOff();
    }
}

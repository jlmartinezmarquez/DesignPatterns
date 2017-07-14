namespace AbstractFactory.Resolution.Machines
{
    public class UnknownMachine : IMachine
    {
        public string Name => string.Empty;

        public void TurnOn()
        {
            
        }

        public void TurnOff()
        {
            
        }
    }
}
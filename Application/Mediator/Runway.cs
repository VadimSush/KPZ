namespace Mediator
{
    public class Runway
    {
        private readonly CommandCentre _commandCenter;

        public readonly Guid Id = Guid.NewGuid();

        public Runway(CommandCentre commandCenter)
        {
            _commandCenter = commandCenter;
            _commandCenter.AddRunway(this);
        }

        public bool CheckIsAvailable()
        {
            return _commandCenter.CheckIsRunwayAvailable(this);
        }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }
    }
}

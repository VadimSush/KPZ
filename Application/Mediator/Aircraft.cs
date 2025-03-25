namespace Mediator
{
    public class Aircraft
    {
        private readonly CommandCentre _commandCentre;

        public string Name;

        public bool IsTakingOff { get; set; }

        public Aircraft(string name, CommandCentre commandCentre)
        {
            Name = name;
            _commandCentre = commandCentre;
            _commandCentre.AddAircraft(this);
        }

        public void Land()
        {
            _commandCentre.AircraftLand(this);
        }
        public void TakeOff()
        {
            _commandCentre.AircraftTakeOff(this);
        }
    }
}

namespace Mediator
{
    public class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();

        private List<Aircraft> _aircrafts = new List<Aircraft>();

        private Dictionary<Aircraft, Runway> _aircraftsRunways = new Dictionary<Aircraft, Runway>();

        private HashSet<Runway> _busyRunways = new HashSet<Runway>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            _runways.AddRange(runways);
            _aircrafts.AddRange(aircrafts);
        }

        public void AircraftLand(Aircraft aircraft)
        {
            Runway runway = _aircraftsRunways[aircraft];

            Console.WriteLine($"Aircraft {aircraft.Name} is landing.");
            Console.WriteLine($"Checking runway.");
            if (runway.CheckIsAvailable())
            {
                Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
                _busyRunways.Add(runway);
                runway.HighLightRed();
            }
            else
            {
                Console.WriteLine($"Could not land, the runway is busy.");
            }
        }

        public void AircraftTakeOff(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is taking off.");
            Runway runway = _aircraftsRunways[aircraft];
            if (_busyRunways.Contains(runway))
            {
                _busyRunways.Remove(runway);
            }
            runway.HighLightGreen();
            Console.WriteLine($"Aircraft {aircraft.Name} has took off.");
        }

        public bool CheckIsRunwayAvailable(Runway runway)
        {
            return !_busyRunways.Contains(runway);
        }

        public void AddRunway(Runway runway)
        {
            _runways.Add(runway);
        }

        public void AddAircraft(Aircraft aircraft)
        {
            _aircrafts.Add(aircraft);
        }

        public void UpdateRunway(Aircraft aircraft, Runway runway)
        {
            _aircraftsRunways[aircraft] = runway;
        }
    }
}

using Mediator;

CommandCentre commandCentre = new CommandCentre([], []);

Runway runway1 = new Runway(commandCentre);
Runway runway2 = new Runway(commandCentre);

Aircraft aircraft1 = new Aircraft("Name 1", commandCentre);
Aircraft aircraft2 = new Aircraft("Airplane 2", commandCentre);
Aircraft aircraft3 = new Aircraft("Super airplane 3", commandCentre);

commandCentre.UpdateRunway(aircraft1, runway1);
commandCentre.UpdateRunway(aircraft2, runway2);
commandCentre.UpdateRunway(aircraft3, runway2);

aircraft1.Land();
aircraft2.Land();
aircraft3.Land();
aircraft2.TakeOff();
aircraft3.Land();

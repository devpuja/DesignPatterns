using BuilderDirector;

var builder = new GamingComputerBuilder();

var director = new ComputerDirector();

Computer gamingComputer = director.BuildGamingComputer(builder);
gamingComputer.DisplaySpecifications();
using Builder;

IComputerBuilder gaming = new GamingComputerBuilder();
ComputerDirector director = new ComputerDirector(gaming);

director.ConstructComputer();
Computer gamingComputer = gaming.Build();

Console.WriteLine("Gaming Computer is constructed:");
gamingComputer.Display();
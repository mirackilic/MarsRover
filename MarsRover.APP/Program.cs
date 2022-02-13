using MarsRover.DOMAIN.Entities;
using MarsRover.DOMAIN.Interfaces;
using MarsRover.DOMAIN.Enums;

Console.WriteLine("Input:");
Console.WriteLine();
Console.WriteLine("5 5");
Console.WriteLine("1 2 N");
Console.WriteLine("LMLMLMLMM");
Console.WriteLine();
Console.WriteLine("3 3 E");
Console.WriteLine("MMRMMRMRRM");
Console.WriteLine();
//First rover 
Plateau plateauOne = new Plateau(new Position(5, 5));
Rover firstRover = new Rover(plateauOne, new Position(1, 2), Direction.N);
firstRover.Process("LMLMLMLMM");

//Second rover 
Plateau plateauTwo = new Plateau(new Position(5, 5));
Rover secondRover = new Rover(plateauTwo, new Position(3, 3), Direction.E);
secondRover.Process("MMRMMRMRRM");

Console.WriteLine("Output:");
Console.WriteLine();
Console.WriteLine(firstRover.ToString());
Console.WriteLine(secondRover.ToString());
Console.WriteLine();

Console.ReadLine();
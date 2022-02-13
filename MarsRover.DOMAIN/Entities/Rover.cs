using MarsRover.DOMAIN.Interfaces;
using MarsRover.DOMAIN.Enums;

namespace MarsRover.DOMAIN.Entities;

/// <summary>
/// Rover class structure
/// </summary>
public class Rover : IRover
{
    public IPlateau RoverPlateau { get; set; }
    public IPosition RoverPosition { get; set; }
    public Direction RoverDirection { get; set; }

    public Rover(IPlateau roverPlateau, IPosition roverPosition, Direction roverDirection)
    {
        RoverPlateau = roverPlateau;
        RoverPosition = roverPosition;
        RoverDirection = roverDirection;
    }

    public void Process(string commands)
    {
        foreach (var command in commands)
        {
            switch (command)
            {
                case ('L'):
                    TurnLeft();
                    break;
                case ('R'):
                    TurnRight();
                    break;
                case ('M'):
                    Move();
                    break;
                default:
                    throw new ArgumentException(string.Format("Invalid value: {0}", command));
            }
        }
    }

    private void TurnLeft()
    {
        RoverDirection = (RoverDirection - 1) < Direction.N ? Direction.W : RoverDirection - 1;
    }

    private void TurnRight()
    {
        RoverDirection = (RoverDirection + 1) > Direction.W ? Direction.N : RoverDirection + 1;
    }

    private void Move()
    {
        if (RoverDirection == Direction.N)
        {
            RoverPosition.YCoordinate++;
        }
        else if (RoverDirection == Direction.E)
        {
            RoverPosition.XCoordinate++;
        }
        else if (RoverDirection == Direction.S)
        {
            RoverPosition.YCoordinate--;
        }
        else if (RoverDirection == Direction.W)
        {
            RoverPosition.XCoordinate--;
        }
    }

    public override string ToString()
    {
        return string.Format("{0} {1} {2}", RoverPosition.XCoordinate, RoverPosition.YCoordinate, RoverDirection);
    }
}
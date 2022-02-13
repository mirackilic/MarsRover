using MarsRover.DOMAIN.Interfaces;

namespace MarsRover.DOMAIN.Entities;

public class Position : IPosition
{
    public int XCoordinate { get; set; }
    public int YCoordinate { get; set; }

    public Position(int x, int y)
    {
        XCoordinate = x;
        YCoordinate = y;
    }
}
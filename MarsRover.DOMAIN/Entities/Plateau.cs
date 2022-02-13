using MarsRover.DOMAIN.Entities;
using MarsRover.DOMAIN.Interfaces;

namespace MarsRover.DOMAIN.Entities;

/// <summary>
/// Plateau class structure
/// </summary>
public class Plateau : IPlateau
{
    public Position PlateauPosition { get; private set; }

    public Plateau(Position position)
    {
        PlateauPosition = position;
    }
}

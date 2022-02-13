using MarsRover.DOMAIN.Enums;

namespace MarsRover.DOMAIN.Interfaces;

public interface IRover
{
    IPlateau RoverPlateau { get; set; }
    IPosition RoverPosition { get; set; }
    Direction RoverDirection { get; set; }

    #region Methods 

    void Process(string commands);
    string ToString();

    #endregion
}

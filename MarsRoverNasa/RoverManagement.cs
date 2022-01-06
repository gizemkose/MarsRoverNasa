using Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNasa
{
    public class RoverManagement
    {
        public void Move(string roverCommand, Rover rover, Plateau plateau)
        {
            char[] intructions = roverCommand.ToUpper().ToCharArray();
            bool availableMovement = true;
            for (int i = 0; i < intructions.Length; i++)
            {
                switch (intructions[i])
                {
                    case CommandConstants.SpinLeftCommand:
                        rover.SpinLeft();
                        break;
                    case CommandConstants.SpinRightCommand:
                        rover.SpinRight();
                        break;
                    case CommandConstants.StepForwardCommand:
                        if (AvailableMovement(rover, plateau))
                        {
                            rover.StepForward();
                        }
                        else
                        {
                            availableMovement = false;
                        }
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            if (!availableMovement)
            {
                Console.WriteLine("Final destination of the rover is not available");
            }
        }
        public bool AvailableMovement(Rover rover, Plateau plateau)
        {
            if (rover.y == 0 && rover.direction == DirectionConstants.South)
            {
                return false;
            }
            else if (rover.y == plateau.ySize && rover.direction == DirectionConstants.North)
            {
                return false;
            }
            else if (rover.x == 0 && rover.direction == DirectionConstants.West)
            {
                return false;
            }
            else if (rover.x == plateau.xSize && rover.direction == DirectionConstants.East)
            {
                return false;
            }
            return true;
        }       
    }
}

using Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNasa
{
    public class RoverManagement
    {     
        public void Move(string roverCommand, Rover rover)
        {
            char[] intructions = roverCommand.ToUpper().ToCharArray();
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
                        rover.StepForward();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}

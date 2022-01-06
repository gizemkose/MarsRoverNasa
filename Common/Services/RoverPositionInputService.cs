using Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ValidationServices
{
    public class RoverPositionInputService
    {
        public string RoverPositionInput(int plateauXsize, int plateauYsize)
        {
            var correctPositionInput = false;
            string positionInput = string.Empty;
           
            while (!correctPositionInput)
            {
                positionInput = Console.ReadLine();

                if (InputControl(positionInput))
                {
                    DirectionControl(positionInput);
                }
                if (!InputControl(positionInput) || !DirectionControl(positionInput))
                {
                    Console.WriteLine("Not a valid rover position, try again.");
                }
                else if (!RoverPlacement(positionInput, plateauXsize, plateauYsize))
                {
                    Console.WriteLine("Rover cannot be placed outside the plateu boundary.");
                }
                else
                {
                    correctPositionInput = true;
                }
            }
            return positionInput;
        }
        public bool RoverPlacement(string positionInput, int plateauX,int plateauY)
        {
            var roverPosition_X = Convert.ToInt32(positionInput.Split(" ")[0]);
            var roverPosition_Y = Convert.ToInt32(positionInput.Split(" ")[1]);
            var plateau_XSize = plateauX;
            var plateau_YSize = plateauY;

            if (0 <= roverPosition_X && roverPosition_X <= plateau_XSize && 0 <= roverPosition_Y && roverPosition_Y <= plateau_YSize)
            {
                return true;
            }
            return false;
        }
        public bool InputControl(string positionInput)
        {
            int x;
            int y;
            return positionInput.Split(" ").Length == 3 && Int32.TryParse(positionInput.Split(" ")[0], out x) && Int32.TryParse(positionInput.Split(" ")[1], out y);
        }
        public bool DirectionControl(string positionInput)
        {
            if(positionInput.Split(" ").Length != 3)
            {
                return false;
            }
            var direction = positionInput.Split(" ")[2].ToUpper();
           return direction == DirectionConstants.North || direction == DirectionConstants.South || direction == DirectionConstants.East || direction == DirectionConstants.West;
        }
    }
}

using Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ValidationServices
{
    public class RoverPositionInputService
    {
        public string RoverPositionInput()
        {
            var correctPositionInput = false;
            string positionInput = string.Empty;
            int x;
            int y;
            while (!correctPositionInput)
            {
                positionInput = Console.ReadLine();

                var inputControl = positionInput.Split(" ").Length == 3 && Int32.TryParse(positionInput.Split(" ")[0], out x) && Int32.TryParse(positionInput.Split(" ")[1], out y);
                var directionControl = false;
                if (inputControl)
                {
                    var direction = positionInput.Split(" ")[2].ToUpper();
                    directionControl = direction == DirectionConstants.North || direction == DirectionConstants.South || direction == DirectionConstants.East || direction == DirectionConstants.West;
                }
                if (!inputControl || !directionControl)
                {
                    Console.WriteLine("Not a valid rover position, try again.");
                }
                else
                {
                    correctPositionInput = true;
                }
            }
            return positionInput;
        }
    }
}

using Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNasa
{
    public interface IRover
    {
        void SpinLeft();
        void SpinRight();
        void StepForward();
        string CurrentPosition(Rover rover);
    }
   public class Rover :IRover
    {
        public int x;
        public int y;
        public string direction;//todo:directionlar kontrol edilecek
        public Rover(string location, Plateau plateau)
        {
           Int32.TryParse( location.Split(" ")[0],out x);
           Int32.TryParse(location.Split(" ")[1], out y);
            direction = location.Split(" ")[2].ToUpper();
        }
        public void SpinLeft()
        {
            switch (direction)
            {
                case DirectionConstants.North:
                    direction = DirectionConstants.West;
                    break;
                case DirectionConstants.East:
                    direction = DirectionConstants.North;
                    break;
                case DirectionConstants.South:
                    direction = DirectionConstants.East;
                    break;
                case DirectionConstants.West:
                    direction = DirectionConstants.South;
                    break;
                default:
                    throw new ArgumentException();
            }
        }   
        public void SpinRight()
        {
            switch (direction)
            {
                case DirectionConstants.North:
                    direction = DirectionConstants.East;
                    break;
                case DirectionConstants.East:
                    direction = DirectionConstants.South;
                    break;
                case DirectionConstants.South:
                    direction = DirectionConstants.West;
                    break;
                case DirectionConstants.West:
                    direction = DirectionConstants.North;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void StepForward()
        {
            switch (direction)
            {
                case DirectionConstants.North:
                    y++;
                    break;
                case DirectionConstants.East:
                    x++;
                    break;
                case DirectionConstants.South:
                    y--;
                    break;
                case DirectionConstants.West:
                    x--;
                    break;
                default:
                    throw new ArgumentException();
            }
        }       
        public string CurrentPosition(Rover rover)
        {
            return rover.x + " " + rover.y + " " + rover.direction;
        }
    }
}

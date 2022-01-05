using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNasa
{
   public class Rover
    {
        public int x; // x coordinate of the current rover position
        public int y;// y coordinate of the current rover position
        public string direction;// cardional direction of the current rover position
        public Rover(string location)
        {
           Int32.TryParse( location.Split(" ")[0],out x);
           Int32.TryParse(location.Split(" ")[1], out y);
            direction = location.Split(" ")[2];
        }
        public void SpinLeft()
        {
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;
                default:
                    throw new ArgumentException();
            }
        }   
        public void SpinRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void StepForward()
        {
            switch (direction)
            {
                case "N":
                    y++;
                    break;
                case "E":
                    x++;
                    break;
                case "S":
                    y--;
                    break;
                case "W":
                    x--;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void Move(string roverCommand)
        {
            char[] intructions = roverCommand.ToCharArray();
            //loop throuh array . for each letter, call spinleft, spinright or stepforward 
            for (int i = 0; i < intructions.Length; i++)
            {
                switch (intructions[i])
                {
                    case 'L':
                        SpinLeft();
                        break;
                    case 'R':
                        SpinRight();
                        break;
                    case 'M':
                        StepForward();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}

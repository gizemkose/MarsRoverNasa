using Common.Constants;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//Mission Object:
//Rover: Position, location => (x,y,Z), where Z is letter as {N,E,W,S}
//Plato: grid object => (x,y,Z) , exm: (0,0,N) == bottom left corner ,facing North
//maximumCoordinates =>(maxX,maxY)
//Command : String, where L, R, M  => L=spinLeft, R=spinRight, M= moveForward
//Input = first line = grid size, eachRover(array) has 2 lines, 
// grid size: 5 5
// 1.rover position: 1 2 N
// 1.rover command:LMLMLMLMM
//2.rover position:3 3 E
//2.rover command MMRMMRMRRM

//Behaviors:
//1. Rover Should Spin Left
//2. Rover Should Spin Right
//3. Rover Should Move Forward
//4. Rover Should Go to "1 3 N"

//5.plateau's dimensions should be greater than 0
//TDD
namespace MarsRoverNasa
{
    class Program
    {
   
        static void Main(string[] args)
        {  
            Plateau plateau = new Plateau(PlateauInput());

            var addRover = true;
            var roverNumber = 1;
            while (addRover && roverNumber < int.MaxValue)
            {
              
                Rover rover = new Rover(RoverPositionInput(), plateau);
                rover.Move(RoverCommandInput());
                Console.WriteLine(roverNumber+ ". Rover Final Position: " + CurrentPosition(rover));
                roverNumber++;
            }
        }
        public static string CurrentPosition(Rover rover)
        {
            return rover.x + " " + rover.y + " " + rover.direction;
        }
        public static string PlateauInput()
        {
            var correctGridInput = false;
            string plateauSizeInput = string.Empty;
            int x;
            int y;
            while (!correctGridInput)
            {
                plateauSizeInput = Console.ReadLine();

                var gridInputControl = plateauSizeInput.Split(" ").Length == 2 && Int32.TryParse(plateauSizeInput.Split(" ")[0], out x) && Int32.TryParse(plateauSizeInput.Split(" ")[1], out y);
                if (!gridInputControl)
                {
                    Console.WriteLine("Not a valid size number for plateau, try again.");
                }
                else
                {
                    correctGridInput = true;
                }
            }
            return plateauSizeInput;
        }
        public static string RoverPositionInput()
        {
           
            var correctPositionInput = false;
            string positionInput = string.Empty;
            int x;
            int y;
            while (!correctPositionInput)
            {
                positionInput = Console.ReadLine();
               
                var inputControl =positionInput.Split(" ").Length == 3 && Int32.TryParse(positionInput.Split(" ")[0], out x) && Int32.TryParse(positionInput.Split(" ")[1], out y)  ;
                var directionControl = false;
                if (inputControl)
                {
                    var direction = positionInput.Split(" ")[2].ToUpper();
                     directionControl = direction == DirectionConstants.North || direction == DirectionConstants.South || direction == DirectionConstants.East || direction == DirectionConstants.West;//regexe çevir
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
        public static string RoverCommandInput()
        {
            var correctCommandInput = false;
            string commandInput = string.Empty;
            while (!correctCommandInput)
            {
                commandInput = Console.ReadLine();

                var inputControl = Regex.IsMatch(commandInput.ToUpper(),"["+CommandConstants.SpinLeftCommand+ CommandConstants.SpinRightCommand + CommandConstants.StepForwardCommand+"]+");
                if (!inputControl)
                {
                    Console.WriteLine("Not a valid command, try again.");
                }
                else
                {
                    correctCommandInput = true;
                }
            }
            return commandInput;
        }
    }
}

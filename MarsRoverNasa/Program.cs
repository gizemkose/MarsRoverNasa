using System;
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
            Plateau plateau = new Plateau("5 5");
            Rover roverOne = new Rover("1 2 N", plateau);
            roverOne.Move("LMLMLMLMM");
            Console.WriteLine(CurrentPosition(roverOne));

            Rover roverTwo = new Rover("3 3 E", plateau);
            roverTwo.Move("MMRMMRMRRM");
            Console.WriteLine(CurrentPosition(roverTwo));
        }
        public static string CurrentPosition(Rover rover)
        {
            return rover.x + " " + rover.y + " " + rover.direction;
        }
    }
}

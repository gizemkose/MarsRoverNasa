using Common.Constants;
using Common.ValidationServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace MarsRoverNasa
{
    class Program
    {   
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                                           .AddSingleton<PlateauInputService>()
                                           .AddSingleton<RoverCommandInputService>()
                                           .AddSingleton<RoverPositionInputService>()
                                           .AddScoped<RoverManagement>()
                                           .BuildServiceProvider();

            var plateauValidationService = serviceProvider.GetService<PlateauInputService>();
            var roverCommandValidationService = serviceProvider.GetService<RoverCommandInputService>();
            var roverPositionValidationService = serviceProvider.GetService<RoverPositionInputService>();
            var roverManagement = serviceProvider.GetService<RoverManagement>();

            Plateau plateau = new Plateau(plateauValidationService.PlateauInputValidation());

            var addRover = true;
            var roverNumber = 1;
            while (addRover && roverNumber < int.MaxValue)
            {              
                Rover rover = new Rover(roverPositionValidationService.RoverPositionInput(plateau.xSize,plateau.ySize), plateau);
                roverManagement.Move(roverCommandValidationService.RoverCommandInput(), rover, plateau);
                Console.WriteLine(roverNumber+ ". Rover Position: " + rover.CurrentPosition(rover));
                roverNumber++;
            }
        }
    }
}

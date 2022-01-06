using Common.Constants;
using MarsRoverNasa;
using System;
using Xunit;

namespace MarsRoverNasaTest
{
    public class RoverManagementShould
    {
        Plateau plateau = new Plateau("5 5");        
      
        public void Move()
        {
            Rover rover = new Rover("1 2 N", plateau);
            RoverManagement roverManagement = new RoverManagement();
            roverManagement.Move("LMLMLMLMM",rover,plateau);
            Assert.Equal("1 3 N", rover.x+ " " +rover.y +" "+ rover.direction);
        }
        [Fact]
        public void AvailableMovement()
        {
            Rover rover = new Rover("1 2 N", plateau);
            RoverManagement roverManagement = new RoverManagement();
           var available = roverManagement.AvailableMovement(rover, plateau);
            Assert.True(available);
        }
        [Fact]
        public void NotAvailableMovementNorth()
        {
            Rover rover = new Rover("2 5 N", plateau);
            RoverManagement roverManagement = new RoverManagement();
            var available = roverManagement.AvailableMovement(rover, plateau);
            Assert.False(available);
        }
        [Fact]
        public void NotAvailableMovementEast()
        {
            Rover rover = new Rover("5 2 E", plateau);
            RoverManagement roverManagement = new RoverManagement();
            var available = roverManagement.AvailableMovement(rover, plateau);
            Assert.False(available);
        }
        [Fact]
        public void NotAvailableMovementSouth()
        {
            Rover rover = new Rover("1 0 S", plateau);
            RoverManagement roverManagement = new RoverManagement();
            var available = roverManagement.AvailableMovement(rover, plateau);
            Assert.False(available);
        }
        [Fact]
        public void NotAvailableMovementWest()
        {
            Rover rover = new Rover("0 1 W", plateau);
            RoverManagement roverManagement = new RoverManagement();
            var available = roverManagement.AvailableMovement(rover, plateau);
            Assert.False(available);
        }
    }
}

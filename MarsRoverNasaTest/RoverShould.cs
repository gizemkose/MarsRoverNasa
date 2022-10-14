using Common.Constants;
using MarsRoverNasa;
using System;
using Xunit;

namespace MarsRoverNasaTest
{
    public class RoverShould
    {
        Plateau plateau = new Plateau("5 5");
        
        [Fact]
        public void SpinLeft()
        {
            Rover rover = new Rover("1 2 N", plateau);
            rover.SpinLeft();
            Assert.Equal(DirectionConstants.West, rover.direction);
        }
        [Fact]
        public void SpinRight()
        {
            Rover rover = new Rover("1 2 N", plateau);
            rover.SpinRight();
            Assert.Equal(DirectionConstants.East, rover.direction);
        }
        [Fact]
        public void StepForward()
        {
            Rover rover = new Rover("1 2 N", plateau);
            rover.StepForward();
            Assert.Equal(3, rover.y);
        }    
        [Fact]
        public void GetCurrentPosition()
        {
            Rover rover = new Rover("1 2 N", plateau);
           var positionStr = rover.CurrentPosition(rover);
            Assert.Equal(positionStr, rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}

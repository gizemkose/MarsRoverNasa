using MarsRoverNasa;
using System;
using Xunit;

namespace MarsRoverNasaTest
{
    public class RoverShould
    {
        [Fact]
        public void SpinLeft()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.SpinLeft();
            //assert
            Assert.Equal("W", rover.direction);
        }
        [Fact]
        public void SpinRight()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.SpinRight();
            //assert
            Assert.Equal("E", rover.direction);
        }
        [Fact]
        public void StepForward()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.StepForward();
            //assert
            Assert.Equal(3, rover.y);
        }
        [Fact]
        public void Move()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.Move("LMLMLMLMM");
            //assert
            Assert.Equal("1 3 N", rover.x+ " " +rover.y +" "+ rover.direction);
        }
    }
}

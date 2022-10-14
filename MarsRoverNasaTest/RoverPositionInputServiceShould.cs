using Common.ValidationServices;
using MarsRoverNasa;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRoverNasaTest
{
    public class RoverPositionInputServiceShould
    {
        Plateau plateau = new Plateau("5 5");

        [Fact]
        public void RoverPlacement()
        {
            Rover rover = new Rover("1 2 N", plateau);
            RoverPositionInputService inputService = new RoverPositionInputService();
            var available = inputService.RoverPlacement("1 2 N", plateau.xSize,plateau.ySize);
            Assert.True(available);
        }
        [Fact]
        public void Fail_RoverPlacement_By_OffTheGrid()
        {
            Rover rover = new Rover("1 2 N", plateau);
            RoverPositionInputService inputService = new RoverPositionInputService();
            var available = inputService.RoverPlacement("6 6 N", plateau.xSize, plateau.ySize);
            Assert.False(available);
        }
        [Fact]
        public void Pass_With_Correct_Input()
        {
            RoverPositionInputService inputService = new RoverPositionInputService();
            var available = inputService.InputControl("1 2 N");
            Assert.True(available);
        }
        [Fact]
        public void Fail_By_Null_Input()
        {
            RoverPositionInputService inputService = new RoverPositionInputService();
            var available = inputService.InputControl("");
            Assert.False(available);
        }
        [Fact]
        public void Fail_By_NotNumber_Input()
        {
            RoverPositionInputService inputService = new RoverPositionInputService();
            var available = inputService.InputControl("a a a");
            Assert.False(available);
        }
        [Fact]
        public void Pass_With_Correct_DirectionInput()
        {
            RoverPositionInputService inputService = new RoverPositionInputService();
            var available = inputService.DirectionControl("1 2 N");
            Assert.True(available);
        }
        [Fact]
        public void Fail_By_Null_DirectionInput()
        {
            RoverPositionInputService inputService = new RoverPositionInputService();
            var available = inputService.DirectionControl("1 2 ");
            Assert.False(available);
        }
        [Fact]
        public void Fail_By_NotListed_DirectionInput()
        {
            RoverPositionInputService inputService = new RoverPositionInputService();
            var available = inputService.DirectionControl("1 2 K");
            Assert.False(available);
        }
    }
}

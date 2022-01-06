using Common.ValidationServices;
using MarsRoverNasa;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRoverNasaTest
{
    public class RoverCommandInputServiceShould
    {      
        [Fact]
        public void InputControl()
        {
            RoverCommandInputService inputService = new RoverCommandInputService();
            var available = inputService.InputControl("LMLMLMLMM");
            Assert.True(available);
        }
        [Fact]
        public void InputControl_null()
        {
            RoverCommandInputService inputService = new RoverCommandInputService();
            var available = inputService.InputControl("");
            Assert.False(available);
        }
        [Fact]
        public void InputControl_NotListed()
        {
            RoverCommandInputService inputService = new RoverCommandInputService();
            var available = inputService.InputControl("LMLAAA");
            Assert.False(available);
        }     
    }
}

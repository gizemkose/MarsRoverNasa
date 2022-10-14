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
        public void Pass_With_CorrectInput()
        {
            RoverCommandInputService inputService = new RoverCommandInputService();
            var available = inputService.InputControl("LMLMLMLMM");
            Assert.True(available);
        }
        [Fact]
        public void Fail_By_NullInput()
        {
            RoverCommandInputService inputService = new RoverCommandInputService();
            var available = inputService.InputControl("");
            Assert.False(available);
        }
        [Fact]
        public void Fail_By_NotListedInput()
        {
            RoverCommandInputService inputService = new RoverCommandInputService();
            var available = inputService.InputControl("LMLAAA");
            Assert.False(available);
        }     
    }
}

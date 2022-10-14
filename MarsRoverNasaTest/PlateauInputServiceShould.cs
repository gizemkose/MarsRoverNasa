using Common.ValidationServices;
using MarsRoverNasa;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRoverNasaTest
{
    public class PlateauInputServiceShould
    {      
        [Fact]
        public void Pass_With_CorrectInput()
        {
            PlateauInputService inputService = new PlateauInputService();
            var available = inputService.InputControl("5 5");
            Assert.True(available);
        }
        [Fact]
        public void Fail_With_NullInput()
        {
            PlateauInputService inputService = new PlateauInputService();
            var available = inputService.InputControl("");
            Assert.False(available);
        }
        [Fact]
        public void Fail_With_NotNumberInput()
        {
            PlateauInputService inputService = new PlateauInputService();
            var available = inputService.InputControl("LMLAAA");
            Assert.False(available);
        }
        [Fact]
        public void Fail_With_OnlyOneNumberInput()
        {
            PlateauInputService inputService = new PlateauInputService();
            var available = inputService.InputControl("5");
            Assert.False(available);
        }
    }
}

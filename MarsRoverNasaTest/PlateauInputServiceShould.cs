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
        public void InputControl()
        {
            PlateauInputService inputService = new PlateauInputService();
            var available = inputService.InputControl("5 5");
            Assert.True(available);
        }
        [Fact]
        public void InputControl_null()
        {
            PlateauInputService inputService = new PlateauInputService();
            var available = inputService.InputControl("");
            Assert.False(available);
        }
        [Fact]
        public void InputControl_NotNumber()
        {
            PlateauInputService inputService = new PlateauInputService();
            var available = inputService.InputControl("LMLAAA");
            Assert.False(available);
        }
        [Fact]
        public void InputControl_OnlyOneNumber()
        {
            PlateauInputService inputService = new PlateauInputService();
            var available = inputService.InputControl("5");
            Assert.False(available);
        }
    }
}

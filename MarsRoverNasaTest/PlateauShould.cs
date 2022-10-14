using Common.Constants;
using MarsRoverNasa;
using System;
using Xunit;

namespace MarsRoverNasaTest
{
    public class PlateauShould
    {
        [Fact]
        public void Initialize_X_Dimension()
        {
            Plateau plateau = new Plateau("5 6");
            plateau.Initialize();
            Assert.Equal(5, plateau.xSize);           
        }
        [Fact]
        public void Initialize_Y_Dimension()
        {
            Plateau plateau = new Plateau("5 6");
            plateau.Initialize();
            Assert.Equal(6, plateau.ySize);
        }
    }
}

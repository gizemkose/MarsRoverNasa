using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNasa
{
    public class Plateau
    {
        public int xSize;
        public int ySize;
        public Plateau(string mapSize)
        {
            Int32.TryParse(mapSize.Split(" ")[0], out xSize);
            Int32.TryParse(mapSize.Split(" ")[1], out ySize);
        }

        public void Initialize()
        {
            if (xSize < 0 || xSize > int.MaxValue)
            {
                throw new ArgumentException();
            }
            else if (ySize < 0 || ySize > int.MaxValue)
            {
                throw new ArgumentException();
            }
        }
    }
}

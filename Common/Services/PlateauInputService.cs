using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ValidationServices
{
   public class PlateauInputService
    {
        public string PlateauInputValidation()
        {
            var correctGridInput = false;
            string plateauSizeInput = string.Empty;
            int x;
            int y;
            while (!correctGridInput)
            {
                plateauSizeInput = Console.ReadLine();

                var gridInputControl = plateauSizeInput.Split(" ").Length == 2 && Int32.TryParse(plateauSizeInput.Split(" ")[0], out x) && Int32.TryParse(plateauSizeInput.Split(" ")[1], out y);
                if (!gridInputControl)
                {
                    Console.WriteLine("Not a valid size number for plateau, try again.");
                }
                else
                {
                    correctGridInput = true;
                }
            }
            return plateauSizeInput;
        }
    }
}

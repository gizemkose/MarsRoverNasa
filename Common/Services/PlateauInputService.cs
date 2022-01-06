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
        
            while (!correctGridInput)
            {
                plateauSizeInput = Console.ReadLine();

               if (!InputControl(plateauSizeInput))
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
        public bool InputControl(string plateauSizeInput)
        {
            int x;
            int y;
            return plateauSizeInput.Split(" ").Length == 2 && Int32.TryParse(plateauSizeInput.Split(" ")[0], out x) && Int32.TryParse(plateauSizeInput.Split(" ")[1], out y);
        }
    }
}

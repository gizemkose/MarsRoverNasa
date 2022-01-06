using Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Common.ValidationServices
{
    public class RoverCommandInputService
    {
        public string RoverCommandInput()
        {
            var correctCommandInput = false;
            string commandInput = string.Empty;
            while (!correctCommandInput)
            {
                commandInput = Console.ReadLine();

                if (!InputControl(commandInput))
                {
                    Console.WriteLine("Not a valid command, try again.");
                }
                else
                {
                    correctCommandInput = true;
                }
            }
            return commandInput;
        }
        public bool InputControl(string commandInput)
        {
            if (commandInput == "")
            {
                return false;
            }
            return Regex.IsMatch(commandInput.ToUpper(), "^[" + CommandConstants.SpinLeftCommand + CommandConstants.SpinRightCommand + CommandConstants.StepForwardCommand + "]*$");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalFunctionality.TechnicalCodeFunctionality
{
    public  class Common
    {
        public string InputNewString()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            return inputString;
        }

        public int InputNewNumber()
        {
            Console.Write("Enter a number: ");
            string inputNumber = Console.ReadLine();
            return Convert.ToInt32(inputNumber);
        }
    }
}

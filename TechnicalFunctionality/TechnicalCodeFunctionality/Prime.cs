using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalFunctionality
{
    public class Prime
    {
        public int InputNumber { get; set; }

        public Prime(int inputNumber)
        {
            InputNumber = inputNumber;
        }

        /// <summary>
        /// Check if the input number is a prime number
        /// </summary>
        /// <returns>true = prime number / false = not prime number</returns>
        public bool isPrime()
        {
            if (InputNumber <= 1) { return false; }
            if (InputNumber == 2) { return true; }
            int numSqRt = (int)Math.Floor(Math.Sqrt(InputNumber));
            for (int i = 2; i <= numSqRt; i++)
            {
                if (numSqRt % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}

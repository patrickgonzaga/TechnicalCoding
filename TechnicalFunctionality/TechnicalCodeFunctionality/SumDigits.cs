using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalFunctionality.TechnicalCodeFunctionality
{
    public class SumDigits
    {
        public int UserNumber { get; set; }

        public SumDigits(int userNumber)
        {
            UserNumber = userNumber;
        }

        /// <summary>
        /// Add all digits of a number
        /// </summary>
        /// <returns>sum of all digits</returns>
        public int SumAllDigits()
        {
            int sum = 0;
            while (UserNumber > 0)
            {
                sum += UserNumber % 10;
                UserNumber /= 10;
            }
            return sum;
        }
    }
}

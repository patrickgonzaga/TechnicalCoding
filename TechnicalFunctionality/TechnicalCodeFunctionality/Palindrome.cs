using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalFunctionality
{
    public class Palindrome
    {
        public string InputString { get; set; }

        public Palindrome(string inputString)
        {
            InputString = inputString;
        }

        public bool CheckPalindrome()
        {
            StringReverse stringReverse = new StringReverse(InputString);
            string reverseString = stringReverse.ToReverse();
            return InputString == reverseString ? true : false;
        }
    }
}

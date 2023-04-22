using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalFunctionality
{
    /// <summary>
    /// This Class is to reverse a string
    /// </summary>
    public class StringReverse
    {
        public string InputString { get; set; }


        public StringReverse(string inputString)
        {
            InputString = inputString;  
        }

        /// <summary>
        /// This reverses a single string input from user
        /// </summary>
        /// <returns>A reverse string</returns>
        public string ToReverse(string stringToReverse = null)
        {
            string strToReverse = stringToReverse ?? InputString;
            string reversedString = new string(strToReverse.Reverse().ToArray());
            return reversedString;
        }

        /// <summary>
        /// This reverses words in a string input from user
        /// </summary>
        /// <returns>A reverse words</returns>
        public string WordsToReverse(string originalWords = null)
        {
            string[] strings = originalWords is null ? InputString.Split() : originalWords.Split();
            string words = "";
            foreach (string s in strings)
            {
                words = string.Concat(words, " ", ToReverse(s));
            }
            return words; 
        }

        static void Main(string[] args)
        {
        }
    }
}

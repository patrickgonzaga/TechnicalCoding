using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalFunctionality.TechnicalCodeFunctionality
{
    public class RemoveDuplicateCharacter
    {
        public string InputString { get; set; }

        public string OutputString;
        public RemoveDuplicateCharacter(string inputString) { 
            InputString = inputString;
            List<char> CharExists = new List<char>();
            char[] splitChar = InputString.ToCharArray();

            foreach (char c in splitChar) { 
                if (!CharExists.Contains(c)) { 
                    CharExists.Add(c);
                    OutputString += c;
                }
            }
        }

        public string DisplayOutputString()
        {
            return OutputString;
        }
    }
}

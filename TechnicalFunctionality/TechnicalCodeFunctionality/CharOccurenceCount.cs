using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalFunctionality
{
    public  class CharOccurenceCount
    {
        public string InputString { get; set; }
        public Dictionary<char, int> dictCharCount = new Dictionary<char, int>();

        public CharOccurenceCount(string inputString)
        {
            InputString = inputString.ToLower();
            string[] splitChar = InputString.Split();
            // Dictionary<char, int> dictCharCount = new Dictionary<char, int>();
            foreach (char c in InputString.ToCharArray())
            {
                if (dictCharCount is null)
                {
                    dictCharCount.Add(c, 1);
                }
                else if (dictCharCount.ContainsKey(c))
                {
                    dictCharCount[c]++;
                }
                else
                {
                    dictCharCount.Add(c, 1);
                }
            }
        }

        //public Dictionary<char, int> CountOccurence()
        //{ 
        //    string[] splitChar = InputString.Split();
        //    // Dictionary<char, int> dictCharCount = new Dictionary<char, int>();
        //    foreach (char c in InputString.ToCharArray())
        //    {
        //        if (dictCharCount.ContainsKey(c))
        //        {
        //            dictCharCount[c]++;
        //        }
        //        else
        //        {
        //            dictCharCount[c] = 1;
        //        }
        //    }
        //    return new Dictionary<char, int>(); 
        //} 

        public void DisplayCharOccurence()
        { 
            foreach (char c in dictCharCount.OrderBy(x => x.Key).Select(x => x.Key))
            {
                Console.WriteLine($"{c} : {dictCharCount[c]}");
            }
        }

    }
}

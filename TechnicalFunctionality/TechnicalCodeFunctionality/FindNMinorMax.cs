using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalFunctionality.TechnicalCodeFunctionality
{
    public class FindNMinorMax
    {
        public string UserString { get; set; }
        public List<int> IntArr { get; set; }

        public FindNMinorMax(string userString)
        { 
            UserString = userString;
            IntArr = UserString.Split().Select(x => int.Parse(x)).ToList();
        }

        public int GetNthArray(int number, bool High)
        {
            int nthNumber = !High ? IntArr.OrderBy(x => x).Take(number).OrderByDescending(x => x).First()
                            : IntArr.OrderByDescending(x => x).Take(number).OrderBy(x => x).First();
            return nthNumber;
        }


    }
}

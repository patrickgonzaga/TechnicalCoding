using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalFunctionality;
using System.Text.RegularExpressions;
using System.IO;
using TechnicalFunctionality.TechnicalCodeFunctionality;

namespace TechnicalCoding
{
    internal class MainMenu
    {
        static void Main(string[] args)
        {
            string mainMenuSelection = "";
            string subMenuSelection = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Please select a technical coding function from the following list." +
                                             "\n[1] Reverse a string" +
                                             "\n[2] Check Palindrome" +
                                             "\n[3] Reverse words");
                mainMenuSelection = Console.ReadLine();
                do
                {
                    if (Regex.IsMatch(mainMenuSelection, @"\d{1,2}") == true)
                    {
                        string userString;

                        switch (mainMenuSelection)
                        {
                            case "1": // Reverse String
                                userString = new Common().InputNewString();
                                StringReverse stringReverse = new StringReverse(userString);
                                Console.WriteLine($"The Reversed String is : {stringReverse.ToReverse(userString)}");
                                break;
                            case "2": // Check Palindrome
                                userString = new Common().InputNewString();
                                Palindrome palindrome = new Palindrome(userString);
                                Console.WriteLine($"Palindrome: {palindrome.CheckPalindrome()}");
                                break;
                            case "3": // Reverse Words
                                userString = new Common().InputNewString();
                                StringReverse stringWordsReverse = new StringReverse(userString);
                                Console.WriteLine($"Reverse Words: {stringWordsReverse.WordsToReverse()}");
                                break;
                            case "99":
                                Environment.Exit(0);
                                break;
                            default:
                                break;
                        }
                    }
                    Console.Write("Try again [Y/N]: ");
                    subMenuSelection = Console.ReadLine();
                }
                while (subMenuSelection == "Y");
            }
            while (mainMenuSelection != "99");
        }
    }
}

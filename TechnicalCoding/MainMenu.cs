using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalFunctionality;
using System.Text.RegularExpressions;
using System.IO;
using TechnicalFunctionality.TechnicalCodeFunctionality;
using System.Collections;

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
                                             "\n[3] Reverse words" +
                                             "\n[4] Count Character Occurence" +
                                             "\n[5] Remove Duplicate Character" +
                                             "\n[6] Get N/th Element using enumerator" +
                                             "\n[7] Check if Prime Number" +
                                             "\n[8] Sum all digits" +
                                             "\n[9] Get the Nth Highest Number" +
                                             "\n[10] Get the Nth Lowest Number" +
                                             "\n[99] Exit");
                mainMenuSelection = Console.ReadLine();
                do
                {
                    if (Regex.IsMatch(mainMenuSelection, @"\d{1,2}") == true)
                    {
                        string userString;
                        int userNumber;

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
                            case "4": // Count Character Occurence
                                userString = new Common().InputNewString();
                                CharOccurenceCount charOccurenceCount = new CharOccurenceCount(userString);
                                charOccurenceCount.DisplayCharOccurence();
                                break;
                            case "5": // Remove Duplicate Character
                                userString = new Common().InputNewString();
                                RemoveDuplicateCharacter removeDuplicateCharacter = new RemoveDuplicateCharacter(userString);
                                Console.WriteLine(removeDuplicateCharacter.DisplayOutputString());
                                break;
                            case "6": // Get Nth Element 
                                userNumber = new Common().InputNewNumber();
                                Books books = new Books();

                                IEnumerator enumerator = books.GetEnumerator();
                                for (int i = 0; i <= Convert.ToInt32(userNumber); i++)
                                {
                                    enumerator.MoveNext();
                                }
                                Authors authors = (Authors)enumerator.Current;
                                Console.WriteLine($"{authors.AuthorID} {authors.AuthorName} {authors.AuthorEmail}");
                                break;
                            case "7": // Check Prime Number
                                userNumber = new Common().InputNewNumber() ;
                                Prime prime = new Prime(Convert.ToInt32(userNumber));
                                bool isPrime = prime.isPrime();
                                Console.WriteLine($"Number {userNumber} Prime Number : {isPrime}"); 
                                break;
                            case "8": // Sum all digits
                                userNumber = new Common().InputNewNumber();
                                SumDigits sumDigits = new SumDigits(userNumber);
                                Console.WriteLine($"The sum of all digits is {sumDigits.SumAllDigits()}");
                                break;
                            case "9": // Find nth highest element 
                                userString = new Common().InputNewString();
                                userNumber = new Common().InputNewNumber();
                                FindNMinorMax findNMinorMax = new FindNMinorMax(userString);
                                Console.WriteLine(findNMinorMax.GetNthArray(userNumber, true));
                                break;
                           case "10": // Find nth lowest element
                                userString = new Common().InputNewString();
                                userNumber = new Common().InputNewNumber();
                                findNMinorMax = new FindNMinorMax(userString);
                                Console.WriteLine(findNMinorMax.GetNthArray(userNumber, false));
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

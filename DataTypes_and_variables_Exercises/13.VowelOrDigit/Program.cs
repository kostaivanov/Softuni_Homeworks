using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VowelOrDigit
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();

        int num = 0;
        if(int.TryParse(input, out num))
        {
            Console.WriteLine("Digit");
        }
        else
        {
            switch (input)
            {
                case "a": Console.WriteLine("Vowel");
                    break;
                case "e": Console.WriteLine("Vowel");
                    break;
                case "i": Console.WriteLine("Vowel");
                    break;
                case "o": Console.WriteLine("Vowel");
                    break;
                case "y": Console.WriteLine("Vowel");
                    break;
                case "u":
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }
    }
}
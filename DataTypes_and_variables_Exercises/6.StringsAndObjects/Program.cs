using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringsAndObjects
{
    static void Main()
    {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();
        object concatenation = firstWord + " " + secondWord;
        string greetings = concatenation.ToString();
        Console.WriteLine(greetings);

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Plural
{
    static void Main()
    {
        string pluralWord = Console.ReadLine();
        string newWord;

        bool wordY = pluralWord.EndsWith("y");
        bool wordZ = pluralWord.EndsWith("o") || pluralWord.EndsWith("ch") || pluralWord.EndsWith("s") ||
            pluralWord.EndsWith("sh") || pluralWord.EndsWith("x") || pluralWord.EndsWith("z");
        if (wordY == true)
        {
            newWord = pluralWord.Remove(pluralWord.Length - 1, 1);
            Console.WriteLine("{0}ies", newWord);
        }
        else if (wordZ == true)
        {
            Console.WriteLine("{0}es", pluralWord);
        }
        else
        {
            Console.WriteLine("{0}s", pluralWord);
        }
    }
}
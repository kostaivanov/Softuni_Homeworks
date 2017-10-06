using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntegerToHexAndBinary
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string hex = Convert.ToString(number, 16).ToUpper();
        string binary = Convert.ToString(number, 2).ToUpper();

        Console.WriteLine($"{hex}\n{binary}");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VarHexadecimalFormat
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine(), 16);
        Console.WriteLine(number);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DebitCardNumber
{
    static void Main()
    {
        decimal mile = 1.60934m;
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}", number * mile);
    }
}

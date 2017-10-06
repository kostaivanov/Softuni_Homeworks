using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SpaceInt
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int bigger = Math.Max(num1, num2);
        int smaller = Math.Min(num1, num2);
        if (num1 != num2 && num1 >= 0 && num1 <= 100 && num2 >= 0 && num2 <= 100)
        {
            for (int i = smaller; i <= bigger; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
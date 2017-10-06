using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FastPrimeCheckerRefactor
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 2; i <= number; i++)
{
            bool prime = true;
            for (int divisor = 2; divisor<=Math.Sqrt(i); divisor++)
{
                if (i % divisor == 0)
                {
                    prime = false;
                    break;
                }
            }
            Console.WriteLine($"{i} -> {prime}");
        }
    }
}

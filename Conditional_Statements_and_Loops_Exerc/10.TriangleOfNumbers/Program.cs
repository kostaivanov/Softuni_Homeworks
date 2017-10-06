using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Triangle
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {

            for (int j = 1; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
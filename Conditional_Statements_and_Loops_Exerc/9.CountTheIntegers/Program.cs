using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountIntegers
{
    static void Main()
    {

        int count = 0;
        try
        {
            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                count++;
            }
        }
        catch (Exception)
        {

            Console.WriteLine(count); ;
        }
    }
}
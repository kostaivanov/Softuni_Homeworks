using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Exercise
{
    static void Main()
    {
        string profession = Console.ReadLine();

        if (profession == "Athlete")
        {
            Console.WriteLine("Water");
        }
        else if (profession == "Businessman" || profession == "Businesswoman")
        {
            Console.WriteLine("Coffee");
        }
        else if (profession == "SoftUni Student")
        {
            Console.WriteLine("Beer");
        }
        else
        {
            Console.WriteLine("Tea");
        }
    }
}

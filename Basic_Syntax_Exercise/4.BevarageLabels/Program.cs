using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Exercise
{
    static void Main()
    {
        string name = Console.ReadLine();
        int volume = int.Parse(Console.ReadLine());
        int energyContent = int.Parse(Console.ReadLine());
        int sugarContent = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}ml {1}:", volume, name);
        Console.WriteLine("{0}kcal, {1}g sugars", energyContent * ((double)volume / 100), sugarContent * ((double)volume / 100));
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SpaceInt
{
    static void Main()
    {
        string input = Console.ReadLine();
        int numberIngredient = 0;
        while (input != "Bake!")
        {
            Console.WriteLine("Adding ingredient {0}.", input);
            input = Console.ReadLine();
            numberIngredient++;
        }

        Console.WriteLine("Preparing cake with {0} ingredients.", numberIngredient);


    }
}
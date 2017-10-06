using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CaloriesCOunter
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int calls = 0;

        for (int i = 0; i < num; i++)
        {
            string ingredient = Console.ReadLine().ToLower();
            if (ingredient == "cheese")
            {
                calls += 500;
            }
            if (ingredient == "tomato sauce")
            {
                calls += 150;
            }
            if (ingredient == "salami")
            {
                calls += 600;
            }
            if (ingredient == "pepper")
            {
                calls += 50;
            }
        }
        Console.WriteLine("Total calories: {0}", calls);
    }
}
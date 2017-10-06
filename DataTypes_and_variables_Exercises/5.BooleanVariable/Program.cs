using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BooleanVariable
{
    static void Main()
    {
        bool convertBool = Convert.ToBoolean(Console.ReadLine());
        if(convertBool)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
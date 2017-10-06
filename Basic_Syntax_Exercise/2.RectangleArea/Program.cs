using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DebitCardNumber
{
    static void Main()
    {
        float height = float.Parse(Console.ReadLine());
        float width = float.Parse(Console.ReadLine());

        Console.WriteLine("{0:F2}", height * width);
    }
}

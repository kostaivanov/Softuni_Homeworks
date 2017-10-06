using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AsciiTable
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        for (int i = startNum; i <= endNum; i++)
        {
            Console.Write((char)i + " ");
        }
        Console.WriteLine();

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExchangeVariableValues

{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine($"Before:\na = {a}\nb = {b}");
        int c = Math.Max(a, b);
        int d = Math.Min(a, b);
        Console.WriteLine($"After:\na = {c}\nb = {d}");

    }
}
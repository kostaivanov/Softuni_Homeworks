using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
class CenturiesToNanoseconds
{
    static void Main()
    {
        int century = int.Parse(Console.ReadLine());
        int years = century * 100;
        int days = (int)((double)years * 365.2422);
        int hours = days * 24;
        ulong minutes = (ulong)hours * 60;
        ulong seconds = minutes * 60;
        ulong milliseconds = seconds * 1000;
        BigInteger microseconds = BigInteger.Multiply(milliseconds, 1000);
        BigInteger nanoseconds = BigInteger.Multiply(microseconds, 1000);
        Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = " +
            $"{seconds} seconds = {milliseconds} milliseconds = {microseconds}" +
            $" microseconds = {nanoseconds} nanoseconds");
    }
}
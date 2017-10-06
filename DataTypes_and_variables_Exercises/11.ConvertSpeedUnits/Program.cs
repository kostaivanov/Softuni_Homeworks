using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ConvertSpeedUnits
{
    static void Main()
    {
        int distance = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());
        int secondsConverted = ((hours * 60) * 60 + minutes * 60 + seconds);
        float mPs = ((float)distance / (float)secondsConverted);
        double hoursConverted = ((double)((double)seconds/60) / 60 + ((double)minutes / 60) + hours);
        float kPh = (((float)distance / 1000) / (float)hoursConverted);
        float mPh = (float)((double)distance / (double)1609) / (float)hoursConverted;
        Console.WriteLine($"{mPs}\n{kPh}\n{mPh}");

    }
}
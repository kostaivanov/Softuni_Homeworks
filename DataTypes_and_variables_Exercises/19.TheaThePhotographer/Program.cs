using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TheaThePhotograhper
{
    static void Main()
    {
        int numPics = int.Parse(Console.ReadLine());
        long filterTime = long.Parse(Console.ReadLine());
        long filterFactor = long.Parse(Console.ReadLine());
        long uploadTime = long.Parse(Console.ReadLine());

        long totalFilteringTime = numPics * filterTime;
        long goodEnoughPics = (long)(Math.Ceiling(numPics * filterFactor / 100d));
        long totaluploadedPics = goodEnoughPics * uploadTime;


        long totalTime = totalFilteringTime + totaluploadedPics;
        TimeSpan projectTime = TimeSpan.FromSeconds(totalTime);
        Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", projectTime.Days, projectTime.Hours, projectTime.Minutes, projectTime.Seconds);

    }
}

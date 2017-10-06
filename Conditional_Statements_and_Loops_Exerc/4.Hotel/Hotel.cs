using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class hotel
{
    static void Main()
    {
        string month = Console.ReadLine();
        int nightsCount = int.Parse(Console.ReadLine());

        double discount = 0.0;
        double priceStudio = 0.0;
        double priceDouble = 0.0;
        double priceSuite = 0.0;


        switch (month)
        {
            case "May":
            case "October":
                priceStudio = 50;
                priceDouble = 65;
                priceSuite = 75;
                break;
            case "June":
            case "September":
                priceStudio = 60;
                priceDouble = 72;
                priceSuite = 82;
                break;
            case "July":
            case "August":
            case "December":
                priceStudio = 68;
                priceDouble = 77;
                priceSuite = 89;
                break;
            default:
                break;
        }

        if ((month == "May" || month == "October") && nightsCount > 7)
        {
            priceStudio *= 0.95;
        }
        else if ((month == "June" || month == "September") && nightsCount > 14)
        {
            priceDouble *= 0.90;
        }
        else if ((month == "July" || month == "August" || month == "December") && nightsCount > 14)
        {
            priceSuite *= 0.85;
        }

        double endPriceStudio = priceStudio * nightsCount;
        double endPriceDouble = priceDouble * nightsCount;
        double endPriceSuite = priceSuite * nightsCount;

        if ((month == "September" || month == "October") && nightsCount > 7)
        {
            endPriceStudio -= priceStudio;
        }
        Console.WriteLine("Studio: {0:F2} lv.", endPriceStudio);
        Console.WriteLine("Double: {0:F2} lv.", endPriceDouble);
        Console.WriteLine("Suite: {0:F2} lv.", endPriceSuite);

    }
}

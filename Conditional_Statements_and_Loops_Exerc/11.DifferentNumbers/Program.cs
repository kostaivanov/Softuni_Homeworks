﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DifferentNumbers
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        if (Math.Abs(num1 - num2) < 5)
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    for (int k = num1; k <= num2; k++)
                    {
                        for (int l = num1; l <= num2; l++)
                        {
                            for (int m = num1; m <= num2; m++)
                            {
                                if (j <= i || k <= j || l <= k || m <= l)
                                {
                                    continue;
                                }
                                else
                                {
                                    Console.Write(i + " ");
                                    Console.Write(j + " ");
                                    Console.Write(k + " ");
                                    Console.Write(l + " ");
                                    Console.WriteLine(m);

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
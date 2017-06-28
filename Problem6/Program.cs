using System;
using System.Collections.Generic;

namespace Problem6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            
            for (int first = 1; first <= 30; first++)
            {
                for (int second = 1; second <= 30; second++)
                {
                    for (int third = 1; third <= 30; third++)
                    {
                        if (first + second + third == n && first<second && second<third)
                        {
                            Console.WriteLine($"{first} + {second} + {third} = {n}");
                            counter++;
                        }
                        else if (first * second * third == n && first > second && second > third)
                        {
                            Console.WriteLine($"{first} * {second} * {third} = {n}");
                            counter++;

                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
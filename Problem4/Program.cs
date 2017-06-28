using System;
using System.Collections.Generic;

namespace Problem4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double prize = double.Parse(Console.ReadLine());

            var totalPoints = 0;
            for (int i = 1; i <= n; i++)
            {
                int points = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    points *= 2;
                }
                totalPoints += points;
            }
            double result = prize * totalPoints;
            Console.WriteLine("The project prize was {0:F2} lv.", result);
        }
    }
}
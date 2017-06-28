using System;
using System.Collections.Generic;

namespace Problem2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            //Console.WriteLine("============");
            var timeTotal = distance * time;
            //Console.WriteLine(timeTotal);
            
            var addedTime = Math.Floor(distance/15) *12.5;

            timeTotal += addedTime;
            //Console.WriteLine(addedTime);
            
            if (timeTotal >= record)
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", timeTotal - record);
            }
            else
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", timeTotal);
            }
        }
    }
}
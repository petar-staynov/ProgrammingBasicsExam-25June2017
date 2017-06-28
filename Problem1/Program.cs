using System;
using System.Collections.Generic;

namespace Problem1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double cakePrice = 45;
            double gofretprice = 5.80;
            double pancakeprice = 3.20;

            int time = int.Parse(Console.ReadLine());
            var workersAmount = int.Parse(Console.ReadLine());
            var cakesAmount = int.Parse(Console.ReadLine());
            var gofretiAmount = int.Parse(Console.ReadLine());
            var pancakesAmount = int.Parse(Console.ReadLine());
            
            //1/8 of price is lost
                
            double sum = cakePrice * cakesAmount + gofretprice * gofretiAmount + pancakeprice * pancakesAmount;
            sum *= workersAmount;
            sum *= time;
            sum -= sum / 8;
            
            
            Console.WriteLine("{0:F2}", sum);
            
        }
    }
}
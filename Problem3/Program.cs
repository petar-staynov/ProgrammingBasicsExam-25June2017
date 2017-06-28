using System;
using System.Collections.Generic;

namespace Problem3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            
            int amount = int.Parse(Console.ReadLine());

            double total = 0;

            int liters;
            switch (size)
            {
                case "small":
                    liters = 2;

                    switch (fruit)
                    {
                        case "Watermelon":
                        {
                            total = liters * 56.00 * amount;

                            break;
                        }
                        case "Mango":
                        {
                            total = liters * 36.66 * amount;

                            break;
                        }
                        case "Pineapple":
                            total = liters * 42.10 * amount;

                        {
                            break;
                        }
                        case "Raspberry":
                        {
                            total = liters * 20.00 * amount;

                            break;
                        }
                    }
                    break;
                    
                case "big":
                    liters = 5;

                    switch (fruit)
                    {
                        case "Watermelon":
                        {
                            total = liters * 28.70 * amount;

                            break;
                        }
                        case "Mango":
                        {
                            total = liters * 19.60 * amount;

                            break;
                        }
                        case "Pineapple":
                            total = liters * 24.80 * amount;

                        {
                            break;
                        }
                        case "Raspberry":
                        {
                            total = liters * 15.20 * amount;

                            break;
                        }
                    }
                    break;
            }

            if (total > 1000)
            {
                total -= total * 0.5;
            }
            else if (total <= 1000 && total >= 400)
            {
                total -= total * 0.15;
            }
            Console.WriteLine("{0:F2} lv.", total);

        }
    }
}
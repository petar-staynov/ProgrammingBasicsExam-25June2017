using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //int n = 2;

            int height = 2 * n + 1;
            int width = 4 * n + 1;


            //TOP first line
            var line = new StringBuilder()
                .Insert(0, "#", width)
                .ToString();
            Console.WriteLine(line);


            //MIDDLE
            int spaces = 1;
            int dots = 1;
            int hashtags = width / 2 + 1 - dots - spaces;

            for (int i = 0; i < n; i++)
            {
                if (i == Math.Floor((double) (n / 2)))
                {
                    line = new StringBuilder()
                        .Insert(0, ".", dots)
                        .Insert(0, "#", hashtags)
                        .Insert(0, " ", (spaces - 3) / 2)
                        .Insert(0, "(@)", 1)
                        .Insert(0, " ", (spaces - 3) / 2)
                        .Insert(0, "#", hashtags)
                        .Insert(0, ".", dots)
                        .ToString();
                    Console.WriteLine(line);
                }
                else
                {
                    line = new StringBuilder()
                        .Insert(0, ".", dots)
                        .Insert(0, "#", hashtags)
                        .Insert(0, " ", spaces)
                        .Insert(0, "#", hashtags)
                        .Insert(0, ".", dots)
                        .ToString();
                    Console.WriteLine(line);
                }


                dots++;
                spaces += 2;
                hashtags -= 2;
            }

            //BOTTOM
            hashtags = n * 2 - 1;
            for (int i = 0; i < n; i++)
            {
                line = new StringBuilder()
                    .Insert(0, ".", dots)
                    .Insert(0, "#", hashtags)
                    .Insert(0, ".", dots)
                    .ToString();
                Console.WriteLine(line);
                hashtags -= 2;
                dots++;
            }
        }
    }
}
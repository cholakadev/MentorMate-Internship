using System;

namespace MMLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int logoLength = n * 5;

            int logoHeight = n + 1;

            for (int i = 0; i < logoHeight / 2; i++)
            {
                for (int j = 0; j < logoLength + 1; j++)
                {
                    PrintFirstLine(j, n);

                    /* Depening on first line, print all the other lines 
                    by decreasing or increasing the amount of '-'/'*' */
                }
                Console.WriteLine();
            }
        }

        public static void PrintFirstLine(int index, int n)
        {
            if (index < n)
            {
                Console.Write('-');
            }

            else if (index > n && index <= 2 * n)
            {
                Console.Write('*');
            }

            else if (index > 2 * n && index <= 3 * n)
            {
                Console.Write('-');
            }

            else if (index > 3 * n && index <= 4 * n)
            {
                Console.Write('*');
            }

            else if (index > 4 * n && index <= 5 * n)
            {
                Console.Write('-');
            }
        }

        public static void PrintSecondLine()
        {

        }
    }
}

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
            int logoTopPartHeight = logoHeight / 2;

            for (int i = 0; i < logoTopPartHeight; i++)
            {
                for (int j = 0; j < logoLength + 1; j++)
                {
                    if (i == 0)
                    {
                        PrintFirstLine(j, n);
                    }

                    /* Depening on first line, print all the other lines 
                     * by decreasing or increasing the amount of '-'/'*' */
                    else
                    {
                        PrintNextLines(j, n, i);
                    }
                }
                Console.WriteLine();
            }
        }

        public static void PrintNextLines(int index, int n, int i)
        {
            if (index < n - i)
            {
                Console.Write('-');
            }
            else if (index > n - i && index <= 2 * n + i)
            {
                Console.Write('*');
            }
            else if (index > 2 * n - i && index <= 3 * n - i)
            {
                Console.Write('-');
            }

            else if (index > 3 * n - i && index <= 4 * n + i)
            {
                Console.Write('*');
            }

            else if (index > 4 * n +i && index <= 5 * n)
            {
                Console.Write('-');
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
    }
}

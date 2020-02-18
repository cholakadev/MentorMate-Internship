namespace MMLogo
{
    using System;
    public class BottomPart : Part
    {
        public BottomPart(int logoLength, int logoHeight, int size)
            : base(logoLength, logoHeight, size)
        {
        }

        public override void PrintFirstLine(int j, int n)
        {
            if (j > 0 && j <= n - j - 1)
            {
                Console.Write('-');
            }

            else if (j > n - j - 1 && j <= n - j - 1 + 2 * n)
            {
                Console.Write('*');
            }

            else if (j > n - j - 1 + 2 * n && j <= n - j + 1 + 2 * n)
            {
                Console.Write('-');
            }

            else if (j > n - j + 1 + 2 * n && j <= n - j + 1 + 6 * n - 1)
            {
                Console.Write('*');
            }

            else if (j > n - j + 1 + 6 * n - 1 && j <= n - j + 1 + 6 * n)
            {
                Console.Write('-');
            }

            else if (j > n - j + 1 + 6 * n && j <= n - j + 1 + 6 * n + 2 * n)
            {
                Console.Write('*');
            }

            else if (j > n - j + 1 + 6 * n + 2 * n && j <= n - j + 1 + 6 * n + 2 * n + j)
            {
                Console.Write('-');
            }
        }

        public override void PrintNextLines(int j, int n, int i)
        {
            if (j > 5 * n + i && j <= 6 * n + i + 1)
            {
                Console.Write('-');
            }

            //else if (length > )
        }
    }
}

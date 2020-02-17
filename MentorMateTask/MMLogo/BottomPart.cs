namespace MMLogo
{
    using System;
    public class BottomPart : Part
    {
        public BottomPart(int logoLength, int logoHeight, int size)
            : base(logoLength, logoHeight, size)
        {
        }

        public override void PrintFirstLine(int i, int n)
        {
            if (i > 0 && i <= n - i - 1)
            {
                Console.Write('-');
            }

            else if (i > n - i - 1 && i <= n - i - 1 + 2 * n)
            {
                Console.Write('*');
            }

            else if (i > n - i - 1 + 2 * n && i <= n - i + 1 + 2 * n)
            {
                Console.Write('-');
            }

            else if (i > n - i + 1 + 2 * n && i <= n - i + 1 + 6 * n - 1)
            {
                Console.Write('*');
            }

            else if (i > n - i + 1 + 6 * n - 1 && i <= n - i + 1 + 6 * n)
            {
                Console.Write('-');
            }

            else if (i > n - i + 1 + 6 * n && i <= n - i + 1 + 6 * n + 2 * n)
            {
                Console.Write('*');
            }

            else if (i > n - i + 1 + 6 * n + 2 * n && i <= n - i + 1 + 6 * n + 2 * n + i)
            {
                Console.Write('-');
            }
        }

        public override void PrintNextLines(int jIndex, int size, int iIndex)
        {

        }
    }
}

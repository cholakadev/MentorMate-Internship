namespace MMLogo
{
    using System;
    public class TopPart : Part
    {
        public TopPart(int logoLength, int logoHeight, int size)
            : base(logoLength, logoHeight, size)
        {
        }

        public override void PrintFirstLine(int j, int size)
        {
            if (j < size)
            {
                Console.Write('-');
            }

            else if (j > size && j <= 2 * size)
            {
                Console.Write('*');
            }

            else if (j > 2 * size && j <= 3 * size)
            {
                Console.Write('-');
            }

            else if (j > 3 * size && j <= 4 * size)
            {
                Console.Write('*');
            }

            else if (j > 4 * size && j <= 5 * size)
            {
                Console.Write('-');
            }
        }

        public override void PrintNextLines(int j, int size, int i)
        {
            if (j < size - i)
            {
                Console.Write('-');
            }
            else if (j > size - i && j <= 2 * size + i)
            {
                Console.Write('*');
            }
            else if (j > 2 * size - i && j <= 3 * size - i)
            {
                Console.Write('-');
            }

            else if (j > 3 * size - i && j <= 4 * size + i)
            {
                Console.Write('*');
            }

            else if (j > 4 * size + i && j <= 5 * size)
            {
                Console.Write('-');
            }
        }
    }
}

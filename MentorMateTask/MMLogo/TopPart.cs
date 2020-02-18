namespace MMLogo
{
    using System;
    public class TopPart : Part
    {
        public TopPart(int logoLength, int logoHeight, int size)
            : base(logoLength, logoHeight, size)
        {
        }

        public override void PrintFirstLine(int jIndex, int size)
        {
            if (jIndex < size)
            {
                Console.Write('-');
            }

            else if (jIndex > size && jIndex <= 2 * size)
            {
                Console.Write('*');
            }

            else if (jIndex > 2 * size && jIndex <= 3 * size)
            {
                Console.Write('-');
            }

            else if (jIndex > 3 * size && jIndex <= 4 * size)
            {
                Console.Write('*');
            }

            else if (jIndex > 4 * size && jIndex <= 5 * size)
            {
                Console.Write('-');
            }
        }

        public override void PrintNextLines(int jIndex, int size, int iIndex)
        {
            if (jIndex < size - iIndex)
            {
                Console.Write('-');
            }
            else if (jIndex > size - iIndex && jIndex <= 2 * size + iIndex)
            {
                Console.Write('*');
            }
            else if (jIndex > 2 * size - iIndex && jIndex <= 3 * size - iIndex)
            {
                Console.Write('-');
            }

            else if (jIndex > 3 * size - iIndex && jIndex <= 4 * size + iIndex)
            {
                Console.Write('*');
            }

            else if (jIndex > 4 * size + iIndex && jIndex <= 5 * size)
            {
                Console.Write('-');
            }
        }
    }
}

using System;

namespace MMLogo
{
    public class TopPart : IPart
    {
        public TopPart(int logoLength, int logoHeight, int size)
        {
            this.LogoLength = logoLength;
            this.LogoHeight = logoHeight;
            this.Size = size;
        }

        public int LogoLength { get; set; }
        public int LogoHeight { get; set; }
        public int Size { get; set; }

        public void PrintFirstLine(int iIndex, int size)
        {
            if (iIndex < size)
            {
                Console.Write('-');
            }

            else if (iIndex > size && iIndex <= 2 * size)
            {
                Console.Write('*');
            }

            else if (iIndex > 2 * size && iIndex <= 3 * size)
            {
                Console.Write('-');
            }

            else if (iIndex > 3 * size && iIndex <= 4 * size)
            {
                Console.Write('*');
            }

            else if (iIndex > 4 * size && iIndex <= 5 * size)
            {
                Console.Write('-');
            }
        }

        public void PrintNextLines(int jIndex, int size, int iIndex)
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

namespace MMLogo
{
    using System;
    public class BottomPart : Part
    {
        public BottomPart(int logoLength, int logoHeight, int size)
            : base(logoLength, logoHeight, size)
        {
        }

        public override void PrintFirstLine(int i, int size)
        {
            if (i > 0 && i <= size - i - 1)
            {
                Console.Write('-');
            }

            else if (i > size - i - 1 && i <= size - i - 1 + 2 * size)
            {
                Console.Write('*');
            }

            else if (i > size - i - 1 + 2 * size && i <= size - i + 1 + 2 * size)
            {
                Console.Write('-');
            }

            else if (i > size - i + 1 + 2 * size && i <= size - i + 1 + 6 * size - 1)
            {
                Console.Write('*');
            }

            else if (i > size - i + 1 + 6 * size - 1 && i <= size - i + 1 + 6 * size + 1)
            {
                Console.Write('-');
            }

        }

        public override void PrintNextLines(int jIndex, int size, int iIndex)
        {

        }
    }
}

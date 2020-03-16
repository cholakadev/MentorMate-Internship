namespace MMLogo
{
    using System;
    public class BottomPart : Part
    {
        public BottomPart(int logoLength, int logoHeight, int size)
            : base(logoLength, logoHeight, size)
        {
        }

        public override void PrintFirstLine(int row, int size)
        {
            if (row < size)
            {
                Console.Write('*');
            }

            else if (row > size && row <= 2 * size)
            {
                Console.Write('-');
            }

            else if (row > 2 * size && row <= 3 * size)
            {
                Console.Write('*');
            }

            else if (row > 3 * size && row <= 4 * size)
            {
                Console.Write('-');
            }

            else if (row > 4 * size && row <= 5 * size)
            {
                Console.Write('*');
            }
        }

        public override void PrintNextLines(int row, int size, int col)
        {
            // row ++, col --

            //if ()
            //{
            //    Console.Write('-');
            //}
        }
    }
}

namespace MMLogo
{
    using System;
    public class Print
    {
        public void PrintPart(IPart part)
        {
            for (int i = 0; i < part.LogoHeight / 2; i++)
            {
                for (int j = 0; j < part.LogoLength + 1; j++)
                {
                    if (i == 0)
                    {
                        PrintFirstLine(j, part.Size);
                    }

                    /* Depening on first line, print all the other lines 
                     * by decreasing or increasing the amount of '-'/'*' */
                    else
                    {
                        PrintNextLines(j, part.Size, i);
                    }
                }
                Console.WriteLine();
            }
        }

        private void PrintFirstLine(int iIndex, int size)
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

        private void PrintNextLines(int jIndex, int size, int iIndex)
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

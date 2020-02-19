namespace MMLogo
{
    using System;
    public class Print
    {
        public void PrintTopPart(IPart part)
        {
            for (int col = 0; col < part.LogoHeight / 2; col++)
            {
                for (int row = 0; row < part.LogoLength + 1; row++)
                {
                    if (row == 0)
                    {
                        part.PrintFirstLine(row, part.Size);
                    }

                    /* Depening on first line, print all the other lines 
                     * by decreasing or increasing the amount of '-'/'*' */
                    else
                    {
                        part.PrintNextLines(row, part.Size, col);
                    }
                }
                Console.WriteLine();
            }
        }

        public void PrintBottomPart(IPart part)
        {
            for (int col = 0; col < part.LogoHeight / 2; col++)
            {
                for (int row = 0; row < part.LogoLength + 1; row++)
                {
                    if (col == part.Size / 2)
                    {
                        part.PrintFirstLine(row, part.Size);
                    }

                    else
                    {
                        part.PrintNextLines(row, part.Size, col);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

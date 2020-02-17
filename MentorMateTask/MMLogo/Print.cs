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
                        part.PrintFirstLine(j, part.Size);
                    }

                    /* Depening on first line, print all the other lines 
                     * by decreasing or increasing the amount of '-'/'*' */
                    else
                    {
                        part.PrintNextLines(j, part.Size, i);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

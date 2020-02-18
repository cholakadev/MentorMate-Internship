namespace MMLogo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows * 5;


            StringBuilder sb = new StringBuilder();

            for (int row = 0; row <= rows; row++)
            {
                List<char> line = new List<char>();
                for (int col = 0; col < cols; col++)
                {
                    if (FirstCheck(rows, row, col)
                        || SecondCheck(rows, row, col)
                        || ThirdCheck(rows, row, col)
                        || FourthCheck(rows, row, col))
                    {
                        line.Add('*');
                    }
                    else
                    {
                        line.Add('-');
                    }
                }

                sb.Append(string.Join("", line));
                sb.Append(string.Join("", line));
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        public static bool FirstCheck(int rows, int currentRow, int currentCol)
        {
            int index = rows - 1 - currentRow;
            if (currentCol > index && currentCol <= index + rows)
            {
                return true;
            }

            return false;
        }

        public static bool SecondCheck(int rows, int currentRow, int currentCol)
        {
            int index = rows - 1 + currentRow;
            if (currentCol > index && currentCol <= index + rows)
            {
                return true;
            }

            return false;
        }

        public static bool ThirdCheck(int rows, int currentRow, int currentCol)
        {
            int index = 3 * rows - 1 - currentRow;
            if (currentCol > index && currentCol <= index + rows)
            {
                return true;
            }

            return false;
        }

        public static bool FourthCheck(int rows, int currentRow, int currentCol)
        {
            int index = 3 * rows - 1 + currentRow;
            if (currentCol > index && currentCol <= index + rows)
            {
                return true;
            }

            return false;
        }
    }
}
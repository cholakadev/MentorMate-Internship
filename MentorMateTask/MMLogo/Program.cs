namespace MMLogo
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int logoLength = size * 5;

            int logoHeight = size + 1;

            TopPart topPart = new TopPart(logoLength, logoHeight, size);

            Print print = new Print();      
            print.PrintPart(topPart);

            BottomPart bottomPart = new BottomPart(logoLength, logoHeight, size);

            print.PrintPart(bottomPart);
        }
    }
}
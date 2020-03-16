namespace MMLogo
{
    public abstract class Part : IPart
    {
        public Part(int logoLength, int logoHeight, int size)
        {
            this.LogoLength = logoLength;
            this.LogoHeight = logoHeight;
            this.Size = size;
        }

        public int LogoLength { get; set; }
        public int LogoHeight { get; set; }
        public int Size { get; set; }


        public abstract void PrintFirstLine(int iIndex, int size);
        public abstract void PrintNextLines(int jIndex, int size, int iIndex);
    }
}
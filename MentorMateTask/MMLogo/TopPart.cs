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
    }
}

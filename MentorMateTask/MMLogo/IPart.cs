namespace MMLogo
{
    public interface IPart : IFirstLinePrinter, IRestLinesPrinter
    {
        int LogoLength { get; set; }
        int LogoHeight { get; set; }
        int Size { get; set; }
    }
}

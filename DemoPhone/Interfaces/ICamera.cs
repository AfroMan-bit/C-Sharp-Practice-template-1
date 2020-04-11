namespace DemoPhone.Interfaces
{
    public interface ICamera
    {
        int LensCount {get; set;}
        string Snap();
    }
}
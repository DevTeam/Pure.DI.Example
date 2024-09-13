// Entry point

new Composition().Root.Run();

internal partial class Program(
    IOutput output,
    IInput input,
    IBox<ICat> boxWithCat)
{
    private void Run()
    {
        output.WriteLine(boxWithCat);
        output.WriteLine("Press the Enter key to exit.");
        input.ReadLine();
    }
}
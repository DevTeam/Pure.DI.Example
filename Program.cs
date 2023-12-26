// Entry point
new Composition().Root.Run();

internal partial class Program(IBox<ICat> box)
{
    private void Run() => Console.WriteLine(box);
}
// Entry point
new Composition().Root.Run();

internal partial class Program
{
    private readonly IBox<ICat> _box;

    internal Program(IBox<ICat> box) => _box = box;

    private void Run() => Console.WriteLine(_box);
}
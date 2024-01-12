// Entry point

using Pure.DI;

new Composition().Root.Run();

partial class Program(
    // Simple injections
    IInput input,
    IOutput output,
    IBox<ICat> box,
    // Tagged injection
    [Tag("Wrapper")] IBox<ICat> wrapper,
    // Enumeration injection
    IEnumerable<IBox<ICat>> boxes,
    // Tagged factory injection
    [Tag("Black")] Func<IBox<ICat>> blackBoxFactory,
    // Factory enumeration injection
    Func<IEnumerable<IBox<ICat>>> boxesFactory)
{
    // Property injection
    public required IBox<ICat> Box { get; init; }
    
    // Tagged property injection
    [Tag("Black")]
    public required IBox<ICat> BlackBox { get; init; }
    
    private void Run()
    {
        output.WriteLine("#1");
        output.WriteLine(box.ToString());
        output.WriteLine(wrapper.ToString());
        output.WriteLine();
        
        output.WriteLine("#2");
        foreach (var box in boxes)
        {
            output.WriteLine(box.ToString());
        }
        output.WriteLine();

        output.WriteLine("#3");
        for (var i = 0; i < 5; i++)
        {
            var blackBox = blackBoxFactory();
            output.WriteLine(blackBox.ToString());
        }
        output.WriteLine();

        output.WriteLine("#4");
        for (var i = 0; i < 2; i++)
        {
            foreach (var box in boxesFactory())
            {
                output.WriteLine(box.ToString());
            }
        }
        output.WriteLine();
        
        output.WriteLine("#5");
        output.WriteLine(Box.ToString());
        output.WriteLine(BlackBox.ToString());
        output.WriteLine();

        output.WriteLine("Press the Enter key to exit.");
        input.ReadLine();
    }
}
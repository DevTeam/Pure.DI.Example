using System.Text;

namespace Pure.DI.Example;

internal class ConsoleAdapter : IInput, IOutput
{
    public ConsoleAdapter() => Console.OutputEncoding = Encoding.UTF8;

    public string? ReadLine() => Console.ReadLine();

    public void WriteLine(object? line) => Console.WriteLine(line);
}
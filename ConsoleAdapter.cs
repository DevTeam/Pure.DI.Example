using System.Text;

namespace Pure.DI.Example;

class ConsoleAdapter: IInput, IOutput
{
    public ConsoleAdapter() => Console.OutputEncoding = Encoding.UTF8;

    public string? ReadLine() => Console.ReadLine();

    public void WriteLine(string? line) => Console.WriteLine(line);
}
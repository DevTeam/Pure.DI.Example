namespace Pure.DI.Example;

internal class BlackBox<T>(T content) : IBox<T>
{
    public T Content { get; } = content;

    public override string ToString() => $"Black     [{Content}]";
}
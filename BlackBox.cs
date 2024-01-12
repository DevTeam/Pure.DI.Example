namespace Pure.DI.Example;

class BlackBox<T>(T content) : IBox<T>
{
    public T Content { get; } = content;

    public override string ToString() => $"Black     [{Content}]";
}
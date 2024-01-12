namespace Pure.DI.Example;

class CardboardBox<T>(T content) : IBox<T>
{
    public T Content { get; } = content;

    public override string ToString() => $"Cardboard [{Content}]";
}
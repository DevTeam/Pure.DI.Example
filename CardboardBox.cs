namespace Pure.DI.Example;

internal class CardboardBox<T>(T content) : IBox<T>
{
    public T Content { get; } = content;

    public override string ToString() => $"[{Content}]";
}
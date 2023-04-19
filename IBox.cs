namespace Pure.DI.Example;

internal interface IBox<out T>
{
    T Content { get; }
}
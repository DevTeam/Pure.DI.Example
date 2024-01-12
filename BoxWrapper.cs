namespace Pure.DI.Example;

class BoxWrapper<T>(IBox<T> box): IBox<T>
{
    public T Content => box.Content;
    
    public override string ToString() => $"Wrapper   [{box}]";
}
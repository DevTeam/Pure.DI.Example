// ReSharper disable UnusedMemberInSuper.Global
namespace Pure.DI.Example;

interface IBox<out T>
{
    T Content { get; }
}
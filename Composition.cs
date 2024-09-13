using static Pure.DI.Lifetime;

namespace Pure.DI.Example;

internal partial class Composition
{
    // In fact, this code is never run, and the method can have any name or be a constructor, for example,
    // and can be in any part of the compiled code because this is just a hint to set up an object graph.
    private void Setup() => DI.Setup()
        .Bind().As(Singleton).To<ConsoleAdapter>()
        // Represents a quantum superposition of 2 states: Alive or Dead
        .Bind().To((Random random) => (State)random.Next(2))
        .Bind().To<ShroedingersCat>()
        .Bind().To<CardboardBox<TT>>()
        // Composition Root (https://blog.ploeh.dk/2011/07/28/CompositionRoot/)
        .Root<Program>(nameof(Root));
}
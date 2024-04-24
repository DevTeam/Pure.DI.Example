using static Pure.DI.Lifetime;

namespace Pure.DI.Example;

internal partial class Composition
{
    // [Conditional("DI")] attribute avoids generating IL code for the method that follows it.
    // Since this method is needed only at the compile time.
    [Conditional("DI")]
    private static void Setup() =>
        // In fact, this code is never run, and the method can have any name or be a constructor, for example,
        // and can be in any part of the compiled code because this is just a hint to set up an object graph.
        DI.Setup(nameof(Composition))
            .Bind().As(Singleton).To<ConsoleAdapter>()
            // Models a random subatomic event that may or may not occur
            .Bind().As(Singleton).To<Random>()
            // Represents a quantum superposition of 2 states: Alive or Dead
            .Bind().To(ctx =>
            {
                ctx.Inject<Random>(out var random);
                return (State)random.Next(2);
            })
            // Represents schrodinger's cat
            .Bind().To<ShroedingersCat>()
            // Represents a cardboard box with any content
            .Bind().To<CardboardBox<TT>>()
            // Represents another box with whatever contents you want to keep
            .Bind("Black").To<BlackBox<TT>>()
            // Provides a black box wrapper
            .Bind("Wrapper").To<BoxWrapper<TT>>()
            // Composition Root (https://blog.ploeh.dk/2011/07/28/CompositionRoot/)
            .Root<Program>("Root");
}
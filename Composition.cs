using System.Diagnostics;
using static Pure.DI.Lifetime;
// ReSharper disable UnusedMember.Local

namespace Pure.DI.Example;

internal partial class Composition
{
    // [Conditional("DI")] attribute avoids generating IL code for the method that follows it.
    // Since this method is needed only at the compile time.
    [Conditional("DI")]
    private static void Setup() =>
        // In fact, this code is never run, and the method can have any name or be a constructor, for example,
        // and can be in any part of the compiled code because this is just a hint to set up an object graph.
        // Resolve = Off
        // ThreadSafe = Off
        // FormatCode = On
        DI.Setup(nameof(Composition))
            // Models a random subatomic event that may or may not occur
            .Bind<Random>().As(Singleton).To<Random>()
            // Represents a quantum superposition of 2 states: Alive or Dead
            .Bind<State>().To(ctx =>
            {
                ctx.Inject<Random>(out var random);
                return (State)random.Next(2);
            })
            // Represents schrodinger's cat
            .Bind<ICat>().To<ShroedingersCat>()
            // Represents a cardboard box with any content
            .Bind<IBox<TT>>().To<CardboardBox<TT>>()
            // Composition Root (https://blog.ploeh.dk/2011/07/28/CompositionRoot/)
            .Root<Program>("Root");
}

// The generated code can be found in the folder `./obj/Generated/Pure.DI/Pure.DI.SourceGenerator`.
// https://github.com/DevTeam/Pure.DI#troubleshooting
namespace Pure.DI.Example;

internal class ShroedingersCat : ICat
{
    // Represents the superposition of the states
    private readonly Lazy<State> _superposition;

    public ShroedingersCat(Lazy<State> superposition) => _superposition = superposition;

    // The decoherence of the superposition at the time of observation via an irreversible process
    public State State => _superposition.Value;

    public override string ToString() => $"{State} cat";
}
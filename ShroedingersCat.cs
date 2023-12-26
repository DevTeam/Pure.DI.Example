namespace Pure.DI.Example;

internal class ShroedingersCat(
    // Represents the superposition of the states
    Lazy<State> superposition)
    : ICat
{
    // The decoherence of the superposition
    // at the time of observation via an irreversible process
    public State State => superposition.Value;

    public override string ToString() => $"{State} cat";
}
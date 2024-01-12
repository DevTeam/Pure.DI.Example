namespace Pure.DI.Example;

class ShroedingersCat(Lazy<State> superposition) : ICat
{
    // The decoherence of the superposition
    // at the time of observation via an irreversible process
    public State State => superposition.Value;

    public override string ToString() => 
        State switch
        {
            State.Alive => "😺",
            State.Dead => "🦴"
        };
}
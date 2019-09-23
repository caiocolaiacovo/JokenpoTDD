namespace JokenpoTDD
{
    public interface IJogada
    {
        string Nome { get; }
        string NomeDaJogadaQueVenceEsta { get; }
        bool GanhaDe(IJogada jogada);
    }
}
namespace JokenpoTDD
{
    public interface IJogada
    {
        string Nome { get; }
        bool GanhaDe(IJogada jogada2);
    }
}
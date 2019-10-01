namespace JokenpoTDD
{
    public class Pedra : IJogada
    {
        public bool GanhaDe(IJogada jogada)
        {
            return jogada is Tesoura;
        }
    }
}
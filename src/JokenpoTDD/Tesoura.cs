namespace JokenpoTDD
{
    public class Tesoura : IJogada
    {
        public bool GanhaDe(IJogada jogada)
        {
            return jogada is Papel;
        }
    }
}
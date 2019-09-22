namespace JokenpoTDD
{
    public class Pedra : IJogada
    {
        public string Nome => "Pedra";

        public Pedra()
        {
        }

        public bool GanhaDe(IJogada jogada)
        {
            if (jogada.Nome.Equals("Tesoura"))
                return true;

            return false;
        }
    }
}
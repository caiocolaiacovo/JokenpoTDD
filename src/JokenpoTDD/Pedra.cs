namespace JokenpoTDD
{
    public class Pedra : IJogada
    {
        public string Nome => "Pedra";

        public string NomeDaJogadaQueVenceEsta => throw new System.NotImplementedException();

        public Pedra()
        {
        }

        public bool GanhaDe(IJogada jogada)
        {
            return jogada.Nome.Equals("Tesoura");
        }
    }
}
namespace JokenpoTDD
{
    public class Tesoura : IJogada
    {
        public string Nome => "Tesoura";

        public string NomeDaJogadaQueVenceEsta => throw new System.NotImplementedException();

        public Tesoura()
        {
        }

        public bool GanhaDe(IJogada jogada)
        {
            return jogada.Nome.Equals("Papel");
        }
    }
}
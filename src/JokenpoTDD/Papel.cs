using System;

namespace JokenpoTDD
{
    public class Papel : IJogada
    {
        public string NomeDaJogadaQueVenceEsta => nameof(Pedra);

        public string Nome => throw new System.NotImplementedException();

        public Papel()
        {
        }

        public bool GanhaDe(IJogada jogada)
        {
            Console.Write(nameof(jogada));
            return nameof(jogada).Equals(NomeDaJogadaQueVenceEsta);
        }
    }
}
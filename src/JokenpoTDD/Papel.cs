using System;

namespace JokenpoTDD
{
    public class Papel : IJogada
    {
        public bool GanhaDe(IJogada jogada)
        {
            return jogada is Pedra;
        }
    }
}
namespace JokenpoTDD
{
    public class Juiz
    {
        public string ObterVencedor(IJogada jogada1, IJogada jogada2)
        {
            var jogada1Ganhou = jogada1.GanhaDe(jogada2);

            if(jogada1Ganhou)
                return jogada1.Nome;

            return jogada2.GanhaDe(jogada1) ? jogada2.Nome : "Empate";
        }
    }
}
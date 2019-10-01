using Moq;
using Xunit;

namespace JokenpoTDD.Teste
{
    public class PedraTeste
    {
        [Fact]
        public void Deve_ser_uma_jogada()
        {
            var jogada = new Pedra();

            Assert.True(jogada is IJogada);
        }

        [Fact]
        public void Deve_ganhar_de_tesoura()
        {
            var jogada = new Pedra();
            var tesoura = new Tesoura();

            var ganhou = jogada.GanhaDe(tesoura);

            Assert.True(ganhou);
        }

        [Fact]
        public void Nao_deve_ganhar_de_pedra()
        {
            var jogada = new Pedra();
            var pedra = new Pedra();

            var ganhou = jogada.GanhaDe(pedra);

            Assert.False(ganhou);
        }

        [Fact]
        public void Nao_deve_ganhar_de_papel()
        {
            var jogada = new Pedra();
            var papel = new Papel();

            var ganhou = jogada.GanhaDe(papel);

            Assert.False(ganhou);
        }
    }
}
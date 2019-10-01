using ExpectedObjects;
using Moq;
using Xunit;

namespace JokenpoTDD.Teste
{
    public class PapelTeste
    {
        [Fact]
        public void Deve_criar_uma_jogada()
        {
            var jogada = new Papel();

            Assert.True(jogada is IJogada);
        }

        [Fact]
        public void Deve_ganhar_de_pedra()
        {
            var jogada = new Papel();
            var pedra = new Pedra();

            var ganhou = jogada.GanhaDe(pedra);

            Assert.True(ganhou);
        }

        [Fact]
        public void Nao_deve_ganhar_de_papel()
        {
            var jogada = new Papel();
            var papel = new Papel();

            var ganhou = jogada.GanhaDe(papel);

            Assert.False(ganhou);
        }

        [Fact]
        public void Nao_deve_ganhar_de_tesoura()
        {
            var jogada = new Papel();
            var tesoura = new Tesoura();

            var ganhou = jogada.GanhaDe(tesoura);

            Assert.False(ganhou);
        }
    }
}
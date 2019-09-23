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
            var jogadaEsperada = new {
                Nome = "Papel"
            };

            var jogada = new Papel();

            jogadaEsperada.ToExpectedObject().ShouldMatch(jogada);
        }

        [Fact]
        public void Deve_ganhar_de_pedra()
        {
            var jogada = new Papel();
            var pedra = new Pedra();

            var ganhou = jogada.GanhaDe(pedra);

            Assert.True(ganhou);
        }

        [Theory]
        [InlineData("Papel")]
        [InlineData("Tesoura")]
        public void Nao_deve_ganhar_das_demais_jogadas(string nomeDaJogadaQueDeveVencer)
        {
            var jogada = new Papel();
            var outraJogada = new Mock<IJogada>();
            outraJogada.SetupGet(t => t.Nome).Returns(nomeDaJogadaQueDeveVencer);

            var ganhou = jogada.GanhaDe(outraJogada.Object);

            Assert.False(ganhou);
        }
    }
}
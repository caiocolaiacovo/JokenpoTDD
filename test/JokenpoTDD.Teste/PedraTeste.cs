using ExpectedObjects;
using Moq;
using Xunit;

namespace JokenpoTDD.Teste
{
    public class PedraTeste
    {
        [Fact]
        public void Deve_criar_uma_jogada()
        {
            var jogadaEsperada = new {
                Nome = "Pedra"
            };

            var jogada = new Pedra();

            jogadaEsperada.ToExpectedObject().ShouldMatch(jogada);
        }

        [Fact]
        public void Deve_ganhar_de_tesoura()
        {
            var jogada = new Pedra();
            var tesoura = new Mock<IJogada>();
            tesoura.SetupGet(t => t.Nome).Returns("Tesoura");

            var ganhou = jogada.GanhaDe(tesoura.Object);

            Assert.True(ganhou);
        }

        [Theory]
        [InlineData("Pedra")]
        [InlineData("Papel")]
        public void Nao_deve_ganhar_das_demais_jogadas(string nomeDaJogadaQueDeveVencer)
        {
            var jogada = new Pedra();
            var outraJogada = new Mock<IJogada>();
            outraJogada.SetupGet(t => t.Nome).Returns(nomeDaJogadaQueDeveVencer);

            var ganhou = jogada.GanhaDe(outraJogada.Object);

            Assert.False(ganhou);
        }
    }
}
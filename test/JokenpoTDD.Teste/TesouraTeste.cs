using ExpectedObjects;
using Moq;
using Xunit;

namespace JokenpoTDD.Teste
{
    public class TesouraTeste
    {
        [Fact]
        public void Deve_criar_uma_jogada()
        {
            var jogadaEsperada = new {
                Nome = "Tesoura"
            };

            var jogada = new Tesoura();

            jogadaEsperada.ToExpectedObject().ShouldMatch(jogada);
        }

        [Fact]
        public void Deve_ganhar_de_papel()
        {
            var jogada = new Tesoura();
            var papel = new Mock<IJogada>();
            papel.SetupGet(t => t.Nome).Returns("Papel");

            var ganhou = jogada.GanhaDe(papel.Object);

            Assert.True(ganhou);
        }

        [Theory]
        [InlineData("Tesoura")]
        [InlineData("Pedra")]
        public void Nao_deve_ganhar_das_demais_jogadas(string nomeDaJogadaQueDeveVencer)
        {
            var jogada = new Tesoura();
            var outraJogada = new Mock<IJogada>();
            outraJogada.SetupGet(t => t.Nome).Returns(nomeDaJogadaQueDeveVencer);

            var ganhou = jogada.GanhaDe(outraJogada.Object);

            Assert.False(ganhou);
        }
    }
}
using ExpectedObjects;
using Moq;
using Xunit;

namespace JokenpoTDD.Teste
{
    public class JuizTeste
    {
        public Juiz _juiz { get; private set; }
        public Mock<IJogada> _jogada1 { get; private set; }
        public Mock<IJogada> _jogada2 { get; private set; }

        public JuizTeste()
        {
            _juiz = new Juiz();

            _jogada1 = new Mock<IJogada>();
            _jogada2 = new Mock<IJogada>();
        }

        [Fact]
        public void Jogada_um_deve_ser_a_vencedora()
        {
            _jogada1.Setup(j => j.GanhaDe(_jogada2.Object)).Returns(true);

            var jogadaVencedora = _juiz.ObterVencedor(_jogada1.Object, _jogada2.Object);

            Assert.Equal<IJogada>(_jogada1.Object, jogadaVencedora);
        }

        [Fact]
        public void Jogada_dois_deve_ser_a_vencedora()
        {
            _jogada2.Setup(j => j.GanhaDe(_jogada1.Object)).Returns(true);

            var jogadaVencedora = _juiz.ObterVencedor(_jogada1.Object, _jogada2.Object);

            Assert.Equal<IJogada>(_jogada2.Object, jogadaVencedora);
        }

        [Fact]
        public void Jogadas_um_e_dois_devem_empatar()
        {
            _jogada1.Setup(j => j.GanhaDe(_jogada2.Object)).Returns(false);
            _jogada2.Setup(j => j.GanhaDe(_jogada1.Object)).Returns(false);

            var jogadaVencedora = _juiz.ObterVencedor(_jogada1.Object, _jogada2.Object);

            Assert.Null(jogadaVencedora);
        }
    }
}
using System.Drawing;
using PedraPapelTesoura;

namespace PedraPapelTesouraTest
{
    [TestClass]
    public sealed class GameUnitTest
    {
        private Game game;

        [TestInitialize]
        public void setup()
        {
            game = new Game();
        }

        [TestMethod]
        [DataRow("Pedra", "Papel", "Papel vence Pedra!")]
        [DataRow("Pedra", "Tesoura", "Pedra vence Tesoura!")]
        [DataRow("Pedra", "Pedra", "Empate")]
        [DataRow("Papel", "Pedra", "Papel vence Pedra!")]
        [DataRow("Papel", "Tesoura", "Tesoura vence Papel!")]
        [DataRow("Papel", "Papel", "Empate")]
        [DataRow("Tesoura", "Papel", "Tesoura vence Papel!")]
        [DataRow("Tesoura", "Pedra", "Pedra vence Tesoura!")]
        [DataRow("Tesoura", "Tesoura", "Empate")]
        public void DeveRetornarResultadoJogo(string escolhaA, string escolhaB, string esperado)
        {
            // Act
            string obtido = game.jogar(escolhaA, escolhaB);

            // Assert  
            Assert.AreEqual(esperado, obtido);
        }
    }
}

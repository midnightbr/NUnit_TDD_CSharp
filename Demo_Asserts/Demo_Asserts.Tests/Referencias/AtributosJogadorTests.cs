using NUnit.Framework;

namespace Demo_Asserts.Tests.Referencias
{
    [TestFixture]
    class AtributosJogadorTests
    {
        [Test]
        public void CompararReferenciaDeObjeto()
        {
            var player1 = new AtributosJogador();
            var player2 = new AtributosJogador();
            var player3 = player1;

            // A variavel a baixo vai falhar, pelo fato do player2 não está apontando ao player1 como referencia.
            //Assert.That(player1, Is.SameAs(player2));

            Assert.That(player1, Is.SameAs(player3));
            // Como o objeto player3 aponta para a mesma referencia(os mesmos valores) de player1, o teste vai dar exito.

            Assert.That(player2, Is.Not.SameAs(player1)); // Not no qual testa se o objeto não são da mesma referencia
        }
    }
}

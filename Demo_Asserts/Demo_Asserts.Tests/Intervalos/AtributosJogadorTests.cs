using NUnit.Framework;

namespace Demo_Asserts.Tests.Intervalos
{
    [TestFixture]
    public class AtributosJogadorTests
    {
        /*
         * Is.LessThan() -> Verficia se é menor que o valor informado
         * Is.LessThanOrEqualTo() -> Verficia se é menor ou igual que o valor informado
         * Is.GreaterThan() -> Verficia se é maior que o valor informado
         * Is.GreaterThanOrEqualTo() -> Verficia se é maior que o valor informado
         */

        [Test]
        public void AumentarVidaJogadorDepoisDormir()
        {
            var sut = new AtributosJogador()
            {
                Vida = 100
            };

            sut.Dormir();

            // Testa se o valor atual é maior do que o argumento dado
            Assert.That(sut.Vida, Is.GreaterThan(100));
        }

        [Test]
        public void AumentarVidaJogadorDepoisDormir_Intervalo()
        {
            var sut = new AtributosJogador()
            {
                Vida = 100
            };

            sut.Dormir();

            // Essa opção verifica se o valor de sut.Vida está dentro do intervalo de 101 á 200
            Assert.That(sut.Vida, Is.InRange(101, 200));
        }
    }
}
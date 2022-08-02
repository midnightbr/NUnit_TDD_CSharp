using NUnit.Framework;

namespace Calculadora.Testes
{
    public class CalculadoraTests
    {
        [TestFixture]
        public class CalculadoraSimplesTests
        {
            [Test]
            public void DeveAddDoisNumeros()
            {
                // SUT
                var sut = new CalculadoraSimples();
                var result = sut.Add(2, 2);

                // Testando o resultado do método
                Assert.That(result, Is.EqualTo(4));
            }

            [Test]
            public void DeveMultiDoisNumeros()
            {
                // SUT
                var sut = new CalculadoraSimples();
                var result = sut.Multi(5, 3);

                // Testando o resultado do método
                Assert.That(result, Is.EqualTo(15));
            }
        }
    }
}
using NUnit.Framework;

namespace Demo_Asserts.Tests.Igualdade
{
    [TestFixture]
    public class CalculadoraTests
    {
        // Método para Somar Inteiros
        [Test]
        public void TesteSomarInteiro()
        {
            var sut = new Calculadora();

            var result = sut.SomarNumerosInteiros(25, 10);

            Assert.That(result, Is.EqualTo(35));
        }

        // Método para Somar Decimais
        [Test]
        public void TesteSomarDecimal()
        {
            var sut = new Calculadora();

            var result = sut.SomarNumerosDecimais(7.5, 10.8);

            Assert.That(result, Is.EqualTo(18.3));
        }

        // Resolvendo problemas com pontos flutuantes
        [Test]
        public void TesteSomarDecimal_UsandoWithin()
        {
            var sut = new Calculadora();

            var result = sut.SomarNumerosDecimais(1.1, 2.2);

            Assert.That(result, Is.EqualTo(3.3).Within(0.01)); 
            // Within é a tolerancia de erro aceitado pelo teste (margem de erro, vamos chamar assim)
        }

        [Test]
        public void TesteSomarDecimal_UsandoWithinPorcentagem()
        {
            var sut = new Calculadora();

            var result = sut.SomarNumerosDecimais(50, 50);

            Assert.That(result, Is.EqualTo(101).Within(1).Percent);
            // Whithin().Percent informa a tolerancia aceitavel em porcetagem, não em valor
        }

        // Método para Dividir
        [Test]
        public void TesteDividir()
        {
            var sut = new Calculadora();

            var result = sut.Dividir(50, 20);

            Assert.That(result, Is.EqualTo(2.5));
        }

        [Test]
        public void TesteDividirErro()
        {
            var sut = new Calculadora();

            // Testando se o resultado da operação retorna um erro
            Assert.Throws<Exception>(() => sut.Dividir(150, 50));
        }
    }
}

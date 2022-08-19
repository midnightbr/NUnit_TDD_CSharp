using NUnit.Framework;

namespace Demo_Asserts.Tests.Excecoes
{
    [TestFixture]
    class CalculadoraTests
    {
        [Test]
        public void DeveRetornarErroQuandoDivirPorZero()
        {
            var sut = new Calculadora();

            // Fazendo o teste se o resultado do método é um erro
            Assert.That(() => sut.Dividir(200, 0), Throws.Exception);
        }

        [Test]
        public void RetornarUmErroQuandoDivirPorZero()
        {
            var sut = new Calculadora();
            
            // Fazendo o teste se o resultado do método é um erro, mais nesse caso, você especifica qual erro você deseja
            // no qual se o tipo do erro for diferente, ele ira falhar, já que o erro retornado não é o que ele está aguardando
            Assert.That(() => sut.Dividir(99, 0), Throws.TypeOf<DivideByZeroException>());
            // Obs.: O teste de divisão por zero, só retornara erro se o retorno do método for int e não double
        }

        [Test]
        public void RetornarErroNumeroMaiorQueCem()
        {
            var sut = new Calculadora();

            Assert.That(() => sut.Dividir(200, 2), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void RetornarErroNumeroMaiorQueCem_MelhorCaso()
        {
            var sut = new Calculadora();

            /*
             * Nesse caso, estamos especificando além do erro o nome do parametro a ser retornada também do erro, sendo assim
             * bastante preciso com o que queremos de retorno.
             */
            Assert.That(() => sut.Dividir(200, 2), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Matches<ArgumentOutOfRangeException>(x => x.ParamName == "por"));
        }
    }
}

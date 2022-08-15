using NUnit.Framework;

namespace Demo_Asserts.Tests.BooleanosNulos
{
    [TestFixture]
    public class AtributosJogadorTests
    {
        [Test]
        public void GerarNomeRandomicoPorDefault()
        {
            var sut = new AtributosJogador();

            // Testa se o valor não está vazio
            Assert.That(sut.Nome, Is.Not.Empty);
        }

        [Test]
        public void VerificarSeJogadorNovo()
        {
            var sut = new AtributosJogador();

            // Verificando se o valor não é falso
            Assert.That(sut.NovoJogador, Is.Not.False);
            // Para verificar se o valor não é verdadeiro, basta trocar o false pelo true

            Assert.That(sut.NovoJogador, Is.True);
            // Podemos também remover o not e colocar diretamente para poder esperar valor false ou true
        }

        [Test]
        public void VerificarApelidoJogador()
        {
            var sut = new AtributosJogador() { Apelido = null};
            
            // Verificando se o Apelido é nulo. Para verificar se não é nulo, basta mudar para
            // Is.Not.Null
            Assert.That(sut.Apelido, Is.Null);
        }
    }
}
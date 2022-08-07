using NUnit.Framework;

namespace Demo_Asserts.Tests.Igualdade
{
    [TestFixture]
    public class JuntarNomesTests
    {
        /* Método responsavel por juntar as strings*/
        [Test]
        public void DevoJuntarNomeCompleto()
        {
            var sut = new JuntarNome();

            var nomeCompleto = sut.Juntar("John", "Lucca");
            Assert.That(nomeCompleto, Is.EqualTo("John Lucca"));
        }

        [Test]
        public void DevoJuntarNomeCompleto_CaseSensitive()
        {
            var sut = new JuntarNome();

            var nomeCompleto = sut.Juntar("marcos", "Henrique");

            // O IgnoreCase ira ignorar do resultar a letras maiusculas e minusculas, como no exemplo a baixo
            Assert.That(nomeCompleto, Is.EqualTo("MARCOS HENRIQUE").IgnoreCase);
        }

        [Test]
        public void DevoJuntarNomeCompleto_NaoIgual()
        {
            var sut = new JuntarNome();

            var nomeCompleto = sut.Juntar("John", "Lucca");

            // Método para verificar se o resulta é diferente, ou seja, não é igual
            Assert.That(nomeCompleto, Is.Not.EqualTo("Fabiana Miranda"));
        }
    }
}

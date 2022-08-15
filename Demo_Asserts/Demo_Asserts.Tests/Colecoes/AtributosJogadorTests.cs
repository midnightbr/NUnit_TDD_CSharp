using NUnit.Framework;

namespace Demo_Asserts.Tests.Colecoes
{
    [TestFixture]
    public class AtributosJogadorTests
    {
        [Test]
        public void TestarListaDeArmasVazia()
        {
            var sut = new AtributosJogador();

            // Testando se uma coleção (lista de dados) não está vazia.
            Assert.That(sut.Armas, Is.All.Not.Empty);
        }

        [Test]
        public void TestarSeContemArma()
        {
            var sut = new AtributosJogador();

            // Aqui estamos testando se existe um objeto dentro da lista Armas.
            Assert.That(sut.Armas, Contains.Item("MA40 Assault Rifle"));
        }

        [Test]
        public void TestandoNomesDasArmas()
        {
            var sut = new AtributosJogador();

            // Testando se determinada palavra existe na coleção
            Assert.That(sut.Armas, Has.Some.Contains("Battle"));
        }

        [Test]
        public void DeveConterDuasArmas()
        {
            var sut = new AtributosJogador();

            // Testando se existe mais de duas armas na lista de objetos
            Assert.That(sut.Armas, Has.Exactly(2).EndWith("Rifle"));
        }

        [Test]
        public void NaoDeveConterMaisDeUmaArma()
        {
            var sut = new AtributosJogador();

            //Método responsável por testar se os itens contidos na lista são únicos
            Assert.That(sut.Armas, Is.Unique);
        }

        [Test]
        public void NaoDeveConterArmaEscopeta()
        {
            var sut = new AtributosJogador();

            // Método responsável para testar se há um item que não está listando na coleção
            Assert.That(sut.Armas, Has.None.EqualTo("Escopeta"));
        }

        [Test]
        public void DeveConterExatamenteTodasAsArmas()
        {
            var sut = new AtributosJogador();

            var listaArmasEsperadas = new[]
            {
                "MA40 Assault Rifle",
                "BR75 Battle Rifle",
                "VK78 Commando",
                "Pulse Carbine",
                "MK 50 Sidekick",
                "CQS48 Bulldog",
                "S7 Sniper"
            };

            // Método responsável por testar se há equivalência de itens na coleção
            Assert.That(sut.Armas, Is.EquivalentTo(listaArmasEsperadas));
        }

        [Test]
        public void ArmasDevemEstarOrdemAlfabetica()
        {
            var sut = new AtributosJogador();

            // Método responsável por testar se a coleção está em ordem alfabética
            Assert.That(sut.Armas, Is.Ordered);
        }
    }
}

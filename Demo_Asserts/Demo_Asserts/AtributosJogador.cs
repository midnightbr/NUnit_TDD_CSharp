namespace Demo_Asserts
{
    public class AtributosJogador
    {
        public int Vida { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public bool NovoJogador { get; set; }
        public List<string> Armas { get; set; }

        public AtributosJogador()
        {
            Nome = GerarNome();

            NovoJogador = true;

            CriarArmasIniciais();
        }

        // Método para aumentar a vida do Jogador
        public void Dormir()
        {
            var random = new Random();

            Vida += random.Next(1, 100);
        }

        // Método para perder vida do jogador
        public void PerderVida(int perderVida) => Vida = Math.Max(1, Vida -= perderVida);

        private void CriarArmasIniciais()
        {
            Armas = new List<string>()
            {
                
                "BR75 Battle Rifle",
                "CQS48 Bulldog",
                "MA40 Assault Rifle",
                "MK 50 Sidekick",
                "Pulse Carbine",
                "S7 Sniper",
                "VK78 Commando"
            };
        }

        private string GerarNome()
        {
            var nomes = new[]
            {
                "Master-Chief",
                "Cortana",
                "Kai",
                "Jacoob",
                "Riz"
            };

            return nomes[new Random().Next(0, nomes.Length)];
        }
    }
}

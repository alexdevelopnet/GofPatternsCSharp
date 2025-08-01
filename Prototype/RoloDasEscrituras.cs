using System;

namespace GoFPatternsCSharp.Prototype
{
    public class RoloDasEscrituras : IRoloPrototype
    {
        public string Livro { get; set; }
        public string Conteudo { get; set; }

        public RoloDasEscrituras(string livro, string conteudo)
        {
            Livro = livro;
            Conteudo = conteudo;
        }

        public IRoloPrototype Clonar()
        {
            return new RoloDasEscrituras(Livro, Conteudo);
        }

        public void Ler()
        {
            Console.WriteLine($"Rolo: {Livro}\nConteúdo: {Conteudo}\n");
        }
    }
}
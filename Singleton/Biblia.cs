using System;

namespace GoFPatternsCSharp.Singleton
{
    public class Biblia
    {
        private static Biblia? _instancia = null;

        // Construtor privado
        private Biblia()
        {
            Console.WriteLine("Bíblia criada!");
        }

        // Método para obter a instância única
        public static Biblia GetInstance()
        {
            if (_instancia == null)
            {
                _instancia = new Biblia();
            }
            return _instancia;
        }

        public void LerVersiculo(string livro, int capitulo, int versiculo)
        {
            Console.WriteLine($"Lendo {livro} {capitulo}:{versiculo}");
        }
    }
}
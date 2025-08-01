using System;

namespace GoFPatternsCSharp.FactoryMethod
{
    public class ImpressaoSimples : ImpressaoBiblica
    {
        public ImpressaoSimples(string livro, int capitulo, int versiculo, string texto)
            : base(livro, capitulo, versiculo, texto) { }

        public override void Imprimir()
        {
            Console.WriteLine($"{Livro} {Capitulo}:{Versiculo} - \"{Texto}\"");
        }
    }
}
using System;

namespace Criacionais.FactoryMethod
{
    public class ImpressaoComentada : ImpressaoBiblica
    {
        public string Comentario { get; }

        public ImpressaoComentada(string livro, int capitulo, int versiculo, string texto, string comentario)
            : base(livro, capitulo, versiculo, texto)
        {
            Comentario = comentario;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{Livro} {Capitulo}:{Versiculo} - \"{Texto}\"");
            Console.WriteLine($"Comentário: {Comentario}");
        }
    }
}
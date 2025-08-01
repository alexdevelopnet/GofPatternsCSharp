using System;

namespace GoFPatternsCSharp.FactoryMethod
{
    public class Profecia : HistoriaBiblica
    {
        public Profecia(string titulo, string referencia, string resumo)
            : base(titulo, referencia, resumo) { }

        public override void Contar()
        {
            Console.WriteLine($"[Profecia] {Titulo} ({Referencia})\n{Resumo}\n");
        }
    }
}
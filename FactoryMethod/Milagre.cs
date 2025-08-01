using System;

namespace GoFPatternsCSharp.FactoryMethod
{
    public class Milagre : HistoriaBiblica
    {
        public Milagre(string titulo, string referencia, string resumo)
            : base(titulo, referencia, resumo) { }

        public override void Contar()
        {
            Console.WriteLine($"[Milagre] {Titulo} ({Referencia})\n{Resumo}\n");
        }
    }
}
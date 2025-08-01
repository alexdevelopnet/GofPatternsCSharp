using System;

namespace GoFPatternsCSharp.FactoryMethod
{
    public class Parabola : HistoriaBiblica
    {
        public Parabola(string titulo, string referencia, string resumo)
            : base(titulo, referencia, resumo) { }

        public override void Contar()
        {
            Console.WriteLine($"[Parábola] {Titulo} ({Referencia})\n{Resumo}\n");
        }
    }
}
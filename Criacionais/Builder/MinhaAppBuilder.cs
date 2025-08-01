using System;

namespace GoFPatternsCSharp.Builder
{
    public class MinhaAppBuilder
    {
        public static void Executar()
        {
            var moises = new MoisesDirector();

            Console.WriteLine("Tabernáculo Simples:");
            var simplesBuilder = new TabernaculoSimplesBuilder();
            moises.ConstruirTabernaculoCompleto(simplesBuilder);
            Console.WriteLine(simplesBuilder.ObterTabernaculo());

            Console.WriteLine("Tabernáculo Detalhado:");
            var detalhadoBuilder = new TabernaculoDetalhadoBuilder();
            moises.ConstruirTabernaculoCompleto(detalhadoBuilder);
            Console.WriteLine(detalhadoBuilder.ObterTabernaculo());
        }
    }
}
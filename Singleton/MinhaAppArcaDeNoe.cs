using System;

namespace GoFPatternsCSharp.Singleton
{
    public class MinhaAppArcaDeNoe
    {
        public static void Executar()
        {
            var arca1 = ArcaDeNoe.Instancia;
            arca1.Embarcar("Noé");
            arca1.Embarcar("Leão");
            arca1.Embarcar("Ovelha");

            var arca2 = ArcaDeNoe.Instancia;
            arca2.Embarcar("Pomba");

            // Todos estão na mesma arca!
            arca1.ListarPassageiros();
            Console.WriteLine($"arca1 e arca2 são a mesma instância? {object.ReferenceEquals(arca1, arca2)}");
        }
    }
}
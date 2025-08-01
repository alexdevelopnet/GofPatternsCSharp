using System;

namespace GoFPatternsCSharp.AbstractFactory
{
    public class HistoriaAntigoTestamento : IHistoriaBiblica
    {
        public void Contar()
        {
            Console.WriteLine("História: A travessia do Mar Vermelho (Êxodo 14)");
        }
    }
}
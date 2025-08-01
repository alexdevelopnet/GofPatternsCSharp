using System;

namespace GoFPatternsCSharp.AbstractFactory
{
    public class HistoriaNovoTestamento : IHistoriaBiblica
    {
        public void Contar()
        {
            Console.WriteLine("História: A multiplicação dos pães e peixes (Mateus 14:13-21)");
        }
    }
}
using System;

namespace GoFPatternsCSharp.FactoryMethod
{
    // Fábrica
    public abstract class Empresa
    {
        public abstract Passagem EmitePassagem(string origem, string destino, DateTime dataHoraPartida);
    }
}
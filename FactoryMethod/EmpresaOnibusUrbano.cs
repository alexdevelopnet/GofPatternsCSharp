using System;

namespace GoFPatternsCSharp.FactoryMethod
{
    // Fábrica concreta
    public class EmpresaOnibusUrbano : Empresa
    {
        public override Passagem EmitePassagem(string origem, string destino, DateTime dataHoraPartida)
        {
            return new PassagemOnibusUrbano(origem, destino, dataHoraPartida);
        }
    }
}
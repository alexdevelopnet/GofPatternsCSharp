using System;

namespace GoFPatternsCSharp.FactoryMethod
{
    // Fábrica concreta
    public class EmpresaOnibusInterestadual : Empresa
    {
        public override Passagem EmitePassagem(string origem, string destino, DateTime dataHoraPartida)
        {
            return new PassagemOnibusInterestadual(origem, destino, dataHoraPartida);
        }
    }
}
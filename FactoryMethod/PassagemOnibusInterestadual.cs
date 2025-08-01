using System;

namespace GoFPatternsCSharp.FactoryMethod
{
    // Produto concreto
    public class PassagemOnibusInterestadual : Passagem
    {
        public PassagemOnibusInterestadual(string origem, string destino, DateTime dataHoraPartida)
            : base(origem, destino, dataHoraPartida) { }

        public override void ExibeDetalhes()
        {
            Console.WriteLine($"Passagem de ônibus interestadual: {Origem} para {Destino}, Data/Hora: {DataHoraPartida:dd/MM/yyyy HH:mm}");
        }
    }
}
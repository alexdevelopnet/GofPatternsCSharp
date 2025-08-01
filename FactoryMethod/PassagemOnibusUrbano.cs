using System;

namespace GoFPatternsCSharp.FactoryMethod
{
    // Produto concreto
    public class PassagemOnibusUrbano : Passagem
    {
        public PassagemOnibusUrbano(string origem, string destino, DateTime dataHoraPartida)
            : base(origem, destino, dataHoraPartida) { }

        public override void ExibeDetalhes()
        {
            Console.WriteLine($"Passagem de ônibus urbana: {Origem} para {Destino}, Data/Hora: {DataHoraPartida:dd/MM/yyyy HH:mm}");
        }
    }
}
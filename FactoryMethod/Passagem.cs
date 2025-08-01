using System;

namespace GoFPatternsCSharp.FactoryMethod
{
    // Produto
    public abstract class Passagem
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime DataHoraPartida { get; set; }

        public Passagem(string origem, string destino, DateTime dataHoraPartida)
        {
            Origem = origem;
            Destino = destino;
            DataHoraPartida = dataHoraPartida;
        }

        public abstract void ExibeDetalhes();
    }
}
namespace Criacionais.Singleton
{
    public class HistoriaBiblica
    {
        public string Titulo { get; }
        public string Referencia { get; }
        public string Resumo { get; }

        public HistoriaBiblica(string titulo, string referencia, string resumo)
        {
            Titulo = titulo;
            Referencia = referencia;
            Resumo = resumo;
        }

        public void Contar()
        {
            Console.WriteLine($"{Titulo} ({Referencia})\n{Resumo}\n");
        }
    }
}
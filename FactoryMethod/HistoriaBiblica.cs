namespace GoFPatternsCSharp.FactoryMethod
{
    public abstract class HistoriaBiblica
    {
        public string Titulo { get; }
        public string Referencia { get; }
        public string Resumo { get; }

        protected HistoriaBiblica(string titulo, string referencia, string resumo)
        {
            Titulo = titulo;
            Referencia = referencia;
            Resumo = resumo;
        }

        public abstract void Contar();
    }
}
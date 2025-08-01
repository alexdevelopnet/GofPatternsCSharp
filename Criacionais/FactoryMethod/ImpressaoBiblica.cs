namespace GoFPatternsCSharp.FactoryMethod
{
    public abstract class ImpressaoBiblica
    {
        public string Livro { get; }
        public int Capitulo { get; }
        public int Versiculo { get; }
        public string Texto { get; }

        protected ImpressaoBiblica(string livro, int capitulo, int versiculo, string texto)
        {
            Livro = livro;
            Capitulo = capitulo;
            Versiculo = versiculo;
            Texto = texto;
        }

        public abstract void Imprimir();
    }
}
namespace GoFPatternsCSharp.FactoryMethod
{
    public abstract class FabricaImpressao
    {
        public abstract ImpressaoBiblica CriarImpressao(string livro, int capitulo, int versiculo, string texto, string comentario = "");
    }
}
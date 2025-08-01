namespace GoFPatternsCSharp.FactoryMethod
{
    public class FabricaImpressaoSimples : FabricaImpressao
    {
        public override ImpressaoBiblica CriarImpressao(string livro, int capitulo, int versiculo, string texto, string comentario = "")
        {
            return new ImpressaoSimples(livro, capitulo, versiculo, texto);
        }
    }
}
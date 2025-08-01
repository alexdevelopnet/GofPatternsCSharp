namespace GoFPatternsCSharp.FactoryMethod
{
    public class FabricaImpressaoComentada : FabricaImpressao
    {
        public override ImpressaoBiblica CriarImpressao(string livro, int capitulo, int versiculo, string texto, string comentario = "")
        {
            return new ImpressaoComentada(livro, capitulo, versiculo, texto, comentario);
        }
    }
}
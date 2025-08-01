namespace GoFPatternsCSharp.FactoryMethod
{
    public abstract class FabricaHistoria
    {
        public abstract HistoriaBiblica CriarHistoria(string titulo, string referencia, string resumo);
    }
}
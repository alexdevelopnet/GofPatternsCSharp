namespace GoFPatternsCSharp.FactoryMethod
{
    public class FabricaProfecia : FabricaHistoria
    {
        public override HistoriaBiblica CriarHistoria(string titulo, string referencia, string resumo)
        {
            return new Profecia(titulo, referencia, resumo);
        }
    }
}
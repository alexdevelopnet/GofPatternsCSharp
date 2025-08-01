namespace GoFPatternsCSharp.FactoryMethod
{
    public class FabricaParabola : FabricaHistoria
    {
        public override HistoriaBiblica CriarHistoria(string titulo, string referencia, string resumo)
        {
            return new Parabola(titulo, referencia, resumo);
        }
    }
}
namespace GoFPatternsCSharp.FactoryMethod
{
    public class FabricaMilagre : FabricaHistoria
    {
        public override HistoriaBiblica CriarHistoria(string titulo, string referencia, string resumo)
        {
            return new Milagre(titulo, referencia, resumo);
        }
    }
}
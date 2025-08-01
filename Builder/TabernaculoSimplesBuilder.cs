namespace GoFPatternsCSharp.Builder
{
    public class TabernaculoSimplesBuilder : ITabernaculoBuilder
    {
        private Tabernaculo _tabernaculo = new Tabernaculo();

        public void ConstruirEstrutura() => _tabernaculo.Estrutura = "Estrutura de madeira simples";
        public void ConstruirAltar() => _tabernaculo.Altar = "Altar de bronze";
        public void ConstruirArca() => _tabernaculo.Arca = "Arca simples";
        public void ConstruirCortinas() => _tabernaculo.Cortinas = "Cortinas de linho";

        public Tabernaculo ObterTabernaculo() => _tabernaculo;
    }
}
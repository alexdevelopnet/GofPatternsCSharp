namespace GoFPatternsCSharp.Builder
{
    public class TabernaculoDetalhadoBuilder : ITabernaculoBuilder
    {
        private Tabernaculo _tabernaculo = new Tabernaculo();

        public void ConstruirEstrutura() => _tabernaculo.Estrutura = "Estrutura de madeira de acácia revestida de ouro";
        public void ConstruirAltar() => _tabernaculo.Altar = "Altar de bronze com detalhes em ouro";
        public void ConstruirArca() => _tabernaculo.Arca = "Arca da Aliança com querubins de ouro";
        public void ConstruirCortinas() => _tabernaculo.Cortinas = "Cortinas de linho fino bordadas com querubins";

        public Tabernaculo ObterTabernaculo() => _tabernaculo;
    }
}
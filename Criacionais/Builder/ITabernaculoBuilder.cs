namespace GoFPatternsCSharp.Builder
{
    public interface ITabernaculoBuilder
    {
        void ConstruirEstrutura();
        void ConstruirAltar();
        void ConstruirArca();
        void ConstruirCortinas();
        Tabernaculo ObterTabernaculo();
    }
}
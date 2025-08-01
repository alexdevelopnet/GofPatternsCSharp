namespace GoFPatternsCSharp.Builder
{
    public class MoisesDirector
    {
        public void ConstruirTabernaculoCompleto(ITabernaculoBuilder builder)
        {
            builder.ConstruirEstrutura();
            builder.ConstruirAltar();
            builder.ConstruirArca();
            builder.ConstruirCortinas();
        }
    }
}
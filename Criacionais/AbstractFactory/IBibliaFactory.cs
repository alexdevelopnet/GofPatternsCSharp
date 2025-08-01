namespace GoFPatternsCSharp.AbstractFactory
{
    public interface IBibliaFactory
    {
        IHistoriaBiblica CriarHistoria();
        IPersonagemBiblico CriarPersonagem();
    }
}
namespace GoFPatternsCSharp.AbstractFactory
{
    public class AntigoTestamentoFactory : IBibliaFactory
    {
        public IHistoriaBiblica CriarHistoria()
        {
            return new HistoriaAntigoTestamento();
        }

        public IPersonagemBiblico CriarPersonagem()
        {
            return new PersonagemAntigoTestamento();
        }
    }
}
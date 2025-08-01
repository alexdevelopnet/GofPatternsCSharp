namespace GoFPatternsCSharp.AbstractFactory
{
    public class NovoTestamentoFactory : IBibliaFactory
    {
        public IHistoriaBiblica CriarHistoria()
        {
            return new HistoriaNovoTestamento();
        }

        public IPersonagemBiblico CriarPersonagem()
        {
            return new PersonagemNovoTestamento();
        }
    }
}
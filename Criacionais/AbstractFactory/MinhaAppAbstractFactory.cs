using System;

namespace GoFPatternsCSharp.AbstractFactory
{
    public class MinhaAppAbstractFactory
    {
        public static void Executar()
        {
            Console.WriteLine("Exemplo com Antigo Testamento:");
            IBibliaFactory antigoFactory = new AntigoTestamentoFactory();
            var historiaAntigo = antigoFactory.CriarHistoria();
            var personagemAntigo = antigoFactory.CriarPersonagem();
            historiaAntigo.Contar();
            personagemAntigo.Apresentar();

            Console.WriteLine("\nExemplo com Novo Testamento:");
            IBibliaFactory novoFactory = new NovoTestamentoFactory();
            var historiaNovo = novoFactory.CriarHistoria();
            var personagemNovo = novoFactory.CriarPersonagem();
            historiaNovo.Contar();
            personagemNovo.Apresentar();
        }
    }
}
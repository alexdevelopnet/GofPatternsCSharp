using GoFPatternsCSharp.FactoryMethod;
using GoFPatternsCSharp.Singleton;
using GoFPatternsCSharp.AbstractFactory;
using GoFPatternsCSharp.Builder;
using GoFPatternsCSharp.Prototype;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Escolha um exemplo para rodar:");
            Console.WriteLine("1 - Factory Method: Impressão de Versículos");
            Console.WriteLine("2 - Factory Method: Histórias Bíblicas");
            Console.WriteLine("3 - Singleton: Repositório de Histórias");
            Console.WriteLine("4 - Singleton: Arca de Noé");
            Console.WriteLine("5 - Abstract Factory: Testamentos");
            Console.WriteLine("6 - Builder: Tabernáculo");
            Console.WriteLine("7 - Prototype: Rolo das Escrituras");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            var opcao = Console.ReadLine();
            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    MinhaAppBiblia.Executar();
                    break;
                case "2":
                    MinhaAppHistorias.Executar();
                    break;
                case "3":
                    MinhaAppSingletonHistorias.Executar();
                    break;
                case "4":
                    MinhaAppArcaDeNoe.Executar();
                    break;
                case "5":
                    MinhaAppAbstractFactory.Executar();
                    break;
                case "6":
                    MinhaAppBuilder.Executar();
                    break;
                case "7":
                    MinhaAppPrototype.Executar();
                    break;
                case "0":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida!\n");
                    break;
            }
            Console.WriteLine("-----------------------------\n");
        }
    }
}

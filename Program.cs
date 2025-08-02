using Criacionais.Singleton;
using Estruturais.Adapter;
using GoFPatternsCSharp.AbstractFactory;
using GoFPatternsCSharp.Builder;
using GoFPatternsCSharp.FactoryMethod;
using GoFPatternsCSharp.Prototype;

class Program
{
    private static readonly Dictionary<string, (string descricao, Action acao)> opcoes = new()
    {
        // Criacionais
        {"1", ("Factory Method: Impressão de Versículos", () => MinhaAppBiblia.Executar())},
        {"2", ("Factory Method: Histórias Bíblicas", () => MinhaAppHistorias.Executar())},
        {"3", ("Singleton: Repositório de Histórias", () => MinhaAppSingletonHistorias.Executar())},
        {"4", ("Singleton: Arca de Noé", () => MinhaAppArcaDeNoe.Executar())},
        {"5", ("Abstract Factory: Testamentos", () => MinhaAppAbstractFactory.Executar())},
        {"6", ("Builder: Tabernáculo", () => MinhaAppBuilder.Executar())},
        {"7", ("Prototype: Rolo das Escrituras", () => MinhaAppPrototype.Executar())},
        // Estruturais
        {"8", ("Adapter: Paulo adaptando a mensagem", () => MinhaAppAdapter.Executar())},
        // Sair
        {"0", ("Sair", () => { Console.WriteLine("Saindo..."); })}
    };

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n==== Padrões GoF ====");
            Console.WriteLine("[Criacionais]");
            Console.WriteLine(" 1 - " + opcoes["1"].descricao);
            Console.WriteLine(" 2 - " + opcoes["2"].descricao);
            Console.WriteLine(" 3 - " + opcoes["3"].descricao);
            Console.WriteLine(" 4 - " + opcoes["4"].descricao);
            Console.WriteLine(" 5 - " + opcoes["5"].descricao);
            Console.WriteLine(" 6 - " + opcoes["6"].descricao);
            Console.WriteLine(" 7 - " + opcoes["7"].descricao);
            Console.WriteLine("[Estruturais]");
            Console.WriteLine(" 8 - " + opcoes["8"].descricao);
            Console.WriteLine("[0] - Sair");
            Console.Write("Opção: ");
            var opcao = Console.ReadLine();
            Console.WriteLine();

            if (opcoes.TryGetValue(opcao ?? "", out var item))
            {
                if (opcao == "0")
                {
                    item.acao();
                    break;
                }
                item.acao();
            }
            else
            {
                Console.WriteLine("Opção inválida!\n");
            }
            Console.WriteLine("-----------------------------\n");
        }
    }
}

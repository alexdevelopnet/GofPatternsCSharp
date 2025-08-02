using Criacionais.Singleton;
using Estruturais.Adapter;
using GoFPatternsCSharp.AbstractFactory;
using GoFPatternsCSharp.Builder;
using GoFPatternsCSharp.FactoryMethod;
using GoFPatternsCSharp.Prototype;
using Comportamentais.Command;
using Comportamentais.Observer;
using Comportamentais.State;
using Comportamentais.Strategy;
using Comportamentais.TemplateMethod;
using Comportamentais.ChainOfResponsibility;
using Comportamentais.Iterator;
using Comportamentais.Mediator;
using Comportamentais.Memento;
using Comportamentais.Interpreter;
using Comportamentais.Visitor;

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
        // Comportamentais
        {"9", ("Command: Milagres de Jesus", () => MinhaAppCommand.Executar())},
        {"10", ("Observer: Anunciação aos Pastores", () => MinhaAppObserver.Executar())},
        {"11", ("State: Estados de Fé de Pedro", () => MinhaAppState.Executar())},
        {"12", ("Strategy: Evangelização de Paulo", () => MinhaAppStrategy.Executar())},
        {"13", ("Template Method: Rituais de Adoração", () => MinhaAppTemplateMethod.Executar())},
        {"14", ("Chain of Responsibility: Cadeia de Intercessão", () => MinhaAppChainOfResponsibility.Executar())},
        {"15", ("Iterator: Livros da Bíblia", () => MinhaAppIterator.Executar())},
        {"16", ("Mediator: Conselho de Jerusalém", () => MinhaAppMediator.Executar())},
        {"17", ("Memento: Restauração de Jó", () => MinhaAppMemento.Executar())},
        {"18", ("Interpreter: Interpretação das Escrituras", () => MinhaAppInterpreter.Executar())},
        {"19", ("Visitor: Visitação aos Patriarcas", () => MinhaAppVisitor.Executar())},
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
            Console.WriteLine("[Comportamentais]");
            Console.WriteLine(" 9 - " + opcoes["9"].descricao);
            Console.WriteLine("10 - " + opcoes["10"].descricao);
            Console.WriteLine("11 - " + opcoes["11"].descricao);
            Console.WriteLine("12 - " + opcoes["12"].descricao);
            Console.WriteLine("13 - " + opcoes["13"].descricao);
            Console.WriteLine("14 - " + opcoes["14"].descricao);
            Console.WriteLine("15 - " + opcoes["15"].descricao);
            Console.WriteLine("16 - " + opcoes["16"].descricao);
            Console.WriteLine("17 - " + opcoes["17"].descricao);
            Console.WriteLine("18 - " + opcoes["18"].descricao);
            Console.WriteLine("19 - " + opcoes["19"].descricao);
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

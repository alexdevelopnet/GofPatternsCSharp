using System;

namespace Comportamentais.Strategy
{
    // Strategy Interface
    public interface IEstrategiaEvangelizacao
    {
        void Evangelizar(string audiencia);
    }

    // Concrete Strategies
    public class EstrategiaJudeus : IEstrategiaEvangelizacao
    {
        public void Evangelizar(string audiencia)
        {
            Console.WriteLine($"Paulo evangelizando {audiencia}:");
            Console.WriteLine("- Citando as Escrituras do Antigo Testamento");
            Console.WriteLine("- Mostrando como Jesus cumpriu as profecias messiânicas");
            Console.WriteLine("- Argumentando na sinagoga com base na Lei e nos Profetas");
            Console.WriteLine("- 'Cristo morreu pelos nossos pecados, segundo as Escrituras'");
        }
    }

    public class EstrategiaGentios : IEstrategiaEvangelizacao
    {
        public void Evangelizar(string audiencia)
        {
            Console.WriteLine($"Paulo evangelizando {audiencia}:");
            Console.WriteLine("- Começando com a criação e o Deus desconhecido");
            Console.WriteLine("- Usando filosofia e razão natural");
            Console.WriteLine("- Citando poetas gregos: 'Nele vivemos, nos movemos e existimos'");
            Console.WriteLine("- Focando na ressurreição e no julgamento vindouro");
        }
    }

    public class EstrategiaFilosofos : IEstrategiaEvangelizacao
    {
        public void Evangelizar(string audiencia)
        {
            Console.WriteLine($"Paulo evangelizando {audiencia}:");
            Console.WriteLine("- Usando argumentos filosóficos sofisticados");
            Console.WriteLine("- Debatendo sobre a natureza de Deus e da existência");
            Console.WriteLine("- Citando autores gregos conhecidos");
            Console.WriteLine("- Conectando verdades filosóficas com o Evangelho");
        }
    }

    public class EstrategiaGovernantes : IEstrategiaEvangelizacao
    {
        public void Evangelizar(string audiencia)
        {
            Console.WriteLine($"Paulo evangelizando {audiencia}:");
            Console.WriteLine("- Sendo respeitoso com a autoridade");
            Console.WriteLine("- Usando sua cidadania romana estrategicamente");
            Console.WriteLine("- Focando em justiça, temperança e juízo vindouro");
            Console.WriteLine("- Dando testemunho pessoal de sua conversão");
        }
    }

    public class EstrategiaSimples : IEstrategiaEvangelizacao
    {
        public void Evangelizar(string audiencia)
        {
            Console.WriteLine($"Paulo evangelizando {audiencia}:");
            Console.WriteLine("- Usando linguagem simples e direta");
            Console.WriteLine("- Contando histórias e parábolas");
            Console.WriteLine("- Focando no amor de Deus e salvação");
            Console.WriteLine("- 'Cristo Jesus veio ao mundo para salvar os pecadores'");
        }
    }

    // Context - Paulo, o Apóstolo
    public class Paulo
    {
        private IEstrategiaEvangelizacao? _estrategia;

        public void DefinirEstrategia(IEstrategiaEvangelizacao estrategia)
        {
            _estrategia = estrategia;
            Console.WriteLine($"Paulo: Adaptando minha abordagem para esta audiência...");
        }

        public void Pregar(string audiencia)
        {
            if (_estrategia == null)
            {
                Console.WriteLine("Paulo: Preciso definir uma estratégia primeiro!");
                return;
            }

            Console.WriteLine($"Paulo: 'Fiz-me tudo para todos, para por todos os meios salvar alguns.'");
            _estrategia.Evangelizar(audiencia);
        }

        public void ReflexaoSobreEstrategia()
        {
            Console.WriteLine("Paulo: 'Para os judeus fiz-me como judeu; para os que estão debaixo da lei, como se estivesse debaixo da lei; para os gentios, como gentio.'");
        }
    }

    // Aplicação de exemplo
    public class MinhaAppStrategy
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO STRATEGY: Estratégias de Evangelização de Paulo ===\n");

            var paulo = new Paulo();

            // Estratégia para judeus
            Console.WriteLine("--- Pregando na Sinagoga (Judeus) ---");
            paulo.DefinirEstrategia(new EstrategiaJudeus());
            paulo.Pregar("judeus na sinagoga de Tessalônica");
            Console.WriteLine();

            // Estratégia para gentios
            Console.WriteLine("--- Pregando no Areópago (Gentios/Gregos) ---");
            paulo.DefinirEstrategia(new EstrategiaGentios());
            paulo.Pregar("gentios no Areópago de Atenas");
            Console.WriteLine();

            // Estratégia para filósofos
            Console.WriteLine("--- Debatendo com Filósofos ---");
            paulo.DefinirEstrategia(new EstrategiaFilosofos());
            paulo.Pregar("filósofos epicureus e estóicos");
            Console.WriteLine();

            // Estratégia para governantes
            Console.WriteLine("--- Diante do Governador Félix ---");
            paulo.DefinirEstrategia(new EstrategiaGovernantes());
            paulo.Pregar("governador Félix e autoridades romanas");
            Console.WriteLine();

            // Estratégia para pessoas simples
            Console.WriteLine("--- Pregando para o Povo Simples ---");
            paulo.DefinirEstrategia(new EstrategiaSimples());
            paulo.Pregar("pessoas simples em Listra");
            Console.WriteLine();

            // Reflexão final
            Console.WriteLine("--- Reflexão de Paulo ---");
            paulo.ReflexaoSobreEstrategia();
        }
    }
}

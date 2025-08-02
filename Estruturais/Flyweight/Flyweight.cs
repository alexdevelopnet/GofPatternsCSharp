using System;
using System.Collections.Generic;

namespace Estruturais.Flyweight
{
    // Flyweight - Interface para versículos bíblicos
    public interface IVersiculo
    {
        void MostrarVersiculo(string contexto, string aplicacao);
    }

    // ConcreteFlyweight - Versículo específico (estado intrínseco)
    public class VersiculoBiblico : IVersiculo
    {
        private readonly string _texto;
        private readonly string _referencia;
        private readonly string _tema;

        public VersiculoBiblico(string texto, string referencia, string tema)
        {
            _texto = texto;
            _referencia = referencia;
            _tema = tema;
            Console.WriteLine($"📖 Criando versículo flyweight: {_referencia}");
        }

        public void MostrarVersiculo(string contexto, string aplicacao)
        {
            Console.WriteLine($"📜 {_referencia} ({_tema})");
            Console.WriteLine($"   \"{_texto}\"");
            Console.WriteLine($"   Contexto: {contexto}");
            Console.WriteLine($"   Aplicação: {aplicacao}");
            Console.WriteLine();
        }

        public string GetReferencia() => _referencia;
        public string GetTema() => _tema;
    }

    // FlyweightFactory - Gerencia e reutiliza versículos
    public class FabricaVersiculos
    {
        private static readonly Dictionary<string, VersiculoBiblico> _versiculos = new Dictionary<string, VersiculoBiblico>();

        public static VersiculoBiblico GetVersiculo(string referencia)
        {
            if (!_versiculos.ContainsKey(referencia))
            {
                // Simulando um banco de versículos
                var dadosVersiculo = ObterDadosVersiculo(referencia);
                if (dadosVersiculo.HasValue)
                {
                    var dados = dadosVersiculo.Value;
                    _versiculos[referencia] = new VersiculoBiblico(
                        dados.Texto, 
                        dados.Referencia, 
                        dados.Tema);
                }
                else
                {
                    Console.WriteLine($"❌ Versículo {referencia} não encontrado!");
                    return null!;
                }
            }
            else
            {
                Console.WriteLine($"♻️ Reutilizando versículo flyweight: {referencia}");
            }

            return _versiculos[referencia];
        }

        public static int GetTotalVersiculosCriados()
        {
            return _versiculos.Count;
        }

        public static void MostrarEstatisticas()
        {
            Console.WriteLine($"📊 Total de versículos flyweight criados: {_versiculos.Count}");
            Console.WriteLine("📋 Versículos em memória:");
            foreach (var versiculo in _versiculos.Values)
            {
                Console.WriteLine($"   - {versiculo.GetReferencia()} ({versiculo.GetTema()})");
            }
        }

        // Simulação de banco de dados de versículos
        private static (string Texto, string Referencia, string Tema)? ObterDadosVersiculo(string referencia)
        {
            var bancoDados = new Dictionary<string, (string, string, string)>
            {
                ["João 3:16"] = ("Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito, para que todo aquele que nele crê não pereça, mas tenha a vida eterna.", "João 3:16", "Salvação"),
                ["Salmos 23:1"] = ("O Senhor é o meu pastor, nada me faltará.", "Salmos 23:1", "Confiança"),
                ["Filipenses 4:13"] = ("Posso todas as coisas em Cristo que me fortalece.", "Filipenses 4:13", "Força"),
                ["Romanos 8:28"] = ("E sabemos que todas as coisas contribuem juntamente para o bem daqueles que amam a Deus.", "Romanos 8:28", "Providência"),
                ["Jeremias 29:11"] = ("Porque eu bem sei os pensamentos que tenho a vosso respeito, diz o Senhor; pensamentos de paz, e não de mal, para vos dar o fim que esperais.", "Jeremias 29:11", "Esperança"),
                ["Provérbios 3:5-6"] = ("Confia no Senhor de todo o teu coração, e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas.", "Provérbios 3:5-6", "Confiança"),
                ["1 Coríntios 13:4"] = ("O amor é sofredor, é benigno; o amor não é invejoso; o amor não trata com leviandade, não se ensoberbece.", "1 Coríntios 13:4", "Amor"),
                ["Mateus 28:19"] = ("Portanto ide, fazei discípulos de todas as nações, batizando-os em nome do Pai, e do Filho, e do Espírito Santo.", "Mateus 28:19", "Missão"),
                ["Efésios 2:8"] = ("Porque pela graça sois salvos, por meio da fé; e isto não vem de vós, é dom de Deus.", "Efésios 2:8", "Graça"),
                ["Isaías 40:31"] = ("Mas os que esperam no Senhor renovarão as forças, subirão com asas como águias; correrão, e não se cansarão; caminharão, e não se fatigarão.", "Isaías 40:31", "Renovação")
            };

            return bancoDados.ContainsKey(referencia) ? bancoDados[referencia] : null;
        }
    }

    // Context - Representa o uso específico de um versículo (estado extrínseco)
    public class AplicacaoVersiculo
    {
        private VersiculoBiblico _versiculo;
        private string _contexto;
        private string _aplicacao;
        private string _pessoa;

        public AplicacaoVersiculo(string referencia, string contexto, string aplicacao, string pessoa)
        {
            _versiculo = FabricaVersiculos.GetVersiculo(referencia);
            _contexto = contexto;
            _aplicacao = aplicacao;
            _pessoa = pessoa;
        }

        public void Aplicar()
        {
            if (_versiculo != null)
            {
                Console.WriteLine($"👤 {_pessoa} está aplicando:");
                _versiculo.MostrarVersiculo(_contexto, _aplicacao);
            }
        }
    }

    // Cliente que usa múltiplas aplicações de versículos
    public class EstudoBiblico
    {
        private List<AplicacaoVersiculo> _aplicacoes = new List<AplicacaoVersiculo>();

        public void AdicionarAplicacao(string referencia, string contexto, string aplicacao, string pessoa)
        {
            _aplicacoes.Add(new AplicacaoVersiculo(referencia, contexto, aplicacao, pessoa));
        }

        public void RealizarEstudo()
        {
            Console.WriteLine("=== ESTUDO BÍBLICO EM GRUPO ===\n");
            foreach (var aplicacao in _aplicacoes)
            {
                aplicacao.Aplicar();
            }
        }
    }

    // Aplicação de exemplo
    public class MinhaAppFlyweight
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO FLYWEIGHT: Versículos Bíblicos ===\n");

            Console.WriteLine("--- Demonstrando Reutilização de Versículos ---\n");

            // Criando estudo bíblico
            var estudo = new EstudoBiblico();

            // Múltiplas pessoas usando os mesmos versículos em contextos diferentes
            estudo.AdicionarAplicacao("João 3:16", "Evangelismo", "Compartilhar o amor de Deus", "Pastor João");
            estudo.AdicionarAplicacao("João 3:16", "Aconselhamento", "Mostrar o amor incondicional de Deus", "Conselheira Maria");
            estudo.AdicionarAplicacao("Salmos 23:1", "Momento difícil", "Encontrar paz na tempestade", "Irmão Pedro");
            estudo.AdicionarAplicacao("Filipenses 4:13", "Desafio pessoal", "Ter força para superar obstáculos", "Jovem Ana");
            estudo.AdicionarAplicacao("Salmos 23:1", "Oração matinal", "Começar o dia confiando em Deus", "Irmã Sara");
            estudo.AdicionarAplicacao("Filipenses 4:13", "Testemunho", "Compartilhar vitórias em Cristo", "Diácono Paulo");

            // Realizando o estudo
            estudo.RealizarEstudo();

            Console.WriteLine("--- Estatísticas de Uso ---");
            FabricaVersiculos.MostrarEstatisticas();
            Console.WriteLine();

            Console.WriteLine("--- Demonstrando Eficiência do Flyweight ---\n");

            // Simulando um aplicativo de versículos diários
            Console.WriteLine("📱 APLICATIVO DE VERSÍCULOS DIÁRIOS\n");

            var aplicacoes = new List<AplicacaoVersiculo>();

            // 20 pessoas usando versículos (muitos repetidos)
            string[] pessoas = { "João", "Maria", "Pedro", "Ana", "Paulo", "Sara", "Tiago", "Marta", "Lucas", "Priscila",
                               "Barnabé", "Lídia", "Timóteo", "Débora", "Silas", "Ester", "Davi", "Rute", "Samuel", "Raquel" };

            string[] referencias = { "João 3:16", "Salmos 23:1", "Filipenses 4:13", "Romanos 8:28", "Jeremias 29:11" };
            string[] contextos = { "Devocional matinal", "Momento de oração", "Reflexão noturna", "Estudo pessoal", "Meditação" };
            string[] aplicacoes_lista = { "Fortalecer a fé", "Buscar direção", "Encontrar paz", "Crescer espiritualmente", "Adorar a Deus" };

            Random random = new Random();

            for (int i = 0; i < 50; i++) // 50 aplicações de versículos
            {
                string pessoa = pessoas[random.Next(pessoas.Length)];
                string referencia = referencias[random.Next(referencias.Length)];
                string contexto = contextos[random.Next(contextos.Length)];
                string aplicacao = aplicacoes_lista[random.Next(aplicacoes_lista.Length)];

                aplicacoes.Add(new AplicacaoVersiculo(referencia, contexto, aplicacao, pessoa));
            }

            Console.WriteLine($"📊 Criadas {aplicacoes.Count} aplicações de versículos");
            Console.WriteLine($"📖 Apenas {FabricaVersiculos.GetTotalVersiculosCriados()} objetos versículo foram criados na memória!");
            Console.WriteLine($"💾 Economia de memória: {aplicacoes.Count - FabricaVersiculos.GetTotalVersiculosCriados()} objetos poupados\n");

            Console.WriteLine("--- Exemplo de Aplicações Criadas ---");
            for (int i = 0; i < 5; i++)
            {
                aplicacoes[i].Aplicar();
            }

            Console.WriteLine("💡 VANTAGENS DO FLYWEIGHT:");
            Console.WriteLine("- Reduz drasticamente o uso de memória");
            Console.WriteLine("- Reutiliza objetos com estado intrínseco comum");
            Console.WriteLine("- Separa estado intrínseco (versículo) do extrínseco (aplicação)");
            Console.WriteLine("- Ideal para grandes quantidades de objetos similares");
        }
    }
}

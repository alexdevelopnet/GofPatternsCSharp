using System;
using System.Collections.Generic;

namespace Estruturais.Proxy
{
    // Subject - Interface comum para acesso às escrituras
    public interface IEscriturasSagradas
    {
        void LerCapitulo(string livro, int capitulo);
        void EstudarVersiculo(string referencia);
        void PesquisarTema(string tema);
        void MostrarHistoricoAcesso();
    }

    // RealSubject - Acesso real às escrituras (recurso "pesado")
    public class EscriturasSagradas : IEscriturasSagradas
    {
        private Dictionary<string, Dictionary<int, string>> _biblia = null!;
        private List<string> _historicoAcesso = null!;

        public EscriturasSagradas()
        {
            Console.WriteLine("📚 Carregando Escrituras Sagradas completas...");
            Console.WriteLine("⏳ Inicializando banco de dados bíblico...");
            
            // Simulando carregamento pesado
            System.Threading.Thread.Sleep(1000);
            
            _historicoAcesso = new List<string>();
            InicializarBiblia();
            
            Console.WriteLine("✅ Escrituras Sagradas carregadas com sucesso!");
            Console.WriteLine();
        }

        private void InicializarBiblia()
        {
            _biblia = new Dictionary<string, Dictionary<int, string>>
            {
                ["Gênesis"] = new Dictionary<int, string>
                {
                    [1] = "No princípio criou Deus os céus e a terra...",
                    [3] = "E chamou Deus à luz Dia; e às trevas chamou Noite..."
                },
                ["Êxodo"] = new Dictionary<int, string>
                {
                    [20] = "Então falou Deus todas estas palavras, dizendo: Eu sou o Senhor teu Deus..."
                },
                ["Salmos"] = new Dictionary<int, string>
                {
                    [23] = "O Senhor é o meu pastor, nada me faltará...",
                    [91] = "Aquele que habita no esconderijo do Altíssimo..."
                },
                ["João"] = new Dictionary<int, string>
                {
                    [1] = "No princípio era o Verbo, e o Verbo estava com Deus...",
                    [3] = "Havia entre os fariseus um homem, chamado Nicodemos..."
                },
                ["Romanos"] = new Dictionary<int, string>
                {
                    [8] = "Portanto, agora nenhuma condenação há para os que estão em Cristo Jesus..."
                }
            };
        }

        public void LerCapitulo(string livro, int capitulo)
        {
            string acesso = $"Leitura: {livro} {capitulo}";
            _historicoAcesso.Add($"{DateTime.Now:HH:mm:ss} - {acesso}");
            
            Console.WriteLine($"📖 Acessando {livro}, capítulo {capitulo}...");
            
            if (_biblia.ContainsKey(livro) && _biblia[livro].ContainsKey(capitulo))
            {
                Console.WriteLine($"📜 {livro} {capitulo}: {_biblia[livro][capitulo]}");
            }
            else
            {
                Console.WriteLine($"❌ Capítulo não encontrado: {livro} {capitulo}");
            }
            Console.WriteLine();
        }

        public void EstudarVersiculo(string referencia)
        {
            string acesso = $"Estudo: {referencia}";
            _historicoAcesso.Add($"{DateTime.Now:HH:mm:ss} - {acesso}");
            
            Console.WriteLine($"🔍 Estudando versículo: {referencia}");
            Console.WriteLine($"📝 Análise exegética e contexto histórico de {referencia}");
            Console.WriteLine($"🎯 Aplicação prática para os dias atuais");
            Console.WriteLine();
        }

        public void PesquisarTema(string tema)
        {
            string acesso = $"Pesquisa: {tema}";
            _historicoAcesso.Add($"{DateTime.Now:HH:mm:ss} - {acesso}");
            
            Console.WriteLine($"🔎 Pesquisando tema: '{tema}' nas Escrituras...");
            Console.WriteLine($"📚 Encontrados múltiplos versículos sobre '{tema}'");
            Console.WriteLine($"🔗 Referências cruzadas e concordância bíblica");
            Console.WriteLine();
        }

        public void MostrarHistoricoAcesso()
        {
            Console.WriteLine("📊 HISTÓRICO DE ACESSO ÀS ESCRITURAS:");
            foreach (var acesso in _historicoAcesso)
            {
                Console.WriteLine($"   {acesso}");
            }
            Console.WriteLine();
        }
    }

    // Proxy - Controla acesso às escrituras com funcionalidades adicionais
    public class ProxyEscrituras : IEscriturasSagradas
    {
        private EscriturasSagradas? _escriturasReais;
        private string _nivelAcesso;
        private List<string> _logAcessos;
        private Dictionary<string, string> _cache;
        private bool _modoOffline;

        public ProxyEscrituras(string nivelAcesso, bool modoOffline = false)
        {
            _nivelAcesso = nivelAcesso;
            _logAcessos = new List<string>();
            _cache = new Dictionary<string, string>();
            _modoOffline = modoOffline;
            
            Console.WriteLine($"🛡️ Proxy de Escrituras inicializado");
            Console.WriteLine($"👤 Nível de acesso: {_nivelAcesso}");
            Console.WriteLine($"🌐 Modo: {(_modoOffline ? "Offline" : "Online")}");
            Console.WriteLine();
        }

        private void InicializarEscrituras()
        {
            if (_escriturasReais == null)
            {
                Console.WriteLine("🔄 Primeira vez acessando - carregando Escrituras...");
                _escriturasReais = new EscriturasSagradas();
            }
        }

        private bool VerificarPermissao(string operacao)
        {
            // Simulando controle de acesso baseado em níveis
            switch (_nivelAcesso.ToLower())
            {
                case "visitante":
                    return operacao == "ler";
                case "membro":
                    return operacao == "ler" || operacao == "pesquisar";
                case "lider":
                case "pastor":
                    return true; // Acesso total
                default:
                    return false;
            }
        }

        private void LogarAcesso(string operacao, string detalhes)
        {
            string log = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {_nivelAcesso} - {operacao}: {detalhes}";
            _logAcessos.Add(log);
            Console.WriteLine($"📝 Log: {operacao} por {_nivelAcesso}");
        }

        public void LerCapitulo(string livro, int capitulo)
        {
            LogarAcesso("Leitura", $"{livro} {capitulo}");

            if (!VerificarPermissao("ler"))
            {
                Console.WriteLine($"🚫 Acesso negado! {_nivelAcesso} não tem permissão para ler.");
                return;
            }

            string chaveCache = $"{livro}_{capitulo}";
            
            if (_modoOffline && _cache.ContainsKey(chaveCache))
            {
                Console.WriteLine($"💾 Carregando do cache offline: {livro} {capitulo}");
                Console.WriteLine($"📜 {_cache[chaveCache]}");
                return;
            }

            InicializarEscrituras();
            _escriturasReais?.LerCapitulo(livro, capitulo);
            
            // Adicionando ao cache para modo offline
            _cache[chaveCache] = $"{livro} {capitulo} - conteúdo em cache";
        }

        public void EstudarVersiculo(string referencia)
        {
            LogarAcesso("Estudo", referencia);

            if (!VerificarPermissao("estudar"))
            {
                Console.WriteLine($"🚫 Acesso negado! {_nivelAcesso} não tem permissão para estudos avançados.");
                Console.WriteLine($"💡 Sugestão: Solicite acesso de 'Membro' ou superior.");
                return;
            }

            if (_modoOffline)
            {
                Console.WriteLine($"📵 Modo offline - estudo limitado para: {referencia}");
                Console.WriteLine($"📖 Conteúdo básico disponível offline");
                return;
            }

            InicializarEscrituras();
            _escriturasReais?.EstudarVersiculo(referencia);
        }

        public void PesquisarTema(string tema)
        {
            LogarAcesso("Pesquisa", tema);

            if (!VerificarPermissao("pesquisar"))
            {
                Console.WriteLine($"🚫 Acesso negado! {_nivelAcesso} não tem permissão para pesquisas.");
                Console.WriteLine($"💡 Sugestão: Solicite acesso de 'Membro' ou superior.");
                return;
            }

            if (_modoOffline)
            {
                Console.WriteLine($"📵 Modo offline - pesquisa limitada para: '{tema}'");
                Console.WriteLine($"🔍 Apenas resultados em cache disponíveis");
                return;
            }

            InicializarEscrituras();
            _escriturasReais?.PesquisarTema(tema);
        }

        public void MostrarHistoricoAcesso()
        {
            Console.WriteLine("📊 HISTÓRICO DE ACESSO DO PROXY:");
            foreach (var log in _logAcessos)
            {
                Console.WriteLine($"   {log}");
            }
            Console.WriteLine();

            if (_escriturasReais != null && VerificarPermissao("historico"))
            {
                _escriturasReais.MostrarHistoricoAcesso();
            }
            else
            {
                Console.WriteLine("ℹ️ Histórico detalhado disponível apenas para líderes");
            }
        }

        public void MostrarCache()
        {
            Console.WriteLine("💾 CONTEÚDO EM CACHE:");
            foreach (var item in _cache)
            {
                Console.WriteLine($"   {item.Key}: {item.Value}");
            }
            Console.WriteLine();
        }

        public void AlternarModoOffline()
        {
            _modoOffline = !_modoOffline;
            Console.WriteLine($"🔄 Modo alterado para: {(_modoOffline ? "Offline" : "Online")}");
        }
    }

    // Aplicação de exemplo
    public class MinhaAppProxy
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO PROXY: Acesso às Escrituras Sagradas ===\n");

            Console.WriteLine("--- Demonstrando Controle de Acesso ---\n");

            // Visitante com acesso limitado
            Console.WriteLine("🚶 VISITANTE tentando acessar:");
            var visitante = new ProxyEscrituras("Visitante");
            visitante.LerCapitulo("João", 3);
            visitante.EstudarVersiculo("João 3:16");
            visitante.PesquisarTema("Salvação");
            Console.WriteLine();

            // Membro com mais permissões
            Console.WriteLine("👤 MEMBRO acessando:");
            var membro = new ProxyEscrituras("Membro");
            membro.LerCapitulo("Salmos", 23);
            membro.PesquisarTema("Confiança");
            membro.EstudarVersiculo("Salmos 23:1");
            Console.WriteLine();

            // Pastor com acesso total
            Console.WriteLine("👨‍💼 PASTOR com acesso total:");
            var pastor = new ProxyEscrituras("Pastor");
            pastor.LerCapitulo("Gênesis", 1);
            pastor.EstudarVersiculo("Gênesis 1:1");
            pastor.PesquisarTema("Criação");
            pastor.MostrarHistoricoAcesso();

            Console.WriteLine("--- Demonstrando Modo Offline ---\n");

            // Modo offline com cache
            var membroOffline = new ProxyEscrituras("Membro", modoOffline: true);
            
            Console.WriteLine("Primeiro acesso (criará cache):");
            membroOffline.LerCapitulo("Romanos", 8);
            
            Console.WriteLine("Segundo acesso (usará cache):");
            membroOffline.LerCapitulo("Romanos", 8);
            
            membroOffline.MostrarCache();

            Console.WriteLine("--- Demonstrando Lazy Loading ---\n");
            
            Console.WriteLine("🔄 Criando novo proxy (sem carregar escrituras ainda):");
            var novoProxy = new ProxyEscrituras("Líder");
            
            Console.WriteLine("Primeira operação irá carregar as escrituras:");
            novoProxy.LerCapitulo("João", 1);
            
            Console.WriteLine("Operações subsequentes usam as escrituras já carregadas:");
            novoProxy.LerCapitulo("Salmos", 91);

            Console.WriteLine("\n💡 VANTAGENS DO PROXY:");
            Console.WriteLine("- Controla acesso ao objeto real");
            Console.WriteLine("- Implementa lazy loading (carregamento sob demanda)");
            Console.WriteLine("- Adiciona funcionalidades como cache e log");
            Console.WriteLine("- Permite controle de permissões");
            Console.WriteLine("- Suporte a modo offline");
        }
    }
}

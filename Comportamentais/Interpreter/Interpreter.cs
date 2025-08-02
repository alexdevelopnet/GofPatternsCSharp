using System;
using System.Collections.Generic;

namespace Comportamentais.Interpreter
{
    // Context - Contexto da interpretação
    public class ContextoEscritura
    {
        public Dictionary<string, string> Simbolos { get; set; } = new Dictionary<string, string>();
        public string TextoOriginal { get; set; }
        public string? Interpretacao { get; set; }

        public ContextoEscritura(string texto)
        {
            TextoOriginal = texto;
            InicializarSimbolos();
        }

        private void InicializarSimbolos()
        {
            // Símbolos bíblicos e seus significados
            Simbolos["cordeiro"] = "Jesus Cristo, o sacrifício perfeito";
            Simbolos["leão"] = "Jesus Cristo, o Rei dos reis";
            Simbolos["pomba"] = "Espírito Santo";
            Simbolos["água"] = "Palavra de Deus ou Espírito Santo";
            Simbolos["pão"] = "Jesus Cristo, o pão da vida";
            Simbolos["luz"] = "Jesus Cristo, a luz do mundo";
            Simbolos["pastor"] = "Jesus Cristo, o bom pastor";
            Simbolos["pedra"] = "Jesus Cristo, a pedra angular";
            Simbolos["videira"] = "Jesus Cristo, a videira verdadeira";
            Simbolos["porta"] = "Jesus Cristo, a porta das ovelhas";
            Simbolos["caminho"] = "Jesus Cristo, o caminho para o Pai";
            Simbolos["sete"] = "número da perfeição divina";
            Simbolos["doze"] = "número da completude (12 tribos, 12 apóstolos)";
            Simbolos["quarenta"] = "período de provação ou preparação";
        }
    }

    // Abstract Expression
    public abstract class ExpressaoEscritura
    {
        public abstract string Interpretar(ContextoEscritura contexto);
    }

    // Terminal Expression - Símbolo individual
    public class SimboloExpression : ExpressaoEscritura
    {
        private string _simbolo;

        public SimboloExpression(string simbolo)
        {
            _simbolo = simbolo.ToLower();
        }

        public override string Interpretar(ContextoEscritura contexto)
        {
            if (contexto.Simbolos.ContainsKey(_simbolo))
            {
                return contexto.Simbolos[_simbolo];
            }
            return _simbolo; // Retorna o símbolo original se não encontrar interpretação
        }
    }

    // Non-terminal Expression - Frase profética
    public class FraseProfeticaExpression : ExpressaoEscritura
    {
        private List<ExpressaoEscritura> _elementos = new List<ExpressaoEscritura>();

        public void AdicionarElemento(ExpressaoEscritura elemento)
        {
            _elementos.Add(elemento);
        }

        public override string Interpretar(ContextoEscritura contexto)
        {
            var interpretacao = "INTERPRETAÇÃO PROFÉTICA: ";
            foreach (var elemento in _elementos)
            {
                interpretacao += elemento.Interpretar(contexto) + " ";
            }
            return interpretacao.Trim();
        }
    }

    // Non-terminal Expression - Parábola
    public class ParabolaExpression : ExpressaoEscritura
    {
        private List<ExpressaoEscritura> _elementos = new List<ExpressaoEscritura>();
        private string _licaoMoral;

        public ParabolaExpression(string licaoMoral)
        {
            _licaoMoral = licaoMoral;
        }

        public void AdicionarElemento(ExpressaoEscritura elemento)
        {
            _elementos.Add(elemento);
        }

        public override string Interpretar(ContextoEscritura contexto)
        {
            var interpretacao = "PARÁBOLA - Significado simbólico: ";
            foreach (var elemento in _elementos)
            {
                interpretacao += elemento.Interpretar(contexto) + " ";
            }
            interpretacao += $"\nLição moral: {_licaoMoral}";
            return interpretacao;
        }
    }

    // Non-terminal Expression - Visão apocalíptica
    public class VisaoApocalipticaExpression : ExpressaoEscritura
    {
        private List<ExpressaoEscritura> _simbolos = new List<ExpressaoEscritura>();
        private string _significadoProfetico;

        public VisaoApocalipticaExpression(string significadoProfetico)
        {
            _significadoProfetico = significadoProfetico;
        }

        public void AdicionarSimbolo(ExpressaoEscritura simbolo)
        {
            _simbolos.Add(simbolo);
        }

        public override string Interpretar(ContextoEscritura contexto)
        {
            var interpretacao = "VISÃO APOCALÍPTICA - Símbolos: ";
            foreach (var simbolo in _simbolos)
            {
                interpretacao += "[" + simbolo.Interpretar(contexto) + "] ";
            }
            interpretacao += $"\nSignificado profético: {_significadoProfetico}";
            return interpretacao;
        }
    }

    // Cliente - Intérprete das Escrituras
    public class InterpreteEscrituras
    {
        public void InterpretarTexto(string texto, ContextoEscritura contexto)
        {
            Console.WriteLine($"TEXTO ORIGINAL: '{texto}'");
            Console.WriteLine("=====================================");

            var palavras = texto.ToLower().Split(' ');
            var interpretacao = "";

            foreach (var palavra in palavras)
            {
                var simbolo = new SimboloExpression(palavra.Trim(',', '.', '!', '?', ';', ':'));
                var significado = simbolo.Interpretar(contexto);
                
                if (significado != palavra.Trim(',', '.', '!', '?', ';', ':'))
                {
                    interpretacao += $"'{palavra}' = {significado}; ";
                }
            }

            if (!string.IsNullOrEmpty(interpretacao))
            {
                Console.WriteLine("SÍMBOLOS ENCONTRADOS:");
                Console.WriteLine(interpretacao);
            }
            else
            {
                Console.WriteLine("Nenhum símbolo específico encontrado para interpretação.");
            }
            Console.WriteLine();
        }

        public void InterpretarParabola()
        {
            Console.WriteLine("=== INTERPRETANDO PARÁBOLA DO BOM PASTOR ===");
            
            var parabola = new ParabolaExpression("Jesus cuida de suas ovelhas (crentes) com amor e proteção");
            parabola.AdicionarElemento(new SimboloExpression("pastor"));
            parabola.AdicionarElemento(new SimboloExpression("porta"));

            var contexto = new ContextoEscritura("parábola do bom pastor");
            Console.WriteLine(parabola.Interpretar(contexto));
            Console.WriteLine();
        }

        public void InterpretarVisaoApocaliptica()
        {
            Console.WriteLine("=== INTERPRETANDO VISÃO DO APOCALIPSE ===");
            
            var visao = new VisaoApocalipticaExpression("A vitória final de Cristo sobre o mal");
            visao.AdicionarSimbolo(new SimboloExpression("cordeiro"));
            visao.AdicionarSimbolo(new SimboloExpression("leão"));
            visao.AdicionarSimbolo(new SimboloExpression("sete"));

            var contexto = new ContextoEscritura("visão apocalíptica");
            Console.WriteLine(visao.Interpretar(contexto));
            Console.WriteLine();
        }
    }

    // Aplicação de exemplo
    public class MinhaAppInterpreter
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO INTERPRETER: Interpretação das Escrituras Sagradas ===\n");

            var interprete = new InterpreteEscrituras();
            var contexto = new ContextoEscritura("");

            // Interpretando versículos com símbolos
            Console.WriteLine("--- Interpretando João 10:9 ---");
            interprete.InterpretarTexto("Eu sou a porta; se alguém entrar por mim, salvar-se-á", contexto);

            Console.WriteLine("--- Interpretando João 6:35 ---");
            interprete.InterpretarTexto("Eu sou o pão da vida; aquele que vem a mim não terá fome", contexto);

            Console.WriteLine("--- Interpretando João 8:12 ---");
            interprete.InterpretarTexto("Eu sou a luz do mundo; quem me segue não andará em trevas", contexto);

            Console.WriteLine("--- Interpretando João 14:6 ---");
            interprete.InterpretarTexto("Eu sou o caminho, a verdade e a vida", contexto);

            Console.WriteLine("--- Interpretando João 15:1 ---");
            interprete.InterpretarTexto("Eu sou a videira verdadeira, e meu Pai é o lavrador", contexto);

            // Interpretando parábola
            interprete.InterpretarParabola();

            // Interpretando visão apocalíptica
            interprete.InterpretarVisaoApocaliptica();

            // Interpretando texto com números simbólicos
            Console.WriteLine("--- Interpretando Números Simbólicos ---");
            interprete.InterpretarTexto("Jesus jejuou quarenta dias no deserto", contexto);
            interprete.InterpretarTexto("Os doze apóstolos seguiram o cordeiro", contexto);
            interprete.InterpretarTexto("As sete igrejas receberam as cartas", contexto);
        }
    }
}

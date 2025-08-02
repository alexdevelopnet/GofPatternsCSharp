using System;
using System.Collections.Generic;

namespace Comportamentais.Visitor
{
    // Visitor Interface
    public interface IVisitanteDivino
    {
        void Visitar(Abraao abraao);
        void Visitar(Isaque isaque);
        void Visitar(Jaco jaco);
        void Visitar(Jose jose);
        void Visitar(Moises moises);
    }

    // Element Interface
    public interface IPatriarca
    {
        void AceitarVisitante(IVisitanteDivino visitante);
        string Nome { get; }
        int Idade { get; }
        string Localizacao { get; }
    }

    // Concrete Elements - Patriarcas
    public class Abraao : IPatriarca
    {
        public string Nome => "Abraão";
        public int Idade => 100;
        public string Localizacao => "Canaã";
        public bool TemFilho => false;

        public void AceitarVisitante(IVisitanteDivino visitante)
        {
            Console.WriteLine($"{Nome}: Recebendo visitante divino em {Localizacao}...");
            visitante.Visitar(this);
        }

        public void ReceberPromessa()
        {
            Console.WriteLine($"{Nome}: 'Como pode ser isso? Sara e eu somos muito idosos!'");
        }
    }

    public class Isaque : IPatriarca
    {
        public string Nome => "Isaque";
        public int Idade => 40;
        public string Localizacao => "Berseba";
        public bool EstaCasado => false;

        public void AceitarVisitante(IVisitanteDivino visitante)
        {
            Console.WriteLine($"{Nome}: Acolhendo o visitante em {Localizacao}...");
            visitante.Visitar(this);
        }

        public void ReceberBencao()
        {
            Console.WriteLine($"{Nome}: 'Que o Deus de meu pai Abraão me abençoe!'");
        }
    }

    public class Jaco : IPatriarca
    {
        public string Nome => "Jacó";
        public int Idade => 77;
        public string Localizacao => "Betel";
        public bool EstaFugindo => true;

        public void AceitarVisitante(IVisitanteDivino visitante)
        {
            Console.WriteLine($"{Nome}: Tendo um encontro divino em {Localizacao}...");
            visitante.Visitar(this);
        }

        public void LutarComAnjo()
        {
            Console.WriteLine($"{Nome}: 'Não te deixarei ir se não me abençoares!'");
        }
    }

    public class Jose : IPatriarca
    {
        public string Nome => "José";
        public int Idade => 30;
        public string Localizacao => "Egito";
        public bool EstaNaPrisao => false;

        public void AceitarVisitante(IVisitanteDivino visitante)
        {
            Console.WriteLine($"{Nome}: Recebendo revelação divina no {Localizacao}...");
            visitante.Visitar(this);
        }

        public void InterpretarSonhos()
        {
            Console.WriteLine($"{Nome}: 'As interpretações não pertencem a Deus?'");
        }
    }

    public class Moises : IPatriarca
    {
        public string Nome => "Moisés";
        public int Idade => 80;
        public string Localizacao => "Monte Sinai";
        public bool TemVara => true;

        public void AceitarVisitante(IVisitanteDivino visitante)
        {
            Console.WriteLine($"{Nome}: Encontrando-se com o Divino no {Localizacao}...");
            visitante.Visitar(this);
        }

        public void ReceberLei()
        {
            Console.WriteLine($"{Nome}: 'Fala, Senhor, que teu servo ouve!'");
        }
    }

    // Concrete Visitors
    public class AnjoDoSenhor : IVisitanteDivino
    {
        public void Visitar(Abraao abraao)
        {
            Console.WriteLine("Anjo do Senhor: 'Abraão! Sara terá um filho no próximo ano!'");
            abraao.ReceberPromessa();
            Console.WriteLine("Anjo: 'Há algo impossível para o Senhor?'");
        }

        public void Visitar(Isaque isaque)
        {
            Console.WriteLine("Anjo do Senhor: 'Isaque, não desças ao Egito. Fica na terra que te mostrarei!'");
            isaque.ReceberBencao();
            Console.WriteLine("Anjo: 'Confirmo contigo a aliança que fiz com Abraão!'");
        }

        public void Visitar(Jaco jaco)
        {
            Console.WriteLine("Anjo do Senhor: 'Teu nome não será mais Jacó, mas Israel!'");
            jaco.LutarComAnjo();
            Console.WriteLine("Anjo: 'Lutaste com Deus e com os homens e prevaleceste!'");
        }

        public void Visitar(Jose jose)
        {
            Console.WriteLine("Anjo do Senhor: 'José, interpretarás os sonhos de Faraó!'");
            jose.InterpretarSonhos();
            Console.WriteLine("Anjo: 'Deus te dará sabedoria para salvar muitas vidas!'");
        }

        public void Visitar(Moises moises)
        {
            Console.WriteLine("Anjo do Senhor: 'Moisés, tira as sandálias, pois este é lugar santo!'");
            moises.ReceberLei();
            Console.WriteLine("Anjo: 'Eu sou o que sou. Vai libertar meu povo!'");
        }
    }

    public class EspiritoSanto : IVisitanteDivino
    {
        public void Visitar(Abraao abraao)
        {
            Console.WriteLine("Espírito Santo: Enchendo Abraão de fé para crer no impossível...");
            abraao.ReceberPromessa();
            Console.WriteLine("Espírito Santo: 'Pela fé, Abraão creu contra toda esperança!'");
        }

        public void Visitar(Isaque isaque)
        {
            Console.WriteLine("Espírito Santo: Dando a Isaque discernimento espiritual...");
            isaque.ReceberBencao();
            Console.WriteLine("Espírito Santo: 'Isaque será canal de bênção para as nações!'");
        }

        public void Visitar(Jaco jaco)
        {
            Console.WriteLine("Espírito Santo: Transformando o coração de Jacó...");
            jaco.LutarComAnjo();
            Console.WriteLine("Espírito Santo: 'De enganador a príncipe com Deus!'");
        }

        public void Visitar(Jose jose)
        {
            Console.WriteLine("Espírito Santo: Dando a José o dom de interpretação...");
            jose.InterpretarSonhos();
            Console.WriteLine("Espírito Santo: 'José será instrumento de preservação!'");
        }

        public void Visitar(Moises moises)
        {
            Console.WriteLine("Espírito Santo: Capacitando Moisés para liderar o povo...");
            moises.ReceberLei();
            Console.WriteLine("Espírito Santo: 'Moisés será o maior legislador da história!'");
        }
    }

    public class Jesus : IVisitanteDivino
    {
        public void Visitar(Abraao abraao)
        {
            Console.WriteLine("Jesus: 'Abraão, vosso pai, exultou por ver o meu dia!'");
            abraao.ReceberPromessa();
            Console.WriteLine("Jesus: 'Antes que Abraão existisse, EU SOU!'");
        }

        public void Visitar(Isaque isaque)
        {
            Console.WriteLine("Jesus: 'Isaque, você prefigurou meu sacrifício no Calvário!'");
            isaque.ReceberBencao();
            Console.WriteLine("Jesus: 'Como Isaque foi poupado, eu fui entregue!'");
        }

        public void Visitar(Jaco jaco)
        {
            Console.WriteLine("Jesus: 'Jacó, você viu a escada que liga a terra ao céu!'");
            jaco.LutarComAnjo();
            Console.WriteLine("Jesus: 'Eu sou essa escada - o caminho entre Deus e os homens!'");
        }

        public void Visitar(Jose jose)
        {
            Console.WriteLine("Jesus: 'José, você foi tipo de mim - rejeitado pelos irmãos, mas salvador do mundo!'");
            jose.InterpretarSonhos();
            Console.WriteLine("Jesus: 'Como José salvou do fome física, eu salvo da fome espiritual!'");
        }

        public void Visitar(Moises moises)
        {
            Console.WriteLine("Jesus: 'Moisés, você foi fiel como servo, eu como Filho!'");
            moises.ReceberLei();
            Console.WriteLine("Jesus: 'A Lei veio por Moisés, a graça e a verdade vieram por mim!'");
        }
    }

    // Object Structure
    public class LinhagemAbramica
    {
        private List<IPatriarca> _patriarcas = new List<IPatriarca>();

        public LinhagemAbramica()
        {
            _patriarcas.Add(new Abraao());
            _patriarcas.Add(new Isaque());
            _patriarcas.Add(new Jaco());
            _patriarcas.Add(new Jose());
            _patriarcas.Add(new Moises());
        }

        public void ReceberVisitacao(IVisitanteDivino visitante)
        {
            Console.WriteLine($"=== VISITAÇÃO DIVINA À LINHAGEM ABRAÂMICA ===");
            Console.WriteLine($"Visitante: {visitante.GetType().Name}\n");

            foreach (var patriarca in _patriarcas)
            {
                Console.WriteLine($"--- Visitando {patriarca.Nome} ---");
                patriarca.AceitarVisitante(visitante);
                Console.WriteLine();
            }
        }
    }

    // Aplicação de exemplo
    public class MinhaAppVisitor
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO VISITOR: Visitação Divina aos Patriarcas ===\n");

            var linhagem = new LinhagemAbramica();

            // Visitação do Anjo do Senhor
            Console.WriteLine("🔥 PRIMEIRA VISITAÇÃO 🔥");
            var anjo = new AnjoDoSenhor();
            linhagem.ReceberVisitacao(anjo);

            Console.WriteLine("\n" + new string('=', 60) + "\n");

            // Visitação do Espírito Santo
            Console.WriteLine("🕊️ SEGUNDA VISITAÇÃO 🕊️");
            var espiritoSanto = new EspiritoSanto();
            linhagem.ReceberVisitacao(espiritoSanto);

            Console.WriteLine("\n" + new string('=', 60) + "\n");

            // Visitação de Jesus
            Console.WriteLine("✝️ TERCEIRA VISITAÇÃO ✝️");
            var jesus = new Jesus();
            linhagem.ReceberVisitacao(jesus);

            Console.WriteLine("\n=== CONCLUSÃO ===");
            Console.WriteLine("Cada visitante divino trouxe uma perspectiva única para cada patriarca,");
            Console.WriteLine("demonstrando como o mesmo elemento pode ser processado de diferentes formas!");
        }
    }
}

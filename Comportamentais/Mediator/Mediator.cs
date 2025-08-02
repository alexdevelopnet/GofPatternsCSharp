using System;
using System.Collections.Generic;

namespace Comportamentais.Mediator
{
    // Mediator Interface
    public interface IConselhoMediator
    {
        void EnviarMensagem(string mensagem, Apostolo remetente);
        void RegistrarApostolo(Apostolo apostolo);
        void TomarDecisao(string questao);
    }

    // Colleague base class
    public abstract class Apostolo
    {
        protected IConselhoMediator _mediator;
        protected string _nome;

        public Apostolo(string nome, IConselhoMediator mediator)
        {
            _nome = nome;
            _mediator = mediator;
        }

        public abstract void ReceberMensagem(string mensagem, Apostolo remetente);
        public abstract void DarOpiniao(string questao);

        public void EnviarMensagem(string mensagem)
        {
            _mediator.EnviarMensagem(mensagem, this);
        }

        public string Nome => _nome;
    }

    // Concrete Colleagues
    public class Pedro : Apostolo
    {
        public Pedro(IConselhoMediator mediator) : base("Pedro", mediator) { }

        public override void ReceberMensagem(string mensagem, Apostolo remetente)
        {
            Console.WriteLine($"Pedro recebeu mensagem de {remetente.Nome}: '{mensagem}'");
            if (mensagem.Contains("gentios"))
            {
                Console.WriteLine("Pedro: 'Lembro-me da visão do lençol! Deus não faz acepção de pessoas!'");
            }
        }

        public override void DarOpiniao(string questao)
        {
            if (questao.Contains("circuncisão"))
            {
                Console.WriteLine("Pedro: 'Por que tentais a Deus, pondo sobre os gentios um jugo que nem nossos pais nem nós pudemos suportar?'");
            }
        }
    }

    public class Paulo : Apostolo
    {
        public Paulo(IConselhoMediator mediator) : base("Paulo", mediator) { }

        public override void ReceberMensagem(string mensagem, Apostolo remetente)
        {
            Console.WriteLine($"Paulo recebeu mensagem de {remetente.Nome}: '{mensagem}'");
            if (mensagem.Contains("Lei"))
            {
                Console.WriteLine("Paulo: 'A Lei foi nosso aio para nos conduzir a Cristo!'");
            }
        }

        public override void DarOpiniao(string questao)
        {
            if (questao.Contains("gentios"))
            {
                Console.WriteLine("Paulo: 'Fui chamado especificamente para pregar aos gentios! Eles devem ser aceitos pela fé!'");
            }
        }
    }

    public class Barnabe : Apostolo
    {
        public Barnabe(IConselhoMediator mediator) : base("Barnabé", mediator) { }

        public override void ReceberMensagem(string mensagem, Apostolo remetente)
        {
            Console.WriteLine($"Barnabé recebeu mensagem de {remetente.Nome}: '{mensagem}'");
            if (mensagem.Contains("milagres"))
            {
                Console.WriteLine("Barnabé: 'Sim! Vimos Deus operar grandes sinais entre os gentios!'");
            }
        }

        public override void DarOpiniao(string questao)
        {
            if (questao.Contains("testemunho"))
            {
                Console.WriteLine("Barnabé: 'Posso testemunhar dos milagres que Deus fez através de Paulo entre os gentios!'");
            }
        }
    }

    public class Tiago : Apostolo
    {
        public Tiago(IConselhoMediator mediator) : base("Tiago", mediator) { }

        public override void ReceberMensagem(string mensagem, Apostolo remetente)
        {
            Console.WriteLine($"Tiago recebeu mensagem de {remetente.Nome}: '{mensagem}'");
            if (mensagem.Contains("decisão"))
            {
                Console.WriteLine("Tiago: 'Como líder da igreja em Jerusalém, preciso ponderar cuidadosamente.'");
            }
        }

        public override void DarOpiniao(string questao)
        {
            if (questao.Contains("resolução"))
            {
                Console.WriteLine("Tiago: 'Julgo que não se deve perturbar os gentios que se convertem a Deus, mas apenas pedir que se abstenham de carnes sacrificadas aos ídolos, do sangue, da carne de animais sufocados e da impureza sexual.'");
            }
        }
    }

    // Concrete Mediator
    public class ConselhoJerusalem : IConselhoMediator
    {
        private List<Apostolo> _apostolos = new List<Apostolo>();

        public void RegistrarApostolo(Apostolo apostolo)
        {
            _apostolos.Add(apostolo);
            Console.WriteLine($"{apostolo.Nome} foi registrado no Conselho de Jerusalém.");
        }

        public void EnviarMensagem(string mensagem, Apostolo remetente)
        {
            Console.WriteLine($"\n--- {remetente.Nome} está falando ao conselho ---");
            Console.WriteLine($"{remetente.Nome}: '{mensagem}'");
            
            foreach (var apostolo in _apostolos)
            {
                if (apostolo != remetente)
                {
                    apostolo.ReceberMensagem(mensagem, remetente);
                }
            }
            Console.WriteLine();
        }

        public void TomarDecisao(string questao)
        {
            Console.WriteLine($"\n=== DELIBERAÇÃO DO CONSELHO SOBRE: {questao.ToUpper()} ===");
            
            foreach (var apostolo in _apostolos)
            {
                apostolo.DarOpiniao(questao);
            }

            Console.WriteLine("\n--- DECISÃO FINAL DO CONSELHO ---");
            
            if (questao.Contains("gentios") || questao.Contains("circuncisão"))
            {
                Console.WriteLine("CONSELHO DE JERUSALÉM DECIDE:");
                Console.WriteLine("1. Os gentios podem se converter sem circuncisão");
                Console.WriteLine("2. Devem apenas se abster de:");
                Console.WriteLine("   - Carnes sacrificadas aos ídolos");
                Console.WriteLine("   - Sangue");
                Console.WriteLine("   - Carne de animais sufocados");
                Console.WriteLine("   - Impureza sexual");
                Console.WriteLine("3. Esta decisão será comunicada por carta às igrejas");
            }
        }
    }

    // Aplicação de exemplo
    public class MinhaAppMediator
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO MEDIATOR: Conselho de Jerusalém (Atos 15) ===\n");

            // Criando o mediator
            var conselho = new ConselhoJerusalem();

            // Criando os participantes
            var pedro = new Pedro(conselho);
            var paulo = new Paulo(conselho);
            var barnabe = new Barnabe(conselho);
            var tiago = new Tiago(conselho);

            // Registrando no conselho
            Console.WriteLine("--- Formação do Conselho ---");
            conselho.RegistrarApostolo(pedro);
            conselho.RegistrarApostolo(paulo);
            conselho.RegistrarApostolo(barnabe);
            conselho.RegistrarApostolo(tiago);
            Console.WriteLine();

            // Início da discussão
            Console.WriteLine("--- INÍCIO DO CONSELHO DE JERUSALÉM ---");
            paulo.EnviarMensagem("Irmãos, alguns homens desceram da Judéia e ensinavam: 'Se não vos circuncidardes segundo o costume de Moisés, não podeis ser salvos.' Precisamos resolver esta questão!");

            pedro.EnviarMensagem("Eu tive uma visão de Deus sobre os gentios. Deus purificou seus corações pela fé!");

            barnabe.EnviarMensagem("Paulo e eu testemunhamos grandes milagres que Deus operou entre os gentios!");

            tiago.EnviarMensagem("Como líder desta igreja, proponho que tomemos uma decisão final sobre esta questão importante.");

            // Tomada de decisão
            conselho.TomarDecisao("gentios e circuncisão - resolução final");
        }
    }
}

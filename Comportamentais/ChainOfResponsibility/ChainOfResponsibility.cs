using System;

namespace Comportamentais.ChainOfResponsibility
{
    // Handler abstrato
    public abstract class IntercessorHandler
    {
        protected IntercessorHandler? _proximoIntercessor;

        public void DefinirProximo(IntercessorHandler proximo)
        {
            _proximoIntercessor = proximo;
        }

        public abstract void Interceder(PedidoOracao pedido);

        protected void PassarAdiante(PedidoOracao pedido)
        {
            if (_proximoIntercessor != null)
            {
                _proximoIntercessor.Interceder(pedido);
            }
            else
            {
                Console.WriteLine("Pedido chegou ao trono da graça de Deus!");
            }
        }
    }

    // Classe para representar um pedido de oração
    public class PedidoOracao
    {
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public int Urgencia { get; set; } // 1-baixa, 2-média, 3-alta, 4-crítica

        public PedidoOracao(string tipo, string descricao, int urgencia)
        {
            Tipo = tipo;
            Descricao = descricao;
            Urgencia = urgencia;
        }
    }

    // Concrete Handlers
    public class CristoIntercessor : IntercessorHandler
    {
        public override void Interceder(PedidoOracao pedido)
        {
            Console.WriteLine($"Jesus Cristo (Sumo Sacerdote): Recebendo pedido - {pedido.Descricao}");
            
            if (pedido.Urgencia >= 4) // Crítica
            {
                Console.WriteLine("Jesus: 'Este pedido é crítico. Eu mesmo intercedo diretamente ao Pai!'");
                Console.WriteLine("Jesus: 'Pai, em meu nome, atende este pedido urgente!'");
            }
            else
            {
                Console.WriteLine("Jesus: 'Passando este pedido através da cadeia de intercessão...'");
                PassarAdiante(pedido);
            }
        }
    }

    public class EspiritoSantoIntercessor : IntercessorHandler
    {
        public override void Interceder(PedidoOracao pedido)
        {
            Console.WriteLine($"Espírito Santo: Analisando pedido - {pedido.Descricao}");
            
            if (pedido.Urgencia >= 3 && pedido.Tipo.Contains("cura"))
            {
                Console.WriteLine("Espírito Santo: 'Este pedido de cura requer minha intervenção direta!'");
                Console.WriteLine("Espírito Santo: 'Intercedendo com gemidos inexprimíveis...'");
            }
            else
            {
                Console.WriteLine("Espírito Santo: 'Direcionando para o próximo intercessor...'");
                PassarAdiante(pedido);
            }
        }
    }

    public class AnjoIntercessor : IntercessorHandler
    {
        private string _nome;

        public AnjoIntercessor(string nome)
        {
            _nome = nome;
        }

        public override void Interceder(PedidoOracao pedido)
        {
            Console.WriteLine($"Anjo {_nome}: Recebendo pedido - {pedido.Descricao}");
            
            if (pedido.Urgencia >= 2 && pedido.Tipo.Contains("proteção"))
            {
                Console.WriteLine($"Anjo {_nome}: 'Este pedido de proteção está sob minha responsabilidade!'");
                Console.WriteLine($"Anjo {_nome}: 'Mobilizando hostes angelicais para proteção!'");
            }
            else
            {
                Console.WriteLine($"Anjo {_nome}: 'Encaminhando para o próximo nível...'");
                PassarAdiante(pedido);
            }
        }
    }

    public class PastorIntercessor : IntercessorHandler
    {
        private string _nome;

        public PastorIntercessor(string nome)
        {
            _nome = nome;
        }

        public override void Interceder(PedidoOracao pedido)
        {
            Console.WriteLine($"Pastor {_nome}: Recebendo pedido - {pedido.Descricao}");
            
            if (pedido.Urgencia >= 1 && pedido.Tipo.Contains("orientação"))
            {
                Console.WriteLine($"Pastor {_nome}: 'Posso ajudar com orientação espiritual!'");
                Console.WriteLine($"Pastor {_nome}: 'Orando e aconselhando baseado na Palavra...'");
            }
            else
            {
                Console.WriteLine($"Pastor {_nome}: 'Este pedido precisa de intercessão mais alta...'");
                PassarAdiante(pedido);
            }
        }
    }

    public class IrmaoIntercessor : IntercessorHandler
    {
        private string _nome;

        public IrmaoIntercessor(string nome)
        {
            _nome = nome;
        }

        public override void Interceder(PedidoOracao pedido)
        {
            Console.WriteLine($"Irmão {_nome}: Recebendo pedido - {pedido.Descricao}");
            
            if (pedido.Urgencia == 1 && pedido.Tipo.Contains("comunhão"))
            {
                Console.WriteLine($"Irmão {_nome}: 'Posso ajudar com este pedido de comunhão!'");
                Console.WriteLine($"Irmão {_nome}: 'Orando junto e oferecendo apoio fraternal...'");
            }
            else
            {
                Console.WriteLine($"Irmão {_nome}: 'Este pedido precisa de alguém mais experiente...'");
                PassarAdiante(pedido);
            }
        }
    }

    // Aplicação de exemplo
    public class MinhaAppChainOfResponsibility
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO CHAIN OF RESPONSIBILITY: Cadeia de Intercessão ===\n");

            // Criando a cadeia de intercessão
            var irmaoJoao = new IrmaoIntercessor("João");
            var pastorPedro = new PastorIntercessor("Pedro");
            var anjoGabriel = new AnjoIntercessor("Gabriel");
            var espiritoSanto = new EspiritoSantoIntercessor();
            var jesus = new CristoIntercessor();

            // Montando a cadeia
            irmaoJoao.DefinirProximo(pastorPedro);
            pastorPedro.DefinirProximo(anjoGabriel);
            anjoGabriel.DefinirProximo(espiritoSanto);
            espiritoSanto.DefinirProximo(jesus);

            Console.WriteLine("--- Cadeia de Intercessão Estabelecida ---");
            Console.WriteLine("Irmão João -> Pastor Pedro -> Anjo Gabriel -> Espírito Santo -> Jesus Cristo\n");

            // Testando diferentes tipos de pedidos
            Console.WriteLine("--- Pedido 1: Comunhão Fraterna (Baixa Urgência) ---");
            var pedido1 = new PedidoOracao("comunhão", "Pedindo por mais união na igreja", 1);
            irmaoJoao.Interceder(pedido1);
            Console.WriteLine();

            Console.WriteLine("--- Pedido 2: Orientação Espiritual (Média Urgência) ---");
            var pedido2 = new PedidoOracao("orientação", "Preciso de direção para minha vida", 2);
            irmaoJoao.Interceder(pedido2);
            Console.WriteLine();

            Console.WriteLine("--- Pedido 3: Proteção Divina (Alta Urgência) ---");
            var pedido3 = new PedidoOracao("proteção", "Família em perigo, precisa de proteção", 3);
            irmaoJoao.Interceder(pedido3);
            Console.WriteLine();

            Console.WriteLine("--- Pedido 4: Cura Milagrosa (Alta Urgência) ---");
            var pedido4 = new PedidoOracao("cura", "Pessoa desenganada pelos médicos", 3);
            irmaoJoao.Interceder(pedido4);
            Console.WriteLine();

            Console.WriteLine("--- Pedido 5: Situação de Vida ou Morte (Crítica) ---");
            var pedido5 = new PedidoOracao("emergência", "Acidente grave, situação crítica", 4);
            irmaoJoao.Interceder(pedido5);
        }
    }
}

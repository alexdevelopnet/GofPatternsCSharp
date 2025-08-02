using System;

namespace Estruturais.Bridge
{
    // Implementor - Define a interface para as formas de orar
    public interface IFormaOracao
    {
        void Orar(string oracao);
        void PrepararAmbiente();
        void Finalizar();
    }

    // Concrete Implementors - Diferentes formas de orar
    public class OracaoIndividual : IFormaOracao
    {
        public void PrepararAmbiente()
        {
            Console.WriteLine("Preparando lugar secreto para oração individual...");
            Console.WriteLine("'Mas tu, quando orares, entra no teu aposento e, fechando a tua porta, ora a teu Pai que está em secreto' - Mateus 6:6");
        }

        public void Orar(string oracao)
        {
            Console.WriteLine($"Orando individualmente: '{oracao}'");
            Console.WriteLine("Sussurrando com o coração...");
        }

        public void Finalizar()
        {
            Console.WriteLine("Finalizando oração individual com 'Amém'");
        }
    }

    public class OracaoColetiva : IFormaOracao
    {
        public void PrepararAmbiente()
        {
            Console.WriteLine("Reunindo os irmãos para oração coletiva...");
            Console.WriteLine("'Porque onde estiverem dois ou três reunidos em meu nome, aí estou eu no meio deles' - Mateus 18:20");
        }

        public void Orar(string oracao)
        {
            Console.WriteLine($"Orando em coro: '{oracao}'");
            Console.WriteLine("Vozes unidas em harmonia...");
        }

        public void Finalizar()
        {
            Console.WriteLine("Todos juntos: 'Amém!'");
        }
    }

    public class OracaoLiturgica : IFormaOracao
    {
        public void PrepararAmbiente()
        {
            Console.WriteLine("Preparando altar e objetos sagrados...");
            Console.WriteLine("Seguindo a liturgia estabelecida...");
        }

        public void Orar(string oracao)
        {
            Console.WriteLine($"Recitando liturgicamente: '{oracao}'");
            Console.WriteLine("Seguindo os ritos tradicionais...");
        }

        public void Finalizar()
        {
            Console.WriteLine("Concluindo com bênção litúrgica");
        }
    }

    public class OracaoEspontanea : IFormaOracao
    {
        public void PrepararAmbiente()
        {
            Console.WriteLine("Preparando coração para oração espontânea...");
            Console.WriteLine("Deixando o Espírito Santo guiar...");
        }

        public void Orar(string oracao)
        {
            Console.WriteLine($"Orando espontaneamente: '{oracao}'");
            Console.WriteLine("Palavras vindas do coração...");
        }

        public void Finalizar()
        {
            Console.WriteLine("Finalizando conforme a inspiração do momento");
        }
    }

    // Abstraction - Define a abstração e mantém referência ao implementor
    public abstract class TipoOracao
    {
        protected IFormaOracao _formaOracao;

        protected TipoOracao(IFormaOracao formaOracao)
        {
            _formaOracao = formaOracao;
        }

        public abstract void RealizarOracao();

        public void MudarFormaOracao(IFormaOracao novaForma)
        {
            _formaOracao = novaForma;
            Console.WriteLine($"Mudando para: {novaForma.GetType().Name}");
        }
    }

    // Refined Abstractions - Diferentes tipos de oração
    public class OracaoGratidao : TipoOracao
    {
        public OracaoGratidao(IFormaOracao formaOracao) : base(formaOracao) { }

        public override void RealizarOracao()
        {
            Console.WriteLine("=== ORAÇÃO DE GRATIDÃO ===");
            _formaOracao.PrepararAmbiente();
            _formaOracao.Orar("Senhor, obrigado por todas as suas bênçãos em minha vida");
            _formaOracao.Finalizar();
        }
    }

    public class OracaoIntercesao : TipoOracao
    {
        private string _pessoaIntercedida;

        public OracaoIntercesao(IFormaOracao formaOracao, string pessoa) : base(formaOracao)
        {
            _pessoaIntercedida = pessoa;
        }

        public override void RealizarOracao()
        {
            Console.WriteLine("=== ORAÇÃO DE INTERCESSÃO ===");
            _formaOracao.PrepararAmbiente();
            _formaOracao.Orar($"Senhor, intercedo por {_pessoaIntercedida}, abençoa sua vida");
            _formaOracao.Finalizar();
        }
    }

    public class OracaoPerdao : TipoOracao
    {
        public OracaoPerdao(IFormaOracao formaOracao) : base(formaOracao) { }

        public override void RealizarOracao()
        {
            Console.WriteLine("=== ORAÇÃO DE PERDÃO ===");
            _formaOracao.PrepararAmbiente();
            _formaOracao.Orar("Senhor, perdoa os meus pecados e purifica meu coração");
            _formaOracao.Finalizar();
        }
    }

    public class OracaoSuplica : TipoOracao
    {
        private string _pedido;

        public OracaoSuplica(IFormaOracao formaOracao, string pedido) : base(formaOracao)
        {
            _pedido = pedido;
        }

        public override void RealizarOracao()
        {
            Console.WriteLine("=== ORAÇÃO DE SÚPLICA ===");
            _formaOracao.PrepararAmbiente();
            _formaOracao.Orar($"Senhor, suplico por {_pedido}");
            _formaOracao.Finalizar();
        }
    }

    // Aplicação de exemplo
    public class MinhaAppBridge
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO BRIDGE: Oração e Formas de Orar ===\n");

            // Criando diferentes formas de oração
            var individual = new OracaoIndividual();
            var coletiva = new OracaoColetiva();
            var liturgica = new OracaoLiturgica();
            var espontanea = new OracaoEspontanea();

            // Criando diferentes tipos de oração
            var gratidao = new OracaoGratidao(individual);
            var intercesao = new OracaoIntercesao(coletiva, "Maria");
            var perdao = new OracaoPerdao(liturgica);
            var suplica = new OracaoSuplica(espontanea, "cura para João");

            // Demonstrando o padrão Bridge
            Console.WriteLine("--- Oração de Gratidão (Individual) ---");
            gratidao.RealizarOracao();
            Console.WriteLine();

            Console.WriteLine("--- Oração de Intercessão (Coletiva) ---");
            intercesao.RealizarOracao();
            Console.WriteLine();

            Console.WriteLine("--- Oração de Perdão (Litúrgica) ---");
            perdao.RealizarOracao();
            Console.WriteLine();

            Console.WriteLine("--- Oração de Súplica (Espontânea) ---");
            suplica.RealizarOracao();
            Console.WriteLine();

            // Demonstrando a flexibilidade do Bridge
            Console.WriteLine("--- Mudando Forma de Oração ---");
            Console.WriteLine("Mudando oração de gratidão para forma coletiva:");
            gratidao.MudarFormaOracao(coletiva);
            gratidao.RealizarOracao();
            Console.WriteLine();

            Console.WriteLine("Mudando oração de perdão para forma espontânea:");
            perdao.MudarFormaOracao(espontanea);
            perdao.RealizarOracao();
        }
    }
}

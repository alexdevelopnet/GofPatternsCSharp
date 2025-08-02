using System;

namespace Comportamentais.State
{
    // Context - Pedro
    public class Pedro
    {
        private IEstadoFe _estadoAtual;

        public Pedro()
        {
            // Pedro começa com fé forte
            _estadoAtual = new FeForte();
        }

        public void MudarEstado(IEstadoFe novoEstado)
        {
            _estadoAtual = novoEstado;
        }

        public void EnfrentarDesafio(string desafio)
        {
            Console.WriteLine($"Pedro enfrenta: {desafio}");
            _estadoAtual.Reagir(this, desafio);
        }

        public void ReceberEncorajamento()
        {
            _estadoAtual.ReceberEncorajamento(this);
        }

        public void MostrarEstadoAtual()
        {
            Console.WriteLine($"Estado atual de Pedro: {_estadoAtual.GetType().Name}");
        }
    }

    // State Interface
    public interface IEstadoFe
    {
        void Reagir(Pedro pedro, string situacao);
        void ReceberEncorajamento(Pedro pedro);
    }

    // Concrete States
    public class FeForte : IEstadoFe
    {
        public void Reagir(Pedro pedro, string situacao)
        {
            Console.WriteLine("Pedro (Fé Forte): 'Ainda que todos se escandalizem, eu jamais me escandalizarei!'");
            
            if (situacao.Contains("tempestade") || situacao.Contains("prisão"))
            {
                Console.WriteLine("Pedro: A situação é difícil, mas minha fé permanece forte!");
            }
            else if (situacao.Contains("negação") || situacao.Contains("medo"))
            {
                Console.WriteLine("Pedro: Esta situação está abalando minha fé...");
                pedro.MudarEstado(new FeAbalada());
            }
        }

        public void ReceberEncorajamento(Pedro pedro)
        {
            Console.WriteLine("Pedro (Fé Forte): 'Obrigado pelo encorajamento! Minha fé já está forte!'");
        }
    }

    public class FeAbalada : IEstadoFe
    {
        public void Reagir(Pedro pedro, string situacao)
        {
            Console.WriteLine("Pedro (Fé Abalada): 'Estou confuso e com medo...'");
            
            if (situacao.Contains("negação") || situacao.Contains("traição"))
            {
                Console.WriteLine("Pedro: Não posso mais... estou negando meu Mestre!");
                pedro.MudarEstado(new FeQuebrada());
            }
            else if (situacao.Contains("milagre") || situacao.Contains("ressurreição"))
            {
                Console.WriteLine("Pedro: Este milagre está restaurando minha fé!");
                pedro.MudarEstado(new FeRestaurada());
            }
        }

        public void ReceberEncorajamento(Pedro pedro)
        {
            Console.WriteLine("Pedro (Fé Abalada): 'Preciso deste encorajamento... obrigado!'");
            Console.WriteLine("Pedro: Sinto minha fé se fortalecendo novamente!");
            pedro.MudarEstado(new FeForte());
        }
    }

    public class FeQuebrada : IEstadoFe
    {
        public void Reagir(Pedro pedro, string situacao)
        {
            Console.WriteLine("Pedro (Fé Quebrada): 'Chorou amargamente... O que eu fiz?'");
            
            if (situacao.Contains("ressurreição") || situacao.Contains("perdão"))
            {
                Console.WriteLine("Pedro: O Mestre ressuscitou! Ele me perdoa!");
                pedro.MudarEstado(new FeRestaurada());
            }
            else
            {
                Console.WriteLine("Pedro: Não consigo reagir... minha fé está destruída.");
            }
        }

        public void ReceberEncorajamento(Pedro pedro)
        {
            Console.WriteLine("Pedro (Fé Quebrada): 'Será que ainda há esperança para mim?'");
            Console.WriteLine("Pedro: Talvez... talvez eu possa ser restaurado...");
            pedro.MudarEstado(new FeAbalada());
        }
    }

    public class FeRestaurada : IEstadoFe
    {
        public void Reagir(Pedro pedro, string situacao)
        {
            Console.WriteLine("Pedro (Fé Restaurada): 'Senhor, tu sabes que eu te amo!'");
            
            if (situacao.Contains("perseguição") || situacao.Contains("martírio"))
            {
                Console.WriteLine("Pedro: Agora estou pronto para dar minha vida por Cristo!");
                Console.WriteLine("Pedro: Minha fé está mais forte que nunca!");
                pedro.MudarEstado(new FeInabalavel());
            }
            else
            {
                Console.WriteLine("Pedro: Minha fé foi restaurada e estou firme!");
            }
        }

        public void ReceberEncorajamento(Pedro pedro)
        {
            Console.WriteLine("Pedro (Fé Restaurada): 'Obrigado! Agora posso encorajar outros também!'");
        }
    }

    public class FeInabalavel : IEstadoFe
    {
        public void Reagir(Pedro pedro, string situacao)
        {
            Console.WriteLine("Pedro (Fé Inabalável): 'Nem a morte me separará do amor de Cristo!'");
            Console.WriteLine("Pedro: Estou pronto para qualquer desafio em nome de Jesus!");
        }

        public void ReceberEncorajamento(Pedro pedro)
        {
            Console.WriteLine("Pedro (Fé Inabalável): 'Agora sou eu quem encoraja os outros irmãos!'");
        }
    }

    // Aplicação de exemplo
    public class MinhaAppState
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO STATE: A Jornada de Fé de Pedro ===\n");

            var pedro = new Pedro();

            // Mostrando estado inicial
            Console.WriteLine("--- Estado Inicial ---");
            pedro.MostrarEstadoAtual();
            Console.WriteLine();

            // Primeira situação - tempestade no mar
            Console.WriteLine("--- Situação 1: Tempestade no Mar ---");
            pedro.EnfrentarDesafio("tempestade no mar da Galileia");
            Console.WriteLine();

            // Segunda situação - medo e negação
            Console.WriteLine("--- Situação 2: Prisão de Jesus ---");
            pedro.EnfrentarDesafio("Jesus sendo preso - medo e negação");
            pedro.MostrarEstadoAtual();
            Console.WriteLine();

            // Terceira situação - negação completa
            Console.WriteLine("--- Situação 3: Negação de Jesus ---");
            pedro.EnfrentarDesafio("negação de Jesus três vezes");
            pedro.MostrarEstadoAtual();
            Console.WriteLine();

            // Quarta situação - ressurreição
            Console.WriteLine("--- Situação 4: Ressurreição de Jesus ---");
            pedro.EnfrentarDesafio("ressurreição de Jesus - perdão e restauração");
            pedro.MostrarEstadoAtual();
            Console.WriteLine();

            // Quinta situação - perseguição
            Console.WriteLine("--- Situação 5: Perseguição dos Cristãos ---");
            pedro.EnfrentarDesafio("perseguição e possível martírio");
            pedro.MostrarEstadoAtual();
            Console.WriteLine();

            // Encorajamento final
            Console.WriteLine("--- Encorajamento Final ---");
            pedro.ReceberEncorajamento();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Comportamentais.Command
{
    // Interface Command
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    // Receiver - Jesus (quem executa os milagres)
    public class Jesus
    {
        public void CurarCego()
        {
            Console.WriteLine("Jesus: 'Seja aberta a tua vista!' - O cego foi curado!");
        }

        public void DesfazerCuraCego()
        {
            Console.WriteLine("Jesus: Desfazendo a cura da cegueira...");
        }

        public void MultiplicarPaes()
        {
            Console.WriteLine("Jesus: 'Dai-lhes vós de comer!' - Os pães foram multiplicados!");
        }

        public void DesfazerMultiplicacao()
        {
            Console.WriteLine("Jesus: Desfazendo a multiplicação dos pães...");
        }

        public void CaminharSobreAguas()
        {
            Console.WriteLine("Jesus: 'Não temais, sou eu!' - Jesus caminha sobre as águas!");
        }

        public void DesfazerCaminhadaAguas()
        {
            Console.WriteLine("Jesus: Retornando à terra firme...");
        }
    }

    // Concrete Commands
    public class CurarCegoCommand : ICommand
    {
        private Jesus _jesus;

        public CurarCegoCommand(Jesus jesus)
        {
            _jesus = jesus;
        }

        public void Execute()
        {
            _jesus.CurarCego();
        }

        public void Undo()
        {
            _jesus.DesfazerCuraCego();
        }
    }

    public class MultiplicarPaesCommand : ICommand
    {
        private Jesus _jesus;

        public MultiplicarPaesCommand(Jesus jesus)
        {
            _jesus = jesus;
        }

        public void Execute()
        {
            _jesus.MultiplicarPaes();
        }

        public void Undo()
        {
            _jesus.DesfazerMultiplicacao();
        }
    }

    public class CaminharAguasCommand : ICommand
    {
        private Jesus _jesus;

        public CaminharAguasCommand(Jesus jesus)
        {
            _jesus = jesus;
        }

        public void Execute()
        {
            _jesus.CaminharSobreAguas();
        }

        public void Undo()
        {
            _jesus.DesfazerCaminhadaAguas();
        }
    }

    // Invoker - Discípulos (quem invoca os comandos)
    public class Discipulos
    {
        private Stack<ICommand> _historico = new Stack<ICommand>();

        public void ExecutarMilagre(ICommand comando)
        {
            Console.WriteLine("Discípulos: Pedindo um milagre ao Mestre...");
            comando.Execute();
            _historico.Push(comando);
        }

        public void DesfazerUltimoMilagre()
        {
            if (_historico.Count > 0)
            {
                Console.WriteLine("Discípulos: Pedindo para desfazer o último milagre...");
                var ultimoComando = _historico.Pop();
                ultimoComando.Undo();
            }
            else
            {
                Console.WriteLine("Discípulos: Não há milagres para desfazer.");
            }
        }

        public void MostrarHistorico()
        {
            Console.WriteLine($"Discípulos: Temos {_historico.Count} milagres no histórico.");
        }
    }

    // Aplicação de exemplo
    public class MinhaAppCommand
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO COMMAND: Milagres de Jesus ===\n");

            // Criando o receiver
            var jesus = new Jesus();

            // Criando os comandos
            var curarCego = new CurarCegoCommand(jesus);
            var multiplicarPaes = new MultiplicarPaesCommand(jesus);
            var caminharAguas = new CaminharAguasCommand(jesus);

            // Criando o invoker
            var discipulos = new Discipulos();

            // Executando comandos
            discipulos.ExecutarMilagre(curarCego);
            Console.WriteLine();

            discipulos.ExecutarMilagre(multiplicarPaes);
            Console.WriteLine();

            discipulos.ExecutarMilagre(caminharAguas);
            Console.WriteLine();

            discipulos.MostrarHistorico();
            Console.WriteLine();

            // Desfazendo comandos
            discipulos.DesfazerUltimoMilagre();
            Console.WriteLine();

            discipulos.DesfazerUltimoMilagre();
            Console.WriteLine();

            discipulos.MostrarHistorico();
        }
    }
}

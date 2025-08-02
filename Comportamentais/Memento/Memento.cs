using System;
using System.Collections.Generic;

namespace Comportamentais.Memento
{
    // Memento - Estado de Jó
    public class EstadoJo
    {
        public int Riqueza { get; private set; }
        public int Filhos { get; private set; }
        public string Saude { get; private set; }
        public string EstadoEspiritual { get; private set; }
        public DateTime DataEstado { get; private set; }

        public EstadoJo(int riqueza, int filhos, string saude, string estadoEspiritual)
        {
            Riqueza = riqueza;
            Filhos = filhos;
            Saude = saude;
            EstadoEspiritual = estadoEspiritual;
            DataEstado = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Riqueza: {Riqueza} talentos, Filhos: {Filhos}, Saúde: {Saude}, Estado Espiritual: {EstadoEspiritual}";
        }
    }

    // Originator - Jó
    public class Jo
    {
        private int _riqueza;
        private int _filhos;
        private string _saude;
        private string _estadoEspiritual;

        public Jo()
        {
            // Estado inicial de Jó - homem próspero e íntegro
            _riqueza = 10000; // talentos
            _filhos = 10;
            _saude = "Perfeita";
            _estadoEspiritual = "Íntegro e reto, temente a Deus";
        }

        // Criar memento do estado atual
        public EstadoJo SalvarEstado()
        {
            Console.WriteLine("Deus: Guardando o estado atual de Jó...");
            return new EstadoJo(_riqueza, _filhos, _saude, _estadoEspiritual);
        }

        // Restaurar estado de um memento
        public void RestaurarEstado(EstadoJo estado)
        {
            Console.WriteLine("Deus: Restaurando Jó ao seu estado anterior...");
            _riqueza = estado.Riqueza;
            _filhos = estado.Filhos;
            _saude = estado.Saude;
            _estadoEspiritual = estado.EstadoEspiritual;
            Console.WriteLine("Deus: 'E o Senhor mudou a sorte de Jó!'");
        }

        // Métodos para alterar o estado
        public void SofrerPerdasMateriais()
        {
            Console.WriteLine("Satanás: Atacando as posses de Jó...");
            _riqueza = 0;
            Console.WriteLine("Jó perdeu todos os seus bens!");
        }

        public void SofrerPerdaFamiliar()
        {
            Console.WriteLine("Satanás: Atacando a família de Jó...");
            _filhos = 0;
            Console.WriteLine("Jó perdeu todos os seus filhos!");
        }

        public void SofrerDoenca()
        {
            Console.WriteLine("Satanás: Atacando a saúde de Jó...");
            _saude = "Úlceras malignas dos pés à cabeça";
            Console.WriteLine("Jó foi ferido com úlceras malignas!");
        }

        public void ManterFe()
        {
            Console.WriteLine("Jó: 'Nu saí do ventre de minha mãe e nu tornarei para lá; o Senhor o deu e o Senhor o tomou; bendito seja o nome do Senhor!'");
            _estadoEspiritual = "Fiel mesmo no sofrimento";
        }

        public void ReceberRestauracaoCompleta()
        {
            Console.WriteLine("Deus: Restaurando Jó em dobro...");
            _riqueza = 20000; // dobrou sua riqueza
            _filhos = 10; // teve novos filhos
            _saude = "Perfeita - completamente curado";
            _estadoEspiritual = "Mais sábio e abençoado que antes";
        }

        public void MostrarEstadoAtual()
        {
            Console.WriteLine($"Estado atual de Jó: Riqueza: {_riqueza} talentos, Filhos: {_filhos}, Saúde: {_saude}, Estado Espiritual: {_estadoEspiritual}");
        }
    }

    // Caretaker - Deus (guardião dos estados)
    public class PlanoRedentor
    {
        private Stack<EstadoJo> _historicoEstados = new Stack<EstadoJo>();
        private string _nomeGuardiao;

        public PlanoRedentor(string nome)
        {
            _nomeGuardiao = nome;
        }

        public void SalvarEstado(Jo jo)
        {
            Console.WriteLine($"{_nomeGuardiao}: Salvando estado de Jó no plano eterno...");
            var estado = jo.SalvarEstado();
            _historicoEstados.Push(estado);
            Console.WriteLine($"Estado salvo: {estado}");
        }

        public void RestaurarUltimoEstado(Jo jo)
        {
            if (_historicoEstados.Count > 0)
            {
                Console.WriteLine($"{_nomeGuardiao}: Restaurando Jó conforme o plano eterno...");
                var estadoAnterior = _historicoEstados.Pop();
                jo.RestaurarEstado(estadoAnterior);
                Console.WriteLine($"Estado restaurado: {estadoAnterior}");
            }
            else
            {
                Console.WriteLine($"{_nomeGuardiao}: Não há estados anteriores para restaurar.");
            }
        }

        public void MostrarHistorico()
        {
            Console.WriteLine($"\n{_nomeGuardiao}: Histórico de estados salvos:");
            if (_historicoEstados.Count == 0)
            {
                Console.WriteLine("Nenhum estado salvo no momento.");
            }
            else
            {
                int contador = _historicoEstados.Count;
                foreach (var estado in _historicoEstados)
                {
                    Console.WriteLine($"{contador--}. {estado} (Salvo em: {estado.DataEstado:HH:mm:ss})");
                }
            }
        }
    }

    // Aplicação de exemplo
    public class MinhaAppMemento
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO MEMENTO: A Restauração de Jó ===\n");

            // Criando os objetos
            var jo = new Jo();
            var planoRedentor = new PlanoRedentor("Deus Todo-Poderoso");

            // Estado inicial de Jó
            Console.WriteLine("--- Estado Inicial de Jó (Homem Próspero) ---");
            jo.MostrarEstadoAtual();
            Console.WriteLine();

            // Deus salva o estado inicial antes das provações
            Console.WriteLine("--- Deus Salva o Estado de Jó Antes das Provações ---");
            planoRedentor.SalvarEstado(jo);
            Console.WriteLine();

            // Primeira provação - perdas materiais
            Console.WriteLine("--- Primeira Provação: Perdas Materiais ---");
            jo.SofrerPerdasMateriais();
            jo.ManterFe();
            jo.MostrarEstadoAtual();
            Console.WriteLine();

            // Segunda provação - perda familiar
            Console.WriteLine("--- Segunda Provação: Perda dos Filhos ---");
            jo.SofrerPerdaFamiliar();
            jo.ManterFe();
            jo.MostrarEstadoAtual();
            Console.WriteLine();

            // Terceira provação - doença
            Console.WriteLine("--- Terceira Provação: Doença Grave ---");
            jo.SofrerDoenca();
            jo.ManterFe();
            jo.MostrarEstadoAtual();
            Console.WriteLine();

            // Mostrando histórico
            Console.WriteLine("--- Histórico de Estados Salvos ---");
            planoRedentor.MostrarHistorico();
            Console.WriteLine();

            // Jó permanece fiel
            Console.WriteLine("--- Jó Permanece Fiel ---");
            Console.WriteLine("Jó: 'Ainda que ele me mate, nele esperarei!'");
            Console.WriteLine("Deus: 'Jó passou no teste! Hora da restauração!'");
            Console.WriteLine();

            // Restauração com bênçãos dobradas
            Console.WriteLine("--- Restauração Completa (Melhor que Antes) ---");
            jo.ReceberRestauracaoCompleta();
            jo.MostrarEstadoAtual();
            Console.WriteLine();

            // Comparação com estado original
            Console.WriteLine("--- Comparando com Estado Original ---");
            Console.WriteLine("Estado original estava salvo no plano eterno de Deus.");
            Console.WriteLine("Estado atual é ainda melhor - Deus restaurou em dobro!");
            Console.WriteLine("Jó: 'Eu te conhecia só de ouvir, mas agora os meus olhos te veem!'");
        }
    }
}

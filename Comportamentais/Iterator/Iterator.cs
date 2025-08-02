using System;
using System.Collections.Generic;

namespace Comportamentais.Iterator
{
    // Iterator Interface
    public interface IIterator<T>
    {
        bool TemProximo();
        T Proximo();
        void Reiniciar();
    }

    // Aggregate Interface
    public interface IColecaoBiblica<T>
    {
        IIterator<T> CriarIterator();
        void AdicionarItem(T item);
        int ObterTamanho();
    }

    // Classe para representar um livro da Bíblia
    public class LivroBiblico
    {
        public string Nome { get; set; }
        public string Testamento { get; set; }
        public string Autor { get; set; }
        public int Capitulos { get; set; }

        public LivroBiblico(string nome, string testamento, string autor, int capitulos)
        {
            Nome = nome;
            Testamento = testamento;
            Autor = autor;
            Capitulos = capitulos;
        }

        public override string ToString()
        {
            return $"{Nome} ({Testamento}) - Autor: {Autor}, Capítulos: {Capitulos}";
        }
    }

    // Concrete Iterator - Iterator sequencial
    public class IteratorSequencial : IIterator<LivroBiblico>
    {
        private List<LivroBiblico> _livros;
        private int _posicaoAtual = 0;

        public IteratorSequencial(List<LivroBiblico> livros)
        {
            _livros = livros;
        }

        public bool TemProximo()
        {
            return _posicaoAtual < _livros.Count;
        }

        public LivroBiblico Proximo()
        {
            if (!TemProximo())
                throw new InvalidOperationException("Não há mais livros para iterar");

            return _livros[_posicaoAtual++];
        }

        public void Reiniciar()
        {
            _posicaoAtual = 0;
        }
    }

    // Concrete Iterator - Iterator por testamento
    public class IteratorPorTestamento : IIterator<LivroBiblico>
    {
        private List<LivroBiblico> _livros;
        private string _testamentoFiltro;
        private int _posicaoAtual = 0;

        public IteratorPorTestamento(List<LivroBiblico> livros, string testamento)
        {
            _livros = livros;
            _testamentoFiltro = testamento;
        }

        public bool TemProximo()
        {
            while (_posicaoAtual < _livros.Count)
            {
                if (_livros[_posicaoAtual].Testamento == _testamentoFiltro)
                    return true;
                _posicaoAtual++;
            }
            return false;
        }

        public LivroBiblico Proximo()
        {
            if (!TemProximo())
                throw new InvalidOperationException($"Não há mais livros do {_testamentoFiltro} para iterar");

            return _livros[_posicaoAtual++];
        }

        public void Reiniciar()
        {
            _posicaoAtual = 0;
        }
    }

    // Concrete Iterator - Iterator reverso
    public class IteratorReverso : IIterator<LivroBiblico>
    {
        private List<LivroBiblico> _livros;
        private int _posicaoAtual;

        public IteratorReverso(List<LivroBiblico> livros)
        {
            _livros = livros;
            _posicaoAtual = _livros.Count - 1;
        }

        public bool TemProximo()
        {
            return _posicaoAtual >= 0;
        }

        public LivroBiblico Proximo()
        {
            if (!TemProximo())
                throw new InvalidOperationException("Não há mais livros para iterar");

            return _livros[_posicaoAtual--];
        }

        public void Reiniciar()
        {
            _posicaoAtual = _livros.Count - 1;
        }
    }

    // Concrete Aggregate
    public class Biblia : IColecaoBiblica<LivroBiblico>
    {
        private List<LivroBiblico> _livros = new List<LivroBiblico>();

        public void AdicionarItem(LivroBiblico livro)
        {
            _livros.Add(livro);
        }

        public int ObterTamanho()
        {
            return _livros.Count;
        }

        public IIterator<LivroBiblico> CriarIterator()
        {
            return new IteratorSequencial(_livros);
        }

        public IIterator<LivroBiblico> CriarIteratorPorTestamento(string testamento)
        {
            return new IteratorPorTestamento(_livros, testamento);
        }

        public IIterator<LivroBiblico> CriarIteratorReverso()
        {
            return new IteratorReverso(_livros);
        }

        public void CarregarLivrosBiblicos()
        {
            // Antigo Testamento
            AdicionarItem(new LivroBiblico("Gênesis", "Antigo Testamento", "Moisés", 50));
            AdicionarItem(new LivroBiblico("Êxodo", "Antigo Testamento", "Moisés", 40));
            AdicionarItem(new LivroBiblico("Levítico", "Antigo Testamento", "Moisés", 27));
            AdicionarItem(new LivroBiblico("Salmos", "Antigo Testamento", "Davi e outros", 150));
            AdicionarItem(new LivroBiblico("Provérbios", "Antigo Testamento", "Salomão", 31));
            AdicionarItem(new LivroBiblico("Isaías", "Antigo Testamento", "Isaías", 66));

            // Novo Testamento
            AdicionarItem(new LivroBiblico("Mateus", "Novo Testamento", "Mateus", 28));
            AdicionarItem(new LivroBiblico("Marcos", "Novo Testamento", "Marcos", 16));
            AdicionarItem(new LivroBiblico("Lucas", "Novo Testamento", "Lucas", 24));
            AdicionarItem(new LivroBiblico("João", "Novo Testamento", "João", 21));
            AdicionarItem(new LivroBiblico("Atos", "Novo Testamento", "Lucas", 28));
            AdicionarItem(new LivroBiblico("Romanos", "Novo Testamento", "Paulo", 16));
            AdicionarItem(new LivroBiblico("Apocalipse", "Novo Testamento", "João", 22));
        }
    }

    // Aplicação de exemplo
    public class MinhaAppIterator
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO ITERATOR: Percorrendo os Livros da Bíblia ===\n");

            var biblia = new Biblia();
            biblia.CarregarLivrosBiblicos();

            Console.WriteLine($"Total de livros carregados: {biblia.ObterTamanho()}\n");

            // Iterator sequencial
            Console.WriteLine("--- Iteração Sequencial (todos os livros) ---");
            var iteratorSequencial = biblia.CriarIterator();
            int contador = 1;
            while (iteratorSequencial.TemProximo())
            {
                var livro = iteratorSequencial.Proximo();
                Console.WriteLine($"{contador++}. {livro}");
            }
            Console.WriteLine();

            // Iterator por Antigo Testamento
            Console.WriteLine("--- Iteração por Antigo Testamento ---");
            var iteratorAT = biblia.CriarIteratorPorTestamento("Antigo Testamento");
            contador = 1;
            while (iteratorAT.TemProximo())
            {
                var livro = iteratorAT.Proximo();
                Console.WriteLine($"{contador++}. {livro}");
            }
            Console.WriteLine();

            // Iterator por Novo Testamento
            Console.WriteLine("--- Iteração por Novo Testamento ---");
            var iteratorNT = biblia.CriarIteratorPorTestamento("Novo Testamento");
            contador = 1;
            while (iteratorNT.TemProximo())
            {
                var livro = iteratorNT.Proximo();
                Console.WriteLine($"{contador++}. {livro}");
            }
            Console.WriteLine();

            // Iterator reverso
            Console.WriteLine("--- Iteração Reversa (do fim para o início) ---");
            var iteratorReverso = biblia.CriarIteratorReverso();
            contador = 1;
            while (iteratorReverso.TemProximo())
            {
                var livro = iteratorReverso.Proximo();
                Console.WriteLine($"{contador++}. {livro}");
            }
        }
    }
}

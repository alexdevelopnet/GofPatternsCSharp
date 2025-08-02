using System;
using System.Collections.Generic;

namespace Estruturais.Composite
{
    // Component - Interface comum para todos os elementos da hierarquia
    public abstract class ElementoIgreja
    {
        protected string _nome;
        protected string _funcao;

        public ElementoIgreja(string nome, string funcao)
        {
            _nome = nome;
            _funcao = funcao;
        }

        public string Nome => _nome;
        public string Funcao => _funcao;

        public abstract void MostrarHierarquia(int nivel = 0);
        public abstract void Ministrar();
        public abstract int ContarMembros();
        public abstract void AdicionarMembro(ElementoIgreja membro);
        public abstract void RemoverMembro(ElementoIgreja membro);

        protected string GetIndentacao(int nivel)
        {
            return new string(' ', nivel * 2);
        }
    }

    // Leaf - Elementos individuais da hierarquia
    public class MembroIgreja : ElementoIgreja
    {
        private string _dom;

        public MembroIgreja(string nome, string funcao, string dom) : base(nome, funcao)
        {
            _dom = dom;
        }

        public override void MostrarHierarquia(int nivel = 0)
        {
            Console.WriteLine($"{GetIndentacao(nivel)}👤 {_nome} - {_funcao} (Dom: {_dom})");
        }

        public override void Ministrar()
        {
            Console.WriteLine($"{_nome} ({_funcao}): Ministrando com o dom de {_dom}");
        }

        public override int ContarMembros()
        {
            return 1;
        }

        public override void AdicionarMembro(ElementoIgreja membro)
        {
            Console.WriteLine($"Não é possível adicionar membros a {_nome} - é um membro individual");
        }

        public override void RemoverMembro(ElementoIgreja membro)
        {
            Console.WriteLine($"Não é possível remover membros de {_nome} - é um membro individual");
        }
    }

    // Composite - Elementos que podem conter outros elementos
    public class LiderancaIgreja : ElementoIgreja
    {
        private List<ElementoIgreja> _membros = new List<ElementoIgreja>();
        private string _versiculo;

        public LiderancaIgreja(string nome, string funcao, string versiculo) : base(nome, funcao)
        {
            _versiculo = versiculo;
        }

        public override void MostrarHierarquia(int nivel = 0)
        {
            Console.WriteLine($"{GetIndentacao(nivel)}👑 {_nome} - {_funcao}");
            Console.WriteLine($"{GetIndentacao(nivel)}   📖 \"{_versiculo}\"");
            
            foreach (var membro in _membros)
            {
                membro.MostrarHierarquia(nivel + 1);
            }
        }

        public override void Ministrar()
        {
            Console.WriteLine($"{_nome} ({_funcao}): Liderando e coordenando o ministério");
            Console.WriteLine($"Versículo base: \"{_versiculo}\"");
            
            foreach (var membro in _membros)
            {
                membro.Ministrar();
            }
        }

        public override int ContarMembros()
        {
            int total = 1; // Conta a si mesmo
            foreach (var membro in _membros)
            {
                total += membro.ContarMembros();
            }
            return total;
        }

        public override void AdicionarMembro(ElementoIgreja membro)
        {
            _membros.Add(membro);
            Console.WriteLine($"{membro.Nome} foi adicionado sob a liderança de {_nome}");
        }

        public override void RemoverMembro(ElementoIgreja membro)
        {
            if (_membros.Remove(membro))
            {
                Console.WriteLine($"{membro.Nome} foi removido da liderança de {_nome}");
            }
            else
            {
                Console.WriteLine($"{membro.Nome} não foi encontrado sob a liderança de {_nome}");
            }
        }

        public List<ElementoIgreja> GetMembros()
        {
            return new List<ElementoIgreja>(_membros);
        }
    }

    // Aplicação de exemplo
    public class MinhaAppComposite
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO COMPOSITE: Hierarquia da Igreja ===\n");

            // Criando a hierarquia da igreja
            var pastor = new LiderancaIgreja("Pastor João", "Pastor Principal", 
                "Apascenta as minhas ovelhas - João 21:17");

            var presbitero1 = new LiderancaIgreja("Presbítero Pedro", "Presbítero", 
                "Apascentai o rebanho de Deus - 1 Pedro 5:2");
            
            var presbitero2 = new LiderancaIgreja("Presbítero Paulo", "Presbítero", 
                "Olhai por vós e por todo o rebanho - Atos 20:28");

            var diacono1 = new LiderancaIgreja("Diácono Estêvão", "Diácono", 
                "Servir às mesas - Atos 6:2");

            var diacono2 = new LiderancaIgreja("Diácono Filipe", "Diácono", 
                "Homens de boa reputação - Atos 6:3");

            // Criando membros individuais
            var membro1 = new MembroIgreja("Maria", "Líder de Louvor", "Música");
            var membro2 = new MembroIgreja("José", "Professor EBD", "Ensino");
            var membro3 = new MembroIgreja("Ana", "Evangelista", "Evangelismo");
            var membro4 = new MembroIgreja("Davi", "Jovem", "Intercessão");
            var membro5 = new MembroIgreja("Sara", "Criança", "Alegria");
            var membro6 = new MembroIgreja("Rute", "Idosa", "Sabedoria");
            var membro7 = new MembroIgreja("Samuel", "Porteiro", "Hospitalidade");
            var membro8 = new MembroIgreja("Débora", "Secretária", "Administração");

            // Construindo a hierarquia
            Console.WriteLine("--- Construindo Hierarquia da Igreja ---");
            
            // Pastor supervisiona presbíteros
            pastor.AdicionarMembro(presbitero1);
            pastor.AdicionarMembro(presbitero2);

            // Presbíteros supervisionam diáconos
            presbitero1.AdicionarMembro(diacono1);
            presbitero2.AdicionarMembro(diacono2);

            // Diáconos lideram grupos de membros
            diacono1.AdicionarMembro(membro1);
            diacono1.AdicionarMembro(membro2);
            diacono1.AdicionarMembro(membro3);
            diacono1.AdicionarMembro(membro4);

            diacono2.AdicionarMembro(membro5);
            diacono2.AdicionarMembro(membro6);
            diacono2.AdicionarMembro(membro7);
            diacono2.AdicionarMembro(membro8);

            Console.WriteLine();

            // Mostrando a hierarquia completa
            Console.WriteLine("--- Hierarquia Completa da Igreja ---");
            pastor.MostrarHierarquia();
            Console.WriteLine();

            // Contando membros
            Console.WriteLine("--- Estatísticas da Igreja ---");
            Console.WriteLine($"Total de membros na igreja: {pastor.ContarMembros()}");
            Console.WriteLine($"Membros sob Presbítero Pedro: {presbitero1.ContarMembros()}");
            Console.WriteLine($"Membros sob Presbítero Paulo: {presbitero2.ContarMembros()}");
            Console.WriteLine();

            // Demonstrando ministração em cascata
            Console.WriteLine("--- Ministração em Cascata ---");
            Console.WriteLine("Pastor iniciando culto - todos ministram:");
            pastor.Ministrar();
            Console.WriteLine();

            // Demonstrando remoção de membro
            Console.WriteLine("--- Reorganização da Igreja ---");
            Console.WriteLine("Transferindo Maria para outro diácono:");
            diacono1.RemoverMembro(membro1);
            diacono2.AdicionarMembro(membro1);
            Console.WriteLine();

            Console.WriteLine("Nova distribuição:");
            Console.WriteLine($"Membros sob Diácono Estêvão: {diacono1.ContarMembros()}");
            Console.WriteLine($"Membros sob Diácono Filipe: {diacono2.ContarMembros()}");
        }
    }
}

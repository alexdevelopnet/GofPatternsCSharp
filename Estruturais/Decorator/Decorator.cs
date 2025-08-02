using System;

namespace Estruturais.Decorator
{
    // Component - Interface base para pessoas
    public interface IPessoa
    {
        string GetDescricao();
        string GetVirtudes();
        int GetNivelEspiritual();
    }

    // ConcreteComponent - Pessoa base
    public class PessoaBase : IPessoa
    {
        private string _nome;

        public PessoaBase(string nome)
        {
            _nome = nome;
        }

        public virtual string GetDescricao()
        {
            return $"{_nome} - uma pessoa comum";
        }

        public virtual string GetVirtudes()
        {
            return "Virtudes básicas";
        }

        public virtual int GetNivelEspiritual()
        {
            return 1;
        }
    }

    // Decorator base - Decorator abstrato para virtudes
    public abstract class VirtudeCrista : IPessoa
    {
        protected IPessoa _pessoa;

        public VirtudeCrista(IPessoa pessoa)
        {
            _pessoa = pessoa;
        }

        public virtual string GetDescricao()
        {
            return _pessoa.GetDescricao();
        }

        public virtual string GetVirtudes()
        {
            return _pessoa.GetVirtudes();
        }

        public virtual int GetNivelEspiritual()
        {
            return _pessoa.GetNivelEspiritual();
        }
    }

    // ConcreteDecorators - Virtudes específicas
    public class Fe : VirtudeCrista
    {
        public Fe(IPessoa pessoa) : base(pessoa) { }

        public override string GetDescricao()
        {
            return _pessoa.GetDescricao() + " + Fé";
        }

        public override string GetVirtudes()
        {
            return _pessoa.GetVirtudes() + ", Fé ('Ora, a fé é o firme fundamento das coisas que se esperam' - Hebreus 11:1)";
        }

        public override int GetNivelEspiritual()
        {
            return _pessoa.GetNivelEspiritual() + 2;
        }
    }

    public class Esperanca : VirtudeCrista
    {
        public Esperanca(IPessoa pessoa) : base(pessoa) { }

        public override string GetDescricao()
        {
            return _pessoa.GetDescricao() + " + Esperança";
        }

        public override string GetVirtudes()
        {
            return _pessoa.GetVirtudes() + ", Esperança ('A esperança que se vê não é esperança' - Romanos 8:24)";
        }

        public override int GetNivelEspiritual()
        {
            return _pessoa.GetNivelEspiritual() + 2;
        }
    }

    public class Amor : VirtudeCrista
    {
        public Amor(IPessoa pessoa) : base(pessoa) { }

        public override string GetDescricao()
        {
            return _pessoa.GetDescricao() + " + Amor";
        }

        public override string GetVirtudes()
        {
            return _pessoa.GetVirtudes() + ", Amor ('O amor é paciente, o amor é bondoso' - 1 Coríntios 13:4)";
        }

        public override int GetNivelEspiritual()
        {
            return _pessoa.GetNivelEspiritual() + 3; // Amor é a maior virtude
        }
    }

    public class Paciencia : VirtudeCrista
    {
        public Paciencia(IPessoa pessoa) : base(pessoa) { }

        public override string GetDescricao()
        {
            return _pessoa.GetDescricao() + " + Paciência";
        }

        public override string GetVirtudes()
        {
            return _pessoa.GetVirtudes() + ", Paciência ('A paciência dos santos' - Apocalipse 14:12)";
        }

        public override int GetNivelEspiritual()
        {
            return _pessoa.GetNivelEspiritual() + 1;
        }
    }

    public class Humildade : VirtudeCrista
    {
        public Humildade(IPessoa pessoa) : base(pessoa) { }

        public override string GetDescricao()
        {
            return _pessoa.GetDescricao() + " + Humildade";
        }

        public override string GetVirtudes()
        {
            return _pessoa.GetVirtudes() + ", Humildade ('Deus resiste aos soberbos, mas dá graça aos humildes' - Tiago 4:6)";
        }

        public override int GetNivelEspiritual()
        {
            return _pessoa.GetNivelEspiritual() + 2;
        }
    }

    public class Sabedoria : VirtudeCrista
    {
        public Sabedoria(IPessoa pessoa) : base(pessoa) { }

        public override string GetDescricao()
        {
            return _pessoa.GetDescricao() + " + Sabedoria";
        }

        public override string GetVirtudes()
        {
            return _pessoa.GetVirtudes() + ", Sabedoria ('O temor do Senhor é o princípio da sabedoria' - Provérbios 9:10)";
        }

        public override int GetNivelEspiritual()
        {
            return _pessoa.GetNivelEspiritual() + 2;
        }
    }

    public class Generosidade : VirtudeCrista
    {
        public Generosidade(IPessoa pessoa) : base(pessoa) { }

        public override string GetDescricao()
        {
            return _pessoa.GetDescricao() + " + Generosidade";
        }

        public override string GetVirtudes()
        {
            return _pessoa.GetVirtudes() + ", Generosidade ('Mais bem-aventurada coisa é dar do que receber' - Atos 20:35)";
        }

        public override int GetNivelEspiritual()
        {
            return _pessoa.GetNivelEspiritual() + 1;
        }
    }

    public class Perdao : VirtudeCrista
    {
        public Perdao(IPessoa pessoa) : base(pessoa) { }

        public override string GetDescricao()
        {
            return _pessoa.GetDescricao() + " + Perdão";
        }

        public override string GetVirtudes()
        {
            return _pessoa.GetVirtudes() + ", Perdão ('Perdoai, e sereis perdoados' - Lucas 6:37)";
        }

        public override int GetNivelEspiritual()
        {
            return _pessoa.GetNivelEspiritual() + 2;
        }
    }

    // Aplicação de exemplo
    public class MinhaAppDecorator
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO DECORATOR: Virtudes Cristãs ===\n");

            // Criando uma pessoa base
            IPessoa joao = new PessoaBase("João");
            Console.WriteLine("--- Pessoa Base ---");
            MostrarPessoa(joao);
            Console.WriteLine();

            // Adicionando virtudes uma por uma (decorando)
            Console.WriteLine("--- Adicionando Fé ---");
            joao = new Fe(joao);
            MostrarPessoa(joao);
            Console.WriteLine();

            Console.WriteLine("--- Adicionando Esperança ---");
            joao = new Esperanca(joao);
            MostrarPessoa(joao);
            Console.WriteLine();

            Console.WriteLine("--- Adicionando Amor ---");
            joao = new Amor(joao);
            MostrarPessoa(joao);
            Console.WriteLine();

            Console.WriteLine("--- Adicionando Paciência ---");
            joao = new Paciencia(joao);
            MostrarPessoa(joao);
            Console.WriteLine();

            Console.WriteLine("--- Adicionando Humildade ---");
            joao = new Humildade(joao);
            MostrarPessoa(joao);
            Console.WriteLine();

            // Criando outra pessoa com diferentes combinações
            Console.WriteLine("=== OUTRA PESSOA COM DIFERENTES VIRTUDES ===\n");
            
            IPessoa maria = new PessoaBase("Maria");
            Console.WriteLine("--- Maria Base ---");
            MostrarPessoa(maria);
            Console.WriteLine();

            // Decorando Maria com virtudes diferentes
            maria = new Sabedoria(new Generosidade(new Perdao(new Fe(maria))));
            Console.WriteLine("--- Maria com Fé, Perdão, Generosidade e Sabedoria ---");
            MostrarPessoa(maria);
            Console.WriteLine();

            // Demonstrando flexibilidade - criando um santo
            Console.WriteLine("=== CRIANDO UM SANTO ===\n");
            IPessoa santo = new PessoaBase("São Francisco");
            santo = new Amor(new Humildade(new Paciencia(new Generosidade(new Perdao(new Fe(new Esperanca(new Sabedoria(santo))))))));
            
            Console.WriteLine("--- São Francisco com todas as virtudes ---");
            MostrarPessoa(santo);
            Console.WriteLine();

            // Comparando níveis espirituais
            Console.WriteLine("=== COMPARAÇÃO DE NÍVEIS ESPIRITUAIS ===");
            var pessoaSimples = new PessoaBase("Pedro");
            var pessoaComFe = new Fe(new PessoaBase("Paulo"));
            var pessoaVirtuosa = new Amor(new Fe(new Esperanca(new PessoaBase("Tiago"))));

            Console.WriteLine($"Pedro (simples): Nível {pessoaSimples.GetNivelEspiritual()}");
            Console.WriteLine($"Paulo (com fé): Nível {pessoaComFe.GetNivelEspiritual()}");
            Console.WriteLine($"Tiago (virtuoso): Nível {pessoaVirtuosa.GetNivelEspiritual()}");
            Console.WriteLine($"São Francisco (santo): Nível {santo.GetNivelEspiritual()}");
        }

        private static void MostrarPessoa(IPessoa pessoa)
        {
            Console.WriteLine($"Descrição: {pessoa.GetDescricao()}");
            Console.WriteLine($"Nível Espiritual: {pessoa.GetNivelEspiritual()}");
            Console.WriteLine($"Virtudes: {pessoa.GetVirtudes()}");
        }
    }
}

using System;
using System.Collections.Generic;

namespace Comportamentais.Observer
{
    // Interface Observer
    public interface IObserver
    {
        void Update(string mensagem);
    }

    // Interface Subject
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string mensagem);
    }

    // Concrete Subject - Anjo do Senhor
    public class AnjoDoSenhor : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _nome;

        public AnjoDoSenhor(string nome)
        {
            _nome = nome;
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine($"Anjo {_nome}: Um novo observador foi adicionado.");
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine($"Anjo {_nome}: Um observador foi removido.");
        }

        public void Notify(string mensagem)
        {
            Console.WriteLine($"Anjo {_nome}: Enviando mensagem divina...");
            foreach (var observer in _observers)
            {
                observer.Update(mensagem);
            }
        }

        public void AnunciarNascimento()
        {
            Console.WriteLine($"Anjo {_nome}: *** EVENTO DIVINO ACONTECENDO ***");
            Notify("Não temais! Eis que vos anuncio uma grande alegria: hoje vos nasceu na cidade de Davi o Salvador, que é Cristo, o Senhor!");
        }

        public void AnunciarGloriaADeus()
        {
            Console.WriteLine($"Anjo {_nome}: *** CORO CELESTIAL ***");
            Notify("Glória a Deus nas alturas, e paz na terra entre os homens a quem ele quer bem!");
        }
    }

    // Concrete Observers - Pastores
    public class Pastor : IObserver
    {
        private string _nome;
        private string _localizacao;

        public Pastor(string nome, string localizacao)
        {
            _nome = nome;
            _localizacao = localizacao;
        }

        public void Update(string mensagem)
        {
            Console.WriteLine($"Pastor {_nome} (em {_localizacao}): Ouvi a mensagem do anjo: '{mensagem}'");
            Console.WriteLine($"Pastor {_nome}: Vamos depressa a Belém ver isso que aconteceu!");
        }
    }

    // Concrete Observer - Reis Magos
    public class ReiMago : IObserver
    {
        private string _nome;
        private string _presente;

        public ReiMago(string nome, string presente)
        {
            _nome = nome;
            _presente = presente;
        }

        public void Update(string mensagem)
        {
            Console.WriteLine($"Rei Mago {_nome}: Recebi a mensagem celestial: '{mensagem}'");
            Console.WriteLine($"Rei Mago {_nome}: Seguirei a estrela levando {_presente} para o Menino!");
        }
    }

    // Concrete Observer - Maria
    public class Maria : IObserver
    {
        public void Update(string mensagem)
        {
            Console.WriteLine($"Maria: Ouvi as palavras do anjo: '{mensagem}'");
            Console.WriteLine("Maria: Guardava todas estas coisas, conferindo-as em seu coração.");
        }
    }

    // Aplicação de exemplo
    public class MinhaAppObserver
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO OBSERVER: Anunciação do Nascimento de Jesus ===\n");

            // Criando o subject (anjo)
            var anjoGabriel = new AnjoDoSenhor("Gabriel");

            // Criando os observers
            var pastorJose = new Pastor("José", "campos de Belém");
            var pastorDavi = new Pastor("Davi", "colinas próximas");
            var pastorSamuel = new Pastor("Samuel", "vale dos pastores");

            var reiGaspar = new ReiMago("Gaspar", "ouro");
            var reiMelchior = new ReiMago("Melchior", "incenso");
            var reiBaltazar = new ReiMago("Baltazar", "mirra");

            var maria = new Maria();

            // Registrando os observers
            Console.WriteLine("--- Registrando os observadores ---");
            anjoGabriel.Attach(pastorJose);
            anjoGabriel.Attach(pastorDavi);
            anjoGabriel.Attach(pastorSamuel);
            anjoGabriel.Attach(reiGaspar);
            anjoGabriel.Attach(reiMelchior);
            anjoGabriel.Attach(reiBaltazar);
            anjoGabriel.Attach(maria);
            Console.WriteLine();

            // Primeiro anúncio
            Console.WriteLine("--- Primeiro Anúncio ---");
            anjoGabriel.AnunciarNascimento();
            Console.WriteLine();

            // Removendo um observer
            Console.WriteLine("--- Removendo um pastor ---");
            anjoGabriel.Detach(pastorSamuel);
            Console.WriteLine();

            // Segundo anúncio
            Console.WriteLine("--- Segundo Anúncio ---");
            anjoGabriel.AnunciarGloriaADeus();
        }
    }
}

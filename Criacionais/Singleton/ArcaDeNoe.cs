using System;
using System.Collections.Generic;

namespace Criacionais.Singleton
{
    public class ArcaDeNoe
    {
        private static ArcaDeNoe? _instancia;
        private static readonly object _lock = new object();

        private List<string> passageiros = new List<string>();

        private ArcaDeNoe() { }

        public static ArcaDeNoe Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    lock (_lock)
                    {
                        if (_instancia == null)
                            _instancia = new ArcaDeNoe();
                    }
                }
                return _instancia;
            }
        }

        public void Embarcar(string nome)
        {
            passageiros.Add(nome);
            Console.WriteLine($"{nome} embarcou na Arca!");
        }

        public void ListarPassageiros()
        {
            Console.WriteLine("Passageiros na Arca:");
            foreach (var p in passageiros)
                Console.WriteLine($"- {p}");
        }
    }
}
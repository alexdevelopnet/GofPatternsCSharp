using System;

namespace GoFPatternsCSharp.AbstractFactory
{
    public class PersonagemNovoTestamento : IPersonagemBiblico
    {
        public void Apresentar()
        {
            Console.WriteLine("Personagem: Jesus");
        }
    }
}
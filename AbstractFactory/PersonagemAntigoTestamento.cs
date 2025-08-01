using System;

namespace GoFPatternsCSharp.AbstractFactory
{
    public class PersonagemAntigoTestamento : IPersonagemBiblico
    {
        public void Apresentar()
        {
            Console.WriteLine("Personagem: Moisés");
        }
    }
}
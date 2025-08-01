using System;

namespace GoFPatternsCSharp.Prototype
{
    public class MinhaAppPrototype
    {
        public static void Executar()
        {
            var roloOriginal = new RoloDasEscrituras("Isaías", "Consolai, consolai o meu povo, diz o vosso Deus.");
            Console.WriteLine("Rolo original:");
            roloOriginal.Ler();

            var roloCopia = (RoloDasEscrituras)roloOriginal.Clonar();
            roloCopia.Livro = "Cópia de Isaías";
            Console.WriteLine("Rolo copiado:");
            roloCopia.Ler();

            Console.WriteLine("Rolo original permanece inalterado:");
            roloOriginal.Ler();
        }
    }
}
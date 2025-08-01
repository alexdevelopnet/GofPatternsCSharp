using Criacionais.FactoryMethod;
using System;

namespace GoFPatternsCSharp.FactoryMethod
{
    public class MinhaAppBiblia
    { 
        public static void Executar()
        {
            FabricaImpressao fabricaSimples = new FabricaImpressaoSimples();
            FabricaImpressao fabricaComentada = new FabricaImpressaoComentada();

            var versiculoSimples = fabricaSimples.CriarImpressao("João", 3, 16, "Porque Deus amou o mundo de tal maneira...");
            var versiculoComentado = fabricaComentada.CriarImpressao("Salmos", 23, 1, "O Senhor é o meu pastor; nada me faltará.", "Este versículo fala sobre confiança em Deus.");

            versiculoSimples.Imprimir();
            Console.WriteLine();
            versiculoComentado.Imprimir();
        }
    }
}
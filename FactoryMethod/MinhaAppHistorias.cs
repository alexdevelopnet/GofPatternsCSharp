using System;

namespace GoFPatternsCSharp.FactoryMethod
{
    public class MinhaAppHistorias
    {
        public static void Executar()
        {
            FabricaHistoria fabricaMilagre = new FabricaMilagre();
            FabricaHistoria fabricaParabola = new FabricaParabola();
            FabricaHistoria fabricaProfecia = new FabricaProfecia();

            var historia1 = fabricaMilagre.CriarHistoria(
                "Jesus anda sobre as águas",
                "Mateus 14:22-33",
                "Jesus caminha sobre o mar para encontrar os discípulos durante uma tempestade."
            );

            var historia2 = fabricaParabola.CriarHistoria(
                "O Bom Samaritano",
                "Lucas 10:25-37",
                "Jesus conta a parábola de um homem que ajuda outro, mostrando o que é amar o próximo."
            );

            var historia3 = fabricaProfecia.CriarHistoria(
                "Profecia do Messias",
                "Isaías 53",
                "Isaías profetiza sobre o sofrimento e redenção do Messias."
            );

            historia1.Contar();
            historia2.Contar();
            historia3.Contar();
        }
    }
}
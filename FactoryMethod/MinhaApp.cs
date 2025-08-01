using System;

namespace GoFPatternsCSharp.FactoryMethod
{
    public class MinhaApp
    {
        public static void Main(string[] args)
        {
            // Empresas de ônibus
            Empresa viacaoABCLocal = new EmpresaOnibusUrbano();
            Empresa viacaoXYZInter = new EmpresaOnibusInterestadual();

            // Emite passagens
            Passagem pUrbano = viacaoABCLocal.EmitePassagem("São Paulo", "Campinas", new DateTime(2016, 3, 10, 11, 0, 0));
            Passagem pInterestadual = viacaoXYZInter.EmitePassagem("São Paulo", "Rio de Janeiro", new DateTime(2016, 4, 20, 8, 30, 0));

            // Exibe detalhes da passagem
            pUrbano.ExibeDetalhes();
            pInterestadual.ExibeDetalhes();
        }
    }
}
using System;

namespace GoFPatternsCSharp.Singleton
{
    public class MinhaAppSingletonHistorias
    {
        public static void Executar()
        {
            var repo = RepositorioHistoriasBiblicas.Instancia;

            repo.Adicionar(new HistoriaBiblica(
                "Jesus anda sobre as águas",
                "Mateus 14:22-33",
                "Jesus caminha sobre o mar para encontrar os discípulos durante uma tempestade."
            ));

            repo.Adicionar(new HistoriaBiblica(
                "O Bom Samaritano",
                "Lucas 10:25-37",
                "Jesus conta a parábola de um homem que ajuda outro, mostrando o que é amar o próximo."
            ));

            repo.Adicionar(new HistoriaBiblica(
                "Profecia do Messias",
                "Isaías 53",
                "Isaías profetiza sobre o sofrimento e redenção do Messias."
            ));

            Console.WriteLine("Listando todas as histórias do repositório Singleton:\n");
            foreach (var historia in repo.Listar())
            {
                historia.Contar();
            }

            Console.WriteLine("Buscando uma história específica:\n");
            var buscada = repo.BuscarPorTitulo("O Bom Samaritano");
            buscada?.Contar();
        }
    }
}
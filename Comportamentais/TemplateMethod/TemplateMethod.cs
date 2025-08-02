using System;

namespace Comportamentais.TemplateMethod
{
    // Abstract Class - Ritual de Adoração
    public abstract class RitualAdoracao
    {
        // Template Method - define o algoritmo geral
        public void RealizarCulto()
        {
            Console.WriteLine("=== INICIANDO CULTO DE ADORAÇÃO ===");
            PrepararLocal();
            ChamarPovo();
            AbrirCulto();
            LerEscrituras();
            Adorar();
            Pregar();
            ChamarParaOracao();
            EncerrarCulto();
            Console.WriteLine("=== CULTO ENCERRADO ===\n");
        }

        // Métodos que devem ser implementados pelas subclasses
        protected abstract void PrepararLocal();
        protected abstract void Adorar();
        protected abstract void Pregar();

        // Métodos com implementação padrão (podem ser sobrescritos)
        protected virtual void ChamarPovo()
        {
            Console.WriteLine("Chamando o povo para adoração...");
        }

        protected virtual void AbrirCulto()
        {
            Console.WriteLine("Abrindo o culto em nome do Senhor...");
        }

        protected virtual void LerEscrituras()
        {
            Console.WriteLine("Lendo as Sagradas Escrituras...");
        }

        protected virtual void ChamarParaOracao()
        {
            Console.WriteLine("Chamando o povo para oração...");
        }

        protected virtual void EncerrarCulto()
        {
            Console.WriteLine("Encerrando com bênção apostólica...");
        }

        // Hook method - permite customização opcional
        protected virtual bool DeveIncluirOferta()
        {
            return true;
        }

        protected void ColetarOferta()
        {
            if (DeveIncluirOferta())
            {
                Console.WriteLine("Coletando ofertas para a obra do Senhor...");
            }
        }
    }

    // Concrete Class - Culto no Templo de Salomão
    public class CultoTemploSalomao : RitualAdoracao
    {
        protected override void PrepararLocal()
        {
            Console.WriteLine("Preparando o Santo Templo de Salomão...");
            Console.WriteLine("Acendendo o candelabro de ouro...");
            Console.WriteLine("Preparando o altar de incenso...");
        }

        protected override void Adorar()
        {
            Console.WriteLine("Levitas cantando com harpas, alaúdes e címbalos...");
            Console.WriteLine("'Louvai ao Senhor, porque é bom; porque a sua benignidade dura para sempre!'");
            Console.WriteLine("A glória do Senhor enche o templo...");
        }

        protected override void Pregar()
        {
            Console.WriteLine("Salomão pregando sobre a sabedoria de Deus...");
            Console.WriteLine("'O temor do Senhor é o princípio da sabedoria'");
        }

        protected override void LerEscrituras()
        {
            Console.WriteLine("Lendo os rolos da Lei de Moisés...");
            Console.WriteLine("Lendo os Salmos de Davi...");
        }
    }

    // Concrete Class - Culto na Sinagoga
    public class CultoSinagoga : RitualAdoracao
    {
        protected override void PrepararLocal()
        {
            Console.WriteLine("Preparando a sinagoga...");
            Console.WriteLine("Organizando os assentos para os anciãos...");
            Console.WriteLine("Preparando os rolos das Escrituras...");
        }

        protected override void Adorar()
        {
            Console.WriteLine("Recitando o Shemá: 'Ouve, ó Israel: O Senhor nosso Deus é o único Senhor'");
            Console.WriteLine("Cantando salmos em hebraico...");
        }

        protected override void Pregar()
        {
            Console.WriteLine("Rabino explicando a Torah...");
            Console.WriteLine("Interpretando as Escrituras para o povo...");
        }

        protected override void ChamarPovo()
        {
            Console.WriteLine("Tocando o shofar para chamar o povo...");
        }
    }

    // Concrete Class - Culto Cristão Primitivo
    public class CultoCristao : RitualAdoracao
    {
        protected override void PrepararLocal()
        {
            Console.WriteLine("Preparando a casa para o culto cristão...");
            Console.WriteLine("Organizando o cenáculo...");
            Console.WriteLine("Preparando pão e vinho para a Ceia...");
        }

        protected override void Adorar()
        {
            Console.WriteLine("Cantando hinos cristãos...");
            Console.WriteLine("'Digno é o Cordeiro que foi morto!'");
            Console.WriteLine("Adoração em espírito e em verdade...");
        }

        protected override void Pregar()
        {
            Console.WriteLine("Apóstolo pregando sobre Jesus Cristo...");
            Console.WriteLine("'Cristo morreu pelos nossos pecados e ressuscitou ao terceiro dia'");
        }

        protected override void LerEscrituras()
        {
            Console.WriteLine("Lendo cartas dos apóstolos...");
            Console.WriteLine("Lendo os evangelhos sobre Jesus...");
        }

        protected override void EncerrarCulto()
        {
            Console.WriteLine("Partindo o pão em memória de Jesus...");
            Console.WriteLine("'Fazei isto em memória de mim'");
            base.EncerrarCulto();
        }

        protected override bool DeveIncluirOferta()
        {
            return true; // Cristãos sempre incluem ofertas para os necessitados
        }
    }

    // Concrete Class - Culto no Deserto (Moisés)
    public class CultoDeserto : RitualAdoracao
    {
        protected override void PrepararLocal()
        {
            Console.WriteLine("Preparando o Tabernáculo no deserto...");
            Console.WriteLine("Armando a Tenda da Congregação...");
            Console.WriteLine("Preparando o altar de holocaustos...");
        }

        protected override void Adorar()
        {
            Console.WriteLine("Oferecendo holocaustos ao Senhor...");
            Console.WriteLine("A nuvem de glória paira sobre o tabernáculo...");
            Console.WriteLine("'Santo, Santo, Santo é o Senhor dos Exércitos!'");
        }

        protected override void Pregar()
        {
            Console.WriteLine("Moisés ensinando a Lei do Senhor...");
            Console.WriteLine("'Ouve, ó Israel, os estatutos e juízos que hoje vos falo'");
        }

        protected override bool DeveIncluirOferta()
        {
            return false; // No deserto, as ofertas eram diferentes
        }
    }

    // Aplicação de exemplo
    public class MinhaAppTemplateMethod
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO TEMPLATE METHOD: Rituais de Adoração ===\n");

            // Culto no Templo de Salomão
            Console.WriteLine("--- CULTO NO TEMPLO DE SALOMÃO ---");
            var cultoTemplo = new CultoTemploSalomao();
            cultoTemplo.RealizarCulto();

            // Culto na Sinagoga
            Console.WriteLine("--- CULTO NA SINAGOGA ---");
            var cultoSinagoga = new CultoSinagoga();
            cultoSinagoga.RealizarCulto();

            // Culto Cristão Primitivo
            Console.WriteLine("--- CULTO CRISTÃO PRIMITIVO ---");
            var cultoCristao = new CultoCristao();
            cultoCristao.RealizarCulto();

            // Culto no Deserto
            Console.WriteLine("--- CULTO NO DESERTO (MOISÉS) ---");
            var cultoDeserto = new CultoDeserto();
            cultoDeserto.RealizarCulto();
        }
    }
}

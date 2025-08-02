using System;

namespace Estruturais.Facade
{
    // Subsistemas complexos que compõem o culto
    public class SistemaAudio
    {
        public void LigarMicrofones()
        {
            Console.WriteLine("🎤 Ligando microfones...");
        }

        public void ConfigurarVolume()
        {
            Console.WriteLine("🔊 Ajustando volume do sistema de som...");
        }

        public void TestarAudio()
        {
            Console.WriteLine("🎵 Testando áudio: 'Alô, alô, testando 1, 2, 3...'");
        }

        public void DesligarSistema()
        {
            Console.WriteLine("🔇 Desligando sistema de áudio...");
        }
    }

    public class SistemaIluminacao
    {
        public void LigarLuzesGerais()
        {
            Console.WriteLine("💡 Acendendo luzes gerais do templo...");
        }

        public void ConfigurarLuzesAltar()
        {
            Console.WriteLine("✨ Configurando iluminação especial do altar...");
        }

        public void DimmerParaLouvor()
        {
            Console.WriteLine("🌟 Ajustando luzes para momento de louvor...");
        }

        public void IluminacaoParaPregacao()
        {
            Console.WriteLine("🔆 Iluminação focada no púlpito para pregação...");
        }

        public void DesligarLuzes()
        {
            Console.WriteLine("🌙 Desligando luzes do templo...");
        }
    }

    public class SistemaClimatizacao
    {
        public void LigarArCondicionado()
        {
            Console.WriteLine("❄️ Ligando ar condicionado...");
        }

        public void AjustarTemperatura()
        {
            Console.WriteLine("🌡️ Ajustando temperatura para 22°C...");
        }

        public void DesligarClimatizacao()
        {
            Console.WriteLine("🔌 Desligando sistema de climatização...");
        }
    }

    public class EquipeMinisterio
    {
        public void PrepararLouvor()
        {
            Console.WriteLine("🎼 Equipe de louvor afinando instrumentos...");
            Console.WriteLine("🎹 Testando piano e violão...");
            Console.WriteLine("🥁 Ajustando bateria...");
        }

        public void PrepararPregacao()
        {
            Console.WriteLine("📖 Pastor revisando sermão...");
            Console.WriteLine("🙏 Momento de oração antes da pregação...");
        }

        public void PrepararComunhao()
        {
            Console.WriteLine("🍞 Preparando pão e vinho para comunhão...");
            Console.WriteLine("⛪ Organizando mesa da comunhão...");
        }

        public void FinalizarMinisterio()
        {
            Console.WriteLine("🤝 Equipe se despedindo dos irmãos...");
            Console.WriteLine("📚 Guardando instrumentos e materiais...");
        }
    }

    public class SistemaSeguranca
    {
        public void AbrirPortas()
        {
            Console.WriteLine("🚪 Abrindo portas do templo...");
        }

        public void VerificarSaidas()
        {
            Console.WriteLine("🚨 Verificando saídas de emergência...");
        }

        public void FecharETravar()
        {
            Console.WriteLine("🔒 Fechando e travando todas as portas...");
        }

        public void AtivarAlarme()
        {
            Console.WriteLine("🔔 Ativando sistema de alarme...");
        }
    }

    public class LimpezaOrganizacao
    {
        public void LimparTemplo()
        {
            Console.WriteLine("🧹 Limpando e organizando bancos...");
            Console.WriteLine("✨ Limpando altar e púlpito...");
        }

        public void OrganizarMateriais()
        {
            Console.WriteLine("📋 Organizando hinários e Bíblias...");
            Console.WriteLine("🗂️ Preparando materiais para EBD...");
        }

        public void LimpezaFinal()
        {
            Console.WriteLine("🧽 Limpeza final após o culto...");
            Console.WriteLine("🗑️ Recolhendo lixo e organizando espaço...");
        }
    }

    // Facade - Interface simplificada para gerenciar o culto
    public class CultoFacade
    {
        private SistemaAudio _audio;
        private SistemaIluminacao _iluminacao;
        private SistemaClimatizacao _climatizacao;
        private EquipeMinisterio _ministerio;
        private SistemaSeguranca _seguranca;
        private LimpezaOrganizacao _limpeza;

        public CultoFacade()
        {
            _audio = new SistemaAudio();
            _iluminacao = new SistemaIluminacao();
            _climatizacao = new SistemaClimatizacao();
            _ministerio = new EquipeMinisterio();
            _seguranca = new SistemaSeguranca();
            _limpeza = new LimpezaOrganizacao();
        }

        public void PrepararCulto()
        {
            Console.WriteLine("=== PREPARANDO CULTO ===");
            Console.WriteLine("'Tudo, porém, seja feito com decência e ordem' - 1 Coríntios 14:40\n");

            // Preparação do ambiente físico
            _limpeza.LimparTemplo();
            _limpeza.OrganizarMateriais();
            
            // Sistemas técnicos
            _seguranca.AbrirPortas();
            _seguranca.VerificarSaidas();
            _climatizacao.LigarArCondicionado();
            _climatizacao.AjustarTemperatura();
            
            // Audio e iluminação
            _iluminacao.LigarLuzesGerais();
            _audio.LigarMicrofones();
            _audio.ConfigurarVolume();
            _audio.TestarAudio();
            
            // Equipe ministerial
            _ministerio.PrepararLouvor();
            
            Console.WriteLine("\n✅ Templo preparado para receber os irmãos!\n");
        }

        public void IniciarLouvor()
        {
            Console.WriteLine("=== INICIANDO MOMENTO DE LOUVOR ===");
            Console.WriteLine("'Louvai ao Senhor com harpa, cantai-lhe com saltério de dez cordas' - Salmos 33:2\n");
            
            _iluminacao.DimmerParaLouvor();
            _iluminacao.ConfigurarLuzesAltar();
            
            Console.WriteLine("🎵 Iniciando cânticos de louvor e adoração...");
            Console.WriteLine("🙌 Congregação adorando em espírito e verdade...\n");
        }

        public void IniciarPregacao()
        {
            Console.WriteLine("=== INICIANDO PREGAÇÃO DA PALAVRA ===");
            Console.WriteLine("'Prega a palavra, insta a tempo e fora de tempo' - 2 Timóteo 4:2\n");
            
            _iluminacao.IluminacaoParaPregacao();
            _ministerio.PrepararPregacao();
            
            Console.WriteLine("📖 Pastor pregando a Palavra de Deus...");
            Console.WriteLine("👂 Congregação atenta à mensagem...\n");
        }

        public void RealizarComunhao()
        {
            Console.WriteLine("=== MOMENTO DA SANTA CEIA ===");
            Console.WriteLine("'Fazei isto em memória de mim' - 1 Coríntios 11:24\n");
            
            _ministerio.PrepararComunhao();
            
            Console.WriteLine("🍞 Partilhando o pão...");
            Console.WriteLine("🍷 Partilhando o vinho...");
            Console.WriteLine("🙏 Momento de reflexão e comunhão...\n");
        }

        public void EncerrarCulto()
        {
            Console.WriteLine("=== ENCERRANDO CULTO ===");
            Console.WriteLine("'A graça do Senhor Jesus Cristo seja com todos vós' - Apocalipse 22:21\n");
            
            Console.WriteLine("🤝 Momento de confraternização...");
            _ministerio.FinalizarMinisterio();
            
            // Finalizando sistemas
            _limpeza.LimpezaFinal();
            _audio.DesligarSistema();
            _iluminacao.DesligarLuzes();
            _climatizacao.DesligarClimatizacao();
            _seguranca.FecharETravar();
            _seguranca.AtivarAlarme();
            
            Console.WriteLine("\n✅ Culto encerrado com bênção!\n");
        }

        public void CultoCompleto()
        {
            Console.WriteLine("🏛️ REALIZANDO CULTO COMPLETO 🏛️\n");
            
            PrepararCulto();
            IniciarLouvor();
            IniciarPregacao();
            RealizarComunhao();
            EncerrarCulto();
            
            Console.WriteLine("🙏 'Quão amáveis são os teus tabernáculos, Senhor dos Exércitos!' - Salmos 84:1");
        }
    }

    // Aplicação de exemplo
    public class MinhaAppFacade
    {
        public static void Executar()
        {
            Console.WriteLine("=== PADRÃO FACADE: Gerenciamento de Culto ===\n");

            var culto = new CultoFacade();

            Console.WriteLine("--- Opção 1: Culto Completo (Facade simplifica tudo) ---");
            culto.CultoCompleto();
            Console.WriteLine();

            Console.WriteLine("--- Opção 2: Controle Granular das Etapas ---");
            Console.WriteLine("(O Facade também permite controle individual)\n");
            
            var cultoVespertino = new CultoFacade();
            
            Console.WriteLine("🌅 CULTO VESPERTINO");
            cultoVespertino.PrepararCulto();
            
            Console.WriteLine("Apenas louvor e oração hoje:");
            cultoVespertino.IniciarLouvor();
            
            Console.WriteLine("Encerrando culto de oração:");
            cultoVespertino.EncerrarCulto();

            Console.WriteLine("\n💡 VANTAGEM DO FACADE:");
            Console.WriteLine("- Interface simples para operações complexas");
            Console.WriteLine("- Oculta a complexidade dos subsistemas");
            Console.WriteLine("- Permite tanto uso simplificado quanto granular");
            Console.WriteLine("- Facilita manutenção e mudanças nos subsistemas");
        }
    }
}

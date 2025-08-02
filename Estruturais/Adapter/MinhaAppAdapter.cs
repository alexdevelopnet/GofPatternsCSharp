using System;

namespace Estruturais.Adapter
{
    public class MinhaAppAdapter
    {
        public static void Executar()
        {
            IMensagemEvangelho mensagem = new AdapterPaulo(new MensagemJudaica());
            mensagem.Anunciar();
        }
    }
}
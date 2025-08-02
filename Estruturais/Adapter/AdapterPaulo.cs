using System;

namespace Estruturais.Adapter
{
    public class AdapterPaulo : IMensagemEvangelho
    {
        private readonly MensagemJudaica _mensagemJudaica;

        public AdapterPaulo(MensagemJudaica mensagemJudaica)
        {
            _mensagemJudaica = mensagemJudaica;
        }

        public void Anunciar()
        {
            Console.WriteLine("Paulo adapta a mensagem para o contexto:");
            _mensagemJudaica.ProclamarTorah();
        }
    }
}
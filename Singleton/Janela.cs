 
using System.Drawing;
using System.Windows.Forms;

namespace GoFPatternsCSharp.Singleton
{
    public class Janela: Form
    {
        private static Janela? _instancia = null;

        private Janela()
        {
            this.Size = new Size(640, 480);
            this.Text = "Janela Singleton";
        }

        public static Janela GetInstance()
        {
            if (_instancia == null)
            {
                _instancia = new Janela();
            }
            return _instancia;
        }
     
    }
}
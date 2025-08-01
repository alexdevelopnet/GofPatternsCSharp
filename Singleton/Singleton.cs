using System.Windows.Forms;

namespace GoFPatternsCSharp.Singleton
{
    public class Singleton
    {
        private static Singleton? instance;
        private static readonly object lockObject = new object();
 
        private Singleton()
        {
        }
 
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }

        
        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is working!");
        }
    }

   
    public class Program
    {
        [STAThread]
        static void Main()
        {
            // Exemplo de uso do Singleton Biblia
            Biblia biblia1 = Biblia.GetInstance();
            biblia1.LerVersiculo("João", 3, 16);

            Biblia biblia2 = Biblia.GetInstance();
            biblia2.LerVersiculo("Salmos", 23, 1);

            Console.WriteLine($"biblia1 e biblia2 são a mesma instância? {object.ReferenceEquals(biblia1, biblia2)}");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Janela j1 = Janela.GetInstance();
            j1.Show();

            Janela j2 = Janela.GetInstance();
            j2.Text = "Mesmo objeto: Singleton";
            j2.Show();

            Application.Run(j1);
        }
    }
}
using System.Windows.Forms;

namespace Draft_Diamond_BD
{
    internal static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
            //Application.Run(new Registration());
            //Application.Run(new CreatingShipment());
            //Application.Run(new SearchProducts());
            //Application.Run(new DatabaseProduct());
            //Application.Run(new DatabaseWorker());


        }
    }
}

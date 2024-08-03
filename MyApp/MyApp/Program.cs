namespace MyApp
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            // Runs only the form with DLL function
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
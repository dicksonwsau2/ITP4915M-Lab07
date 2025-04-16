namespace ITP4915M_Lab07
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 1. Initialize the application settings
            ApplicationConfiguration.Initialize();

            // 2. Show FormMain at application startup
            Application.Run(new FormMain());
        }
    }
}

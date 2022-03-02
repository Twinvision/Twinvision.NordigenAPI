namespace Twinvision.Nordigen.WinformsTest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.ThreadException += Application_ThreadException;
            Application.Run(new Main());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"{e.Exception.Message}\n\r\n\r{e.Exception.StackTrace}", "Unhandled exception",MessageBoxButtons.OK);
        }
    }
}
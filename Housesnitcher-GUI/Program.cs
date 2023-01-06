using Housesnitcher_GUI.GUI.Forms;

namespace Housesnitcher_GUI
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

            // put some dummy data here if you want to test out the app.


            Application.Run(new LoginForm());
        }
    }
}
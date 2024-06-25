using CENDI_admin.Forms_config;
using CENDI_admin.Properties;

namespace CENDI_admin
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
            
            if(Settings.Default.primerUso)
                Application.Run(new Form_configPrincipal());
            else
                Application.Run(new Form_login());

        }
    }
}
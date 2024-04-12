using Controller;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace view
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
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var build = new HostBuilder().ConfigureServices((hostContext, services) => { 
                services.AddSingleton<Login>();
                services.AddSingleton<dashBoard>();
                services.AddSingleton<LoginController>(); 
            });

            var host = build.Build(); 

            using (var serviceScope = host.Services.CreateScope()) {
                var login = serviceScope.ServiceProvider.GetService<Login>();
                Application.Run(login!);
            }


            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}
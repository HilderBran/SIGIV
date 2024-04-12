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
                services.AddSingleton<Form1>();
            });

            var host = build.Build(); 

            using (var serviceScope = host.Services.CreateScope()) {
                var form = serviceScope.ServiceProvider.GetService<Form1>();
                Application.Run(form);
            }


            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}
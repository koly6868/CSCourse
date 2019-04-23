using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Windows.Forms;

namespace CourseWorkClientServer
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            IConfiguration config = Configuration();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn(Configuration()));
        }

        static IConfigurationRoot Configuration()
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            string path = Application.StartupPath;
            path = path.Substring(0, path.IndexOf("bin"));
            return configurationBuilder
                .AddJsonFile(Path.Combine(path,"Configuration.json"))
                .Build();
           
        }
    }
}

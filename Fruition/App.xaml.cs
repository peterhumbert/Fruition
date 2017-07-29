using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Fruition
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow;
            if (e.Args.Length == 0 || e.Args[0] == null && e.Args[0].Equals(""))
                mainWindow = new MainWindow(null);
            else
                mainWindow = new MainWindow(e.Args[0]);
                
            MainWindow.Show();
        }
    }
}

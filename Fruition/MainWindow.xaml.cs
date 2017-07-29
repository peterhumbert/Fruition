using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace Fruition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private System.Timers.Timer clickTimer;
        private int clickCount = 0;

        public MainWindow()
        {
            clickTimer = new System.Timers.Timer(300);
            clickTimer.Elapsed += new System.Timers.ElapsedEventHandler(evalClicks);
            InitializeComponent();
            try
            {
                //button.Content = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData[0];
                
            }
            catch (Exception ex)
            {
                button.Content = "null";
            }
        }

        private void evalClicks(object sender, System.Timers.ElapsedEventArgs e)
        {
            clickTimer.Stop();
            if (clickCount > 1)
                System.Diagnostics.Process.Start("http://thefounder.biz");
            else
                System.Diagnostics.Process.Start("http://news.ycombinator.com");
            clickCount = 0;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            button.Content = "test";
        }

        private void yc_Click(object sender, RoutedEventArgs e)
        {
            clickCount++;
            clickTimer.Start();
        }

        private void slack_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://startup-umn.slack.com/");
        }

        private void trello_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://trello.com/");
        }

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            if (settingsFlyout.IsOpen)
                settingsFlyout.IsOpen = false;
            else
                settingsFlyout.IsOpen = true;
        }

        private void settingsSlackToggle_Click(object sender, RoutedEventArgs e)
        {
            if (settingsSlackToggle.IsChecked.Value)
                slack.Visibility = Visibility.Visible;
            else
                slack.Visibility = Visibility.Collapsed;
        }
    }
}

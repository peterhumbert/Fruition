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
using MahApps.Metro.Controls.Dialogs;

namespace Fruition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private System.Timers.Timer clickTimer;
        private int clickCount = 0;
        private string contextFile;
        private Context context;

        public MainWindow(string contextFile)
        {
            clickTimer = new System.Timers.Timer(300);
            clickTimer.Elapsed += new System.Timers.ElapsedEventHandler(evalClicks);
            InitializeComponent();
            this.contextFile = contextFile;
        }

        private async void showWelcome()
        {
            await this.ShowMessageAsync("Welcome to Fruition", 
                "By default, you have a Personal \"context\" for your personal projects. " +
                "You can create additional \"contexts\"" + (char)0x2014 + 
                "maybe for work, school, or open-source projects" + (char)0x2014 + 
                "in Settings.",
                MessageDialogStyle.Affirmative);
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

        private void yc_Click(object sender, RoutedEventArgs e)
        {
            clickCount++;
            clickTimer.Start();
        }

        private void slack_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://" + context.slack + ".slack.com/");
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
            {
                slack.Visibility = Visibility.Visible;
                context.hasSlack = true;
                context.slack = slackTextbox.Text;
                
            }
            else
            {
                slack.Visibility = Visibility.Collapsed;
                context.hasSlack = false;
                context.slack = null;
            }
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // serialize the current Context object
            
            Properties.Settings.Default.isFirstRun = false;
            Properties.Settings.Default.Save();
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (contextFile == null && Properties.Settings.Default.isFirstRun)
            {
                showWelcome();
                this.context = new Context("Personal");

                // load the Context into UI 
            }
            else
            {
                // deserialize the file to load the Context
                // load the Context into UI
            }
        }

        private void settingsTrelloToggle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void settingsFlyout_ClosingFinished(object sender, RoutedEventArgs e)
        {
            context.slack = slackTextbox.Text;
        }

        private void newContext_Click(object sender, RoutedEventArgs e)
        {
            // serialize current Context


        }

        private void addProject_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem lvi = (ListViewItem)list.Items.GetItemAt(1);
            //lvi.Style = "{StaticResource ResourceKey=one}";
            lvi.Style = (Style)Application.Current.Resources["green"];
        }
    }
}

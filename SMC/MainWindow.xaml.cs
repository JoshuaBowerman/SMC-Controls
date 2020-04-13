using Renci.SshNet;
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

namespace SMC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void command(string ip,string user,string command)
        {
            //BASS 192.168.0.8
            SshClient sshclient = new SshClient(ip, user, passwordBox.Password);
            try
            {
                sshclient.Connect();
                SshCommand sc = sshclient.CreateCommand(command);
                sc.Execute();
                LogBlock.Text = LogBlock.Text + sc.Result;
                sshclient.Disconnect();
            }
            catch (Exception ex)
            {
                LogBlock.Text = LogBlock.Text + ex.Message + "\n";
            }
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //BASS 192.168.0.8
            SshClient sshclient = new SshClient("192.168.0.8", "dietpi", passwordBox.Password);
            try
            {
                sshclient.Connect();
                SshCommand sc = sshclient.CreateCommand("reboot");
                sc.Execute();
                LogBlock.Text = LogBlock.Text + "\nSent Reboot Command";
                sshclient.Disconnect();
            }
            catch (Exception ex)
            {
                LogBlock.Text = LogBlock.Text + "\n" + ex.Message;
            }

        }

        private void Reb2_Click(object sender, RoutedEventArgs e)
        {
            //SMC01     192.168.0.9
            SshClient sshclient = new SshClient("192.168.0.9", "root", passwordBox.Password);
            try
            {
                sshclient.Connect();
                SshCommand sc = sshclient.CreateCommand("reboot");
                sc.Execute();
                LogBlock.Text = LogBlock.Text + "\nSent Reboot Command";
                sshclient.Disconnect();
            }
            catch (Exception ex)
            {
                LogBlock.Text = LogBlock.Text + "\n" + ex.Message;
            }

        }

        private void Reb3_Click(object sender, RoutedEventArgs e)
        {
            //SMC02     192.168.0.7
            SshClient sshclient = new SshClient("192.168.0.7", "root", passwordBox.Password);
            try
            {
                sshclient.Connect();
                SshCommand sc = sshclient.CreateCommand("reboot");
                sc.Execute();
                LogBlock.Text = LogBlock.Text + "\nSent Reboot Command";
                sshclient.Disconnect();
            }
            catch (Exception ex)
            {
                LogBlock.Text = LogBlock.Text + "\n" + ex.Message;
            }

        }

        private void Reb4_Click(object sender, RoutedEventArgs e)
        {
            //SMC01     192.168.0.6
            SshClient sshclient = new SshClient("192.168.0.6", "root", passwordBox.Password);
            try
            {
                sshclient.Connect();
                SshCommand sc = sshclient.CreateCommand("reboot");
                sc.Execute();
                LogBlock.Text = LogBlock.Text + "\nSent Reboot Command";
                sshclient.Disconnect();
            }
            catch (Exception ex)
            {
                LogBlock.Text = LogBlock.Text + "\n" + ex.Message;
            }

        }

        private void VPN_Click(object sender, RoutedEventArgs e)
        {
            command("192.168.0.8", "dietpi", "expressvpn connect");
        }

        private void Update1_Click(object sender, RoutedEventArgs e)
        {
            //BASS 192.168.0.8
            command("192.168.0.8", "dietpi", "sudo apt-get update && sudo apt-get upgrade&");
        }

        private void Update2_Click(object sender, RoutedEventArgs e)
        {
            command("192.168.0.9", "root", "kodi-send --action=UpdateAddonRepos && kodi-send --action=UpdateLocalAddons");
        }

        private void UpdateLibrary_Click(object sender, RoutedEventArgs e)
        {
            command("192.168.0.9", "root", "kodi-send --action=\"UpdateLibrary(video)\"");
            command("192.168.0.7", "root", "kodi-send --action=\"UpdateLibrary(video)\"");
            command("192.168.0.6", "root", "kodi-send --action=\"UpdateLibrary(video)\"");
        }

        private void On1_Click(object sender, RoutedEventArgs e)
        {
            command("192.168.0.9", "root", "kodi-send --action=CECActivateSource");
        }

        private void On2_Click(object sender, RoutedEventArgs e)
        {
            command("192.168.0.7", "root", "kodi-send --action=CECActivateSource");
        }

        private void On3_Click(object sender, RoutedEventArgs e)
        {
            command("192.168.0.6", "root", "kodi-send --action=CECActivateSource");
        }

        private void Off1_Click(object sender, RoutedEventArgs e)
        {
            command("192.168.0.9", "root", "kodi-send --action=CECStandby");
        }

        private void Off2_Click(object sender, RoutedEventArgs e)
        {
            command("192.168.0.7", "root", "kodi-send --action=CECStandby");
        }

        private void Off3_Click(object sender, RoutedEventArgs e)
        {
            command("192.168.0.6", "root", "kodi-send --action=CECStandby");
        }

        private void Send1_Click(object sender, RoutedEventArgs e)
        {
            command("192.168.0.9", "root", "kodi-send --action=\"Notification(Notification," + Message.Text + ")\"");
        }

        private void Send2_Click(object sender, RoutedEventArgs e)
        {
            command("192.168.0.7", "root", "kodi-send --action=\"Notification(Notification," + Message.Text + ")\"");
        }

        private void Send3_Click(object sender, RoutedEventArgs e)
        {
            command("192.168.0.6", "root", "kodi-send --action=\"Notification(Notification," + Message.Text + ")\"");
        }
    }
}

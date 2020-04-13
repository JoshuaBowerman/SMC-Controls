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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //BASS 192.168.0.8
            SshClient sshclient = new SshClient("192.168.0.8", "dietpi", passwordBox.Password);
            try
            {
                sshclient.Connect();
                SshCommand sc = sshclient.CreateCommand("sudo reboot");
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
                SshCommand sc = sshclient.CreateCommand("sudo reboot");
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
                SshCommand sc = sshclient.CreateCommand("sudo reboot");
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
                SshCommand sc = sshclient.CreateCommand("sudo reboot");
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
            //BASS 192.168.0.8
            SshClient sshclient = new SshClient("192.168.0.8", "dietpi", passwordBox.Password);
            try
            {
                sshclient.Connect();
                SshCommand sc = sshclient.CreateCommand("expressvpn connect");
                sc.Execute();
                LogBlock.Text = LogBlock.Text + "\n" + sc.Result;
                sshclient.Disconnect();
            }
            catch (Exception ex)
            {
                LogBlock.Text = LogBlock.Text + "\n" + ex.Message;
            }

        }

        private void Update1_Click(object sender, RoutedEventArgs e)
        {
            //BASS 192.168.0.8
            SshClient sshclient = new SshClient("192.168.0.8", "dietpi", passwordBox.Password);
            try
            {
                sshclient.Connect();
                SshCommand sc = sshclient.CreateCommand("sudo apt-get update && sudo apt-get upgrade&");
                sc.Execute();
                LogBlock.Text = LogBlock.Text + "\n" + sc.Result;
                sshclient.Disconnect();
            }
            catch (Exception ex)
            {
                LogBlock.Text = LogBlock.Text + "\n" + ex.Message;
            }

        }
    }
}

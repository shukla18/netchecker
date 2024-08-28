using System.Diagnostics;
using System.Net.NetworkInformation;
using static System.Net.WebRequestMethods;
namespace NetCheckerApp
{
    public partial class Form1 : Form
    {

        private string[] hosts;
        private int outageCount;
        public Form1() => InitializeComponent();

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (string host in hosts)
            {
                if (!string.IsNullOrWhiteSpace(host))
                {
                    Console.WriteLine("Checking host - " + host);

                    if (IsInteretConnected(host))
                    {
                        string message = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} \t CONN \t {host}";

                        if (chkSuccessLog.Checked)
                            WriteLog(message);
                    }
                    else
                    {
                        string message = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} \t DISC \t {host}";
                        outageCount++;
                        WriteLog(message);
                        lblOutageCount.Text = outageCount.ToString();
                    }
                }
            }
        }

        private string[] GetHosts()
        {
            hosts = txtHostToPing.Text.Split('\u002C');
            return hosts;
        }

        private static bool IsInteretConnected(string host)
        {
            try
            {
                Ping myPing = new Ping();
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        private void WriteLog(string message)
        {
            txtOutput.AppendText(message);
            txtOutput.AppendText(Environment.NewLine);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int interval = 5;
            int.TryParse(txtTimer.Text, out interval);
            timer1.Interval = interval * 1000;

            hosts = GetHosts();
            timer1.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            txtHostToPing.Enabled = false;
            txtTimer.Enabled = false;
            btnReset.Enabled = false;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            txtHostToPing.Enabled = true;
            txtTimer.Enabled = true;
            btnReset.Enabled = true;
        }

        private void txtTimer_TextChanged(object sender, EventArgs e)
        {
            int interval = 5;
            int.TryParse(txtTimer.Text, out interval);
            if (interval < 2 || interval > 300)
            {
                MessageBox.Show("The interval value should be between 2 seconds to 300 seconds (5 minutes).");
                txtTimer.Text = "5";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            lblOutageCount.Text = "Nil";
            outageCount = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link = "https://github.com/shukla18/netchecker";
            try
            {
                ProcessStartInfo psInfo = new ProcessStartInfo
                {
                    FileName = link,
                    UseShellExecute = true
                };

                Process.Start(psInfo);
            }
            catch { }
            finally
            {
                linkLabel1.Text = string.Empty;
                linkLabel1.Text = $"Please visit link manually {link}";
            }
        }
    }
}
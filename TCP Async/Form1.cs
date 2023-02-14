using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace TCP_Async
{
    public partial class Form1 : Form
    {
        TcpListener TcpListener;
        TcpClient TcpClient;
        int port = 12345;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                TcpListener = new TcpListener(IPAddress.Any, port);
                TcpListener.Start();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            btnStartServer.Enabled = false;
            StartaMottagning();
        }

        private async void StartaLäsning(TcpClient tcpClient)
        {
            byte[] buffer = new byte[1024];
            int n = 0;
            try
            {
                n = await tcpClient.GetStream().ReadAsync(buffer, 0, buffer.Length);
                StartaLäsning(tcpClient);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            rtbInkorg.AppendText(Encoding.UTF8.GetString(buffer) + Environment.NewLine);

        }

        private async void StartaMottagning()
        {
            try
            {
                TcpClient = await TcpListener.AcceptTcpClientAsync();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            StartaLäsning(TcpClient);
        }
    }
}

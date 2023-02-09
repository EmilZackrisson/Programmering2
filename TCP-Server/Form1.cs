using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        int port = 12345;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            lyssnare = new TcpListener(IPAddress.Any, port);
            lyssnare.Start();

            btnStartServer.Enabled = false;
            StartaMottagning();
        }



        public async void StartaMottagning()
        {
            try
            {
                klient = await lyssnare.AcceptTcpClientAsync();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            StartaLäsning(klient);
        }

        public async void StartaLäsning(TcpClient klient)
        {
            byte[] buffert = new byte[1024];
            int n = 0;

            try
            {
                n = await klient.GetStream().ReadAsync(buffert, 0, buffert.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            rtbInkorg.AppendText(Encoding.UTF8.GetString(buffert, 0, n));
            StartaLäsning(klient);
        }
    }
}

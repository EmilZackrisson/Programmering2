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

namespace TCP
{
    public partial class Form1 : Form
    {
        TcpClient klient = new TcpClient();
        int port = 12345;
        public Form1()
        {
            InitializeComponent();
            klient.NoDelay = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            StartaSändning(rtbMessage.Text);

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!klient.Connected) StartaAnslutning();

        }

        public async void StartaAnslutning()
        {
            try
            {
                IPAddress address = IPAddress.Parse(tbxIp.Text);
                await klient.ConnectAsync(address, port);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            btnConnect.Enabled = false;
            btnSend.Enabled = true;
        }

        public async void StartaSändning(string message)
        {
            byte[] utData = Encoding.UTF8.GetBytes(message);
            try
            {
                await klient.GetStream().WriteAsync(utData, 0, utData.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                throw;
            }
        }
    }
}

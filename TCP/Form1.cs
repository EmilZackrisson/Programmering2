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
        TcpClient klient;
        int port = 12345;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string text = rtbMessage.Text;
            IPAddress address = IPAddress.Parse(tbxIp.Text);
            klient = new TcpClient();
            klient.NoDelay = true;
            klient.Connect(address, port);

            if (klient.Connected)
            {
                byte[] utData = Encoding.UTF8.GetBytes(text);
                klient.GetStream().Write(utData, 0, utData.Length);
                klient.Close();
            }
        }
    }
}

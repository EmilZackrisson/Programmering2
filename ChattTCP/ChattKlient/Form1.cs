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

namespace ChattKlient
{
    public partial class Form1 : Form
    {
        TcpClient client = new TcpClient();
        NetworkStream stream;
        int port = 12345;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDisconnect.Enabled = false;
            btnSend.Enabled = false;
            btnConnect.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            StartaSändning("[" + tbxUsername.Text + "] " + tbxMessage.Text);
            byte[] buffer = new byte[1024];
            int message = stream.Read(buffer, 0, buffer.Length);
            string inData = Encoding.UTF8.GetString(buffer, 0, message);
            listBox1.Items.Add(inData);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            panel1.BackColor = Color.Red;
            tbxIp.Enabled = true;
            client.Close();
            client.Dispose();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!client.Connected)
            {
                StartaAnslutning();
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                tbxIp.Enabled = false;
                panel1.BackColor = Color.Green;
            }
        }

        public async void StartaAnslutning()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxIp.Text);
                await client.ConnectAsync(adress, port);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            stream = client.GetStream();
        }

        public async void StartaSändning(string message)
        {
            byte[] utdata = Encoding.UTF8.GetBytes(message);
            try
            {
                await client.GetStream().WriteAsync(utdata, 0, utdata.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void btnApplyUsername_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text != "")
            {
                tbxMessage.Enabled = true;
                btnSend.Enabled = true;
                btnApplyUsername.Enabled = false;
                tbxUsername.Enabled = false;
            }

        }
    }
}

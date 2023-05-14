using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChattServer
{
    public partial class Form1 : Form
    {
        TcpListener listener;
        TcpClient client;
        NetworkStream stream;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Any, 12345);
            listener.Start();
            Thread thread = new Thread(() => StartaMottagning());
            thread.Start();
        }

        private async void StartaMottagning()
        {
            try
            {
                client = await listener.AcceptTcpClientAsync();
                stream = client.GetStream();
                Thread thread = new Thread(() => StartaLäsning(client));
                thread.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private async void StartaLäsning(TcpClient client)
        {
            byte[] inData = new byte[1024];



            string x = DateTime.Now.ToString() + Encoding.UTF8.GetString(inData, 0, inData.Length);
            listBox1.Items.Add(x);
            byte[] data = Encoding.UTF8.GetBytes(x);
            await client.GetStream().WriteAsync(data, 0, data.Length);
            StartaLäsning(client);
        }
    }
}

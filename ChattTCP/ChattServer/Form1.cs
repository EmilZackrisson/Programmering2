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
        List<TcpClient> clients = new List<TcpClient>();
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
                while (true)
                {
                    TcpClient client = await listener.AcceptTcpClientAsync();

                    clients.Add(client);

                    Invoke(new Action(() =>
                    {
                        listBox1.Items.Add("Client connected from: " + ((IPEndPoint)client.Client.RemoteEndPoint).Address);
                    }));

                    Thread thread = new Thread(() => StartaLäsning(client));
                    thread.Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private async void StartaLäsning(TcpClient client)
        {
            try
            {
                byte[] inData = new byte[1024];

                await client.GetStream().ReadAsync(inData, 0, inData.Length);

                string x = DateTime.Now.ToString() + Encoding.UTF8.GetString(inData, 0, inData.Length).Trim();
                Invoke(new Action(() =>
                {
                    listBox1.Items.Add(x);
                    listBox1.Update();
                }));
                byte[] data = Encoding.UTF8.GetBytes(x);
                foreach (TcpClient tcpClient in clients)
                {
                    await tcpClient.GetStream().WriteAsync(data, 0, data.Length);
                }
                StartaLäsning(client);
            }
            catch
            {
                Invoke(new Action(() =>
                {
                    listBox1.Items.Add("Client disconnected from: " + ((IPEndPoint)client.Client.RemoteEndPoint).Address);
                }));
            }
        }
    }
}

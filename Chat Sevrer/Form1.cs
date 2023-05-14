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

namespace Chat_Sevrer
{
    public partial class Form1 : Form
    {
        List<TcpClient> clientsList = new List<TcpClient>();
        TcpListener listener = new TcpListener(IPAddress.Any, 5000);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread startServer = new Thread(StartServer);
            startServer.Start();
            listBox1.Items.Add("Server started");
        }

        private async void StartServer()
        {
            listener.Start();

            while (true)
            {

                TcpClient newClient = await listener.AcceptTcpClientAsync();
                clientsList.Add(newClient);
                listBox1.BeginInvoke(new Action(() =>
                {
                    while (newClient.Connected)
                    {

                        listBox1.Items.Add("Waiting for new client...");

                    }

                }));
                Thread handleThread = new Thread(() => HandleClient(newClient));
                handleThread.Start();
            }
        }

        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int byte_count;
            while ((byte_count = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string data = Encoding.ASCII.GetString(buffer, 0, byte_count);
                Broadcast(data);
            }
        }

        private void Broadcast(string data)
        {
            listBox1.Items.Add(data);
            foreach (TcpClient client in clientsList)
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = Encoding.ASCII.GetBytes(data + Environment.NewLine);
                stream.Write(buffer, 0, buffer.Length);

                if (client.Connected == false)
                {
                    clientsList.Remove(client);
                }
            }
        }
    }
}

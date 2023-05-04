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

namespace Chat_Sevrer
{
    public partial class Form1 : Form
    {
        static List<TcpClient> clients = new List<TcpClient>();
        static TcpListener server = new TcpListener(IPAddress.Any, 8080);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Main();
        }

        private async Task Main()
        {
            server.Start();
            listBox1.Items.Add("Server started...");

            while (true)
            {
                TcpClient client = await server.AcceptTcpClientAsync();
                clients.Add(client);
                listBox1.Items.Add("Client connected!");


                Task.Run(() => HandleClient(client));
            }
        }

        private async Task HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();

            byte[] buffer = new byte[1024];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            string username = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            while (true)
            {
                bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                listBox1.Items.Add(username + ": " + message);


                if (message == "exit")
                    break;

                foreach (TcpClient c in clients)
                {
                    if (c != client)
                    {
                        buffer = Encoding.ASCII.GetBytes(username + ": " + message);
                        await c.GetStream().WriteAsync(buffer, 0, buffer.Length);
                    }
                }
            }

            clients.Remove(client);
            client.Close();
            listBox1.Items.Add("Client disconnected.");

        }
    }
}

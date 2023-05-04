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

namespace Chat_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkicka_Click(object sender, EventArgs e)
        {
            string message = tbxMeddelande.Text.Trim();


            tbxMeddelande.Clear();
        }

        private void btnAnslut_Click(object sender, EventArgs e)
        {
            btnAnslut.Enabled = false;

            Main();

            btnLämna.Enabled = true;
            btnSkicka.Enabled = true;
        }

        private void btnLämna_Click(object sender, EventArgs e)
        {
            btnAnslut.Enabled = true;
            btnLämna.Enabled = false;
        }

        private async Task Main()
        {
            TcpClient client = new TcpClient();
            await client.ConnectAsync("localhost", 8080);
            listBox1.Items.Add("Connected to server...");

            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            byte[] buffer = Encoding.ASCII.GetBytes(username);
            await client.GetStream().WriteAsync(buffer, 0, buffer.Length);

            Task.Run(() => ReceiveMessages(client));

            while (true)
            {
                string message = Console.ReadLine();
                buffer = Encoding.ASCII.GetBytes(message);
                await client.GetStream().WriteAsync(buffer, 0, buffer.Length);

                if (message == "exit")
                    break;
            }

            client.Close();
            listBox1.Items.Add("Disconnected from server...");
        }

        private async Task ReceiveMessages(TcpClient client)
        {
            byte[] buffer = new byte[1024];

            while (true)
            {
                int bytesRead = await client.GetStream().ReadAsync(buffer, 0, buffer.Length);
                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                listBox1.Items.Add(message);
            }
        }
    }
}

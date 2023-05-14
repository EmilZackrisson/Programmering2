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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Chat_Client
{
    public partial class Form1 : Form
    {
        private bool send;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkicka_Click(object sender, EventArgs e)
        {
            send = true;
            tbxMeddelande.Clear();

        }

        private void btnAnslut_Click(object sender, EventArgs e)
        {

            Main();


        }

        private void btnLämna_Click(object sender, EventArgs e)
        {
            btnAnslut.Enabled = true;
            btnLämna.Enabled = false;
            pnStatus.BackColor = Color.Red;


        }

        private async Task Main()
        {
            TcpClient client = new TcpClient();
            await client.ConnectAsync("localhost", 5000);
            listBox1.Items.Add("Connected to server...");
            btnLämna.Enabled = true;
            btnSkicka.Enabled = true;
            pnStatus.BackColor = Color.Green;

            /*
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            await client.GetStream().WriteAsync(buffer, 0, buffer.Length);
            */


            Thread thread2 = new Thread(() => ReceiveMessages(client));
            thread2.Start();



            while (client.Connected)
            {
                if (send)
                {
                    Thread thread = new Thread(() => SendMessage(client, tbxMeddelande.Text));
                    thread.Start();
                }
            }


        }

        private async void SendMessage(TcpClient client, string message)
        {

            byte[] buffer = Encoding.ASCII.GetBytes(message);
            await client.GetStream().WriteAsync(buffer, 0, buffer.Length);

            send = false;
        }

        private async Task ReceiveMessages(TcpClient client)
        {
            byte[] buffer = new byte[1024];

            while (client.Connected)
            {
                int bytesRead = await client.GetStream().ReadAsync(buffer, 0, buffer.Length);
                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                listBox1.Items.Add(message);
            }
        }
    }
}

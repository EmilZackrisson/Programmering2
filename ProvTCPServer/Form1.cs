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

namespace ProvTCPServer
{
    public partial class Form1 : Form
    {
        TcpListener listener;
        readonly List<TcpClient> clients = new List<TcpClient>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            btnStartServer.Enabled = false;
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

                string data = Encoding.UTF8.GetString(inData);

                string[] strings = data.Split('|');

                foreach (string s in strings)
                {
                    s.Replace("\0", string.Empty);
                    s.Trim();
                }

                if (strings[0] == "event:enter")
                {
                    int col = int.Parse(strings[1].Split(':')[1]);
                    int row = int.Parse(strings[2].Split(':')[1]);
                    string text = strings[3].Split(':')[1];

                    Invoke(new Action(() =>
                    {
                        if (dataGridView1.Rows.Count - 1 <= row)
                            dataGridView1.Rows.Add();

                        dataGridView1.Rows[row].Cells[col].Value = text.Replace("\0", string.Empty);

                    }));
                }

                if (strings[0] == "event:click")
                {
                    int col = int.Parse(strings[1].Split(':')[1]);
                    int row = int.Parse(strings[2].Split(':')[1]);

                    Invoke(new Action(() =>
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[row].Cells[col];
                    }));
                }

                if (strings[0] == "event:rowAdded")
                {
                    Invoke(new Action(() =>
                    {
                        dataGridView1.Rows.Add();
                    }));
                }

                byte[] message = Encoding.UTF8.GetBytes(data);
                foreach (TcpClient tcpClient in clients)
                {
                    await tcpClient.GetStream().WriteAsync(message, 0, message.Length);
                }


                if (client.Connected)
                    StartaLäsning(client);
            }
            catch { }
        }
    }
}

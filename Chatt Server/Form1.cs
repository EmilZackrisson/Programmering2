using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatt_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            startListening();
        }

        private async void startListening()
        {
            var ipEndPoint = new IPEndPoint(IPAddress.Any, 13);
            TcpListener listener = new TcpListener(ipEndPoint);

            try
            {
                listener.Start();

                TcpClient handler = await listener.AcceptTcpClientAsync();
                NetworkStream stream = handler.GetStream();

                var message = $"📅 {DateTime.Now} 🕛";
                var dateTimeBytes = Encoding.UTF8.GetBytes(message);
                await stream.WriteAsync(dateTimeBytes, 0, dateTimeBytes.Length);

                listBox1.Items.Add($"Sent message: \"{message}\"");

                // Sample output:
                //     Sent message: "📅 8/22/2022 9:07:17 AM 🕛"
            }
            finally
            {
                listener.Stop();
            }
        }
    }
}

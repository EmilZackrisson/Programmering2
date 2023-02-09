using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Nätverk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.UTF8.GetBytes(rtbMessage.Text);

            IPAddress serverIp = IPAddress.Parse(tbxServerIp.Text);
            IPEndPoint destination = new IPEndPoint(serverIp, Convert.ToInt32(tbxPort.Text));

            UdpClient udpClient = new UdpClient();
            udpClient.Send(message, message.Length, destination);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace UDP_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTagEmot_Click(object sender, EventArgs e)
        {
            IPEndPoint klientEndPoint = new IPEndPoint(IPAddress.Any, 0);
            UdpClient client = new UdpClient(Convert.ToInt32(tbxPort.Text));
            byte[] inström = client.Receive(ref klientEndPoint);
            rtbReccived.Text = Encoding.UTF8.GetString(inström);
        }
    }
}

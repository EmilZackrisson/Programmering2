using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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



        private void button1_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient();
            client.Connect("127.0.0.1", 5000);
            NetworkStream ns = client.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes(textBox1.Text);
            ns.Write(buffer, 0, buffer.Length);
            ns.Flush();
            byte[] receivedBytes = new byte[1024];
            int byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length);
            listBox1.Items.Add(Encoding.UTF8.GetString(receivedBytes, 0, byte_count));
            ns.Close();
            client.Close();

        }
    }
}

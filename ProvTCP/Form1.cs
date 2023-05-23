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

namespace ProvTCP
{
    public partial class Form1 : Form
    {
        TcpClient client = new TcpClient();
        NetworkStream stream;
        int port = 12345;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private async void Connect()
        {
            try
            {
                IPAddress adress = IPAddress.Parse("127.0.0.1");
                await client.ConnectAsync(adress, port);
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Kunde inte ansluta. \n {ex.Message}");
            }
            stream = client.GetStream();

            btnConnect.Enabled = false;

            Thread readStream = new Thread(() => ReadStream(stream));
            readStream.Start();
        }

        private async void Send(string message)
        {
            byte[] utdata = Encoding.UTF8.GetBytes(message);
            try
            {
                await client.GetStream().WriteAsync(utdata, 0, utdata.Length);
            }
            catch (Exception e)
            {
                ShowErrorMessage(e.Message);
            }
        }

        public async void ReadStream(NetworkStream stream)
        {
            try
            {
                while (true)
                {
                    byte[] bytes = new byte[1024];
                    await stream.ReadAsync(bytes, 0, bytes.Length);

                    string data = Encoding.UTF8.GetString(bytes);



                }
            }
            catch (Exception e)
            {
                ShowErrorMessage(e.Message);
            }
        }

        public void ShowErrorMessage(string error)
        {
            MessageBox.Show($"Error: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int colIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            StringBuilder sb = new StringBuilder();
            sb.Append("event:click");
            sb.Append("|col:" + colIndex);
            sb.Append("|row:" + rowIndex);
            string data = sb.ToString();
            Send(data);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int colIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            string cellText = dataGridView1.Rows[rowIndex].Cells[colIndex].Value.ToString();

            StringBuilder sb = new StringBuilder();
            sb.Append("event:enter");
            sb.Append("|col:" + colIndex);
            sb.Append("|row:" + rowIndex);
            sb.Append("|text:" + cellText);

            string data = sb.ToString();

            Send(data);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            string data = "event:rowAdded";
            Send(data);
        }
    }
}

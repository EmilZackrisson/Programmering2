using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChattKlient
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

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDisconnect.Enabled = false;
            btnSend.Enabled = false;
            btnConnect.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            StartaSändning("[" + tbxUsername.Text + "] " + tbxMessage.Text);
            byte[] buffer = new byte[1024];
            //int message = stream.Read(buffer, 0, buffer.Length);
            //string inData = Encoding.UTF8.GetString(buffer, 0, message);
            //listBox1.Items.Add(inData);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            panel1.BackColor = Color.Red;
            tbxIp.Enabled = true;
            client.Close();
            client.Dispose();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!client.Connected)
            {
                StartaAnslutning();
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                tbxIp.Enabled = false;
                panel1.BackColor = Color.Green;
            }
        }

        public async void StartaAnslutning()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxIp.Text);
                await client.ConnectAsync(adress, port);
            }
            catch
            {
            }
            stream = client.GetStream();
            Thread readStream = new Thread(() => ReadStream(stream));
            readStream.Start();
        }

        public async void StartaSändning(string message)
        {
            byte[] utdata = Encoding.UTF8.GetBytes(message);
            try
            {
                await client.GetStream().WriteAsync(utdata, 0, utdata.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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

                    Byte[] fourBytes = new Byte[] { bytes[0], bytes[1], bytes[2], bytes[3] };

                    if (Encoding.UTF8.GetString(fourBytes) == "file")
                    {
                        BytesToFile(bytes);
                    }
                    else
                    {
                        string text = Encoding.UTF8.GetString(bytes);

                        Invoke(new Action(() =>
                        {
                            listBox1.Items.Add(text.Trim());
                        }));
                    }


                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnApplyUsername_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text != "")
            {
                tbxMessage.Enabled = true;
                btnSend.Enabled = true;
                btnApplyUsername.Enabled = false;
                tbxUsername.Enabled = false;
            }

        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "All files (*.*)|*.*";
            string filePath = openFileDialog1.FileName;
            string safeFileName = openFileDialog1.SafeFileName;
            byte[] file = File.ReadAllBytes(filePath);
            SendFile(file, safeFileName);
        }

        public async void SendFile(byte[] file, string safeFileName)
        {
            try
            {
                file = AddByteToArray(file, safeFileName);
                await client.GetStream().WriteAsync(file, 0, file.Length);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public byte[] AddByteToArray(byte[] bArray, string safeFileName)
        {

            byte[] fileName = Encoding.UTF8.GetBytes(safeFileName);

            byte[] newArray = new byte[bArray.Length + 4 + fileName.Length + 2];
            bArray.CopyTo(newArray, 4 + fileName.Length);

            byte[] text = Encoding.UTF8.GetBytes("file");

            newArray[0] = text[0];
            newArray[1] = text[1];
            newArray[2] = text[2];
            newArray[3] = text[3];

            int i;

            for (i = 0; i < fileName.Length; i++)
            {
                newArray[i + 4] = fileName[i];
            }

            newArray[i + 1] = 0;
            newArray[i + 2] = 0;

            return newArray;
        }

        public void BytesToFile(byte[] fileBytes)
        {
            string firstFourBytes = Encoding.UTF8.GetString(fileBytes, 0, 4);
            if (firstFourBytes != "file") return;



            int x = 0;
            int fileByteLength = 0;
            for (int i = 4; i < fileBytes.Length; i++)
            {
                if (fileBytes[i] == 0) x++;
                if (x == 2)
                {
                    break;
                }
                else fileByteLength++;
            }

            byte[] fileNameBytes = new byte[fileByteLength];
            Array.Copy(fileBytes, 4, fileNameBytes, 0, fileByteLength);
            string filename = Encoding.UTF8.GetString(fileNameBytes);

            saveFileDialog1.FileName = filename;
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                byte[] file = new byte[fileBytes.Length - 4 - fileByteLength];
                File.WriteAllBytes(saveFileDialog1.FileName, file);
            }

        }
    }
}

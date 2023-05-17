using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            client.Close();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            panel1.BackColor = Color.Red;
            tbxIp.Enabled = true;

            DialogResult dialogResult = MessageBox.Show("Close program? If no, the program will not work anymore.", "Close program?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes) Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            StartaAnslutning();
        }

        public async void StartaAnslutning()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxIp.Text);
                await client.ConnectAsync(adress, port);
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Kunde inte ansluta. \n {ex.Message}");
            }
            stream = client.GetStream();

            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            tbxIp.Enabled = false;
            panel1.BackColor = Color.Green;

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

                    if (data.Split('|')[0] == "FILE")
                    {
                        Invoke(new Action(() =>
                        {
                            listBox1.Items.Add("FILE INCOMMING");
                        }));
                        BytesToFile(bytes);
                    }
                    else
                    {
                        Invoke(new Action(() =>
                        {
                            listBox1.Items.Add(data.Trim());
                        }));
                    }
                }
            }
            catch (ObjectDisposedException e)
            {
                Console.WriteLine("Caught: {0}", e.Message);
            }
            catch (Exception e)
            {
                ShowErrorMessage(e.Message);
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
            openFileDialog1.Filter = "All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK) SendFile(openFileDialog1);
        }

        public async void SendFile(OpenFileDialog dialog)
        {
            try
            {
                string filename = dialog.FileName;
                string safeFilename = dialog.SafeFileName;

                //byte[] fileInBytes = File.ReadAllBytes(filename);

                byte[] result;

                using (FileStream SourceStream = File.Open(filename, FileMode.Open))
                {
                    result = new byte[SourceStream.Length];
                    await SourceStream.ReadAsync(result, 0, (int)SourceStream.Length);
                }

                    string fileInBase64 = Convert.ToBase64String(result);

                    string output = "FILE|" + safeFilename + "|" + fileInBase64;

                    byte[] data = Encoding.UTF8.GetBytes(output);

                    await client.GetStream().WriteAsync(data, 0, data.Length);

                    listBox1.Items.Add("Klart");
                

                

            }
            catch (Exception e)
            {
                ShowErrorMessage(e.Message);
            }
        }

        public void BytesToFile(byte[] bytes)
        {
            try
            {
                string decodedText = Encoding.UTF8.GetString(bytes);

                string filename = decodedText.Split('|')[1];
                string base64EncodedFile = decodedText.Split('|')[2].Replace("\0", String.Empty);

                byte[] fileInBytes = Convert.FromBase64String(base64EncodedFile);

                saveFileDialog1.FileName = filename;
                saveFileDialog1.DefaultExt = filename.Split('.').Last();

                Invoke(new Action(async () =>
                {
                    DialogResult result = saveFileDialog1.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        //File.Create(filename).Dispose();
                        //File.WriteAllBytes(saveFileDialog1.FileName, fileInBytes);


                        try
                        {
                            using (FileStream SourceStream = File.Open(saveFileDialog1.FileName, FileMode.OpenOrCreate))
                            {
                                if (!SourceStream.CanWrite)
                                {
                                    ShowErrorMessage("Kan inte skriva filen");
                                    return;
                                }
                                SourceStream.Seek(0, SeekOrigin.End);
                                await SourceStream.WriteAsync(fileInBytes, 0, fileInBytes.Length);
                            }
                        }
                        catch (Exception ex)
                        {
                            ShowErrorMessage(ex.Message);
                        }
                    }
                }));                
            }
            catch (Exception e)
            {
                ShowErrorMessage(e.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ShowErrorMessage(string error)
        {
            MessageBox.Show($"Error: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

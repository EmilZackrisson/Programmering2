using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        //TcpListener TcpListener;
        TcpClient klient;
        Player playerRight;
        Player playerLeft;


        // int port = 34512;
        int serverPort = 34512;
        bool gameRunning = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            //startaServer();
            AnslutTillServer();
        }
        /*
        private void startaServer()
        {
            try
            {
                TcpListener = new TcpListener(IPAddress.Any, klientPort);
                TcpListener.Start();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            gbxMenu.Enabled = false;
            gbxMenu.Visible = false;
            StartaMottagning();
        }*/

        private async void AnslutTillServer()
        {
            try
            {
                IPAddress address = IPAddress.Parse(tbxIp.Text);
                lblUppeVänster.Text = "Försöker ansluta till: " + address.ToString();
                klient = new TcpClient();
                klient.ReceiveTimeout = 100;
                await klient.ConnectAsync(address, serverPort);
                if (klient.Connected)
                {
                    Send("redo");
                    MessageBox.Show("Ansluten!");
                    gbxMenu.Enabled = false;
                    gbxMenu.Visible = false;
                    lblUppeVänster.Text = "Ansluten till: " + address.ToString();
                    gameRunning = true;
                    timer1.Start();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        /*
        public async void StartaMottagning()
        {
            try
            {
                klient = await TcpListener.AcceptTcpClientAsync();
                MessageBox.Show("Motståndare ansluten!");

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            StartaLäsning(klient);
        }*/

        public async void StartaLäsning(TcpClient klient)
        {
            byte[] buffer = new byte[1024];
            try
            {
                int n = await klient.GetStream().ReadAsync(buffer, 0, buffer.Length);
                StartaLäsning(klient);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            string message = Encoding.UTF8.GetString(buffer);
            lblUppeVänster.Text = message;


            StartaLäsning(klient);
        }

        public async void Send(string message)
        {
            byte[] utData = Encoding.UTF8.GetBytes(message);
            try
            {
                await klient.GetStream().WriteAsync(utData, 0, utData.Length);
                NetworkStream stream = klient.GetStream();
                //await using NetworkStream stream = klient.GetStream();

                // Väntar svar från server med information om måståndare och boll
                var buffer = new byte[1_024];
                int response = await klient.GetStream().ReadAsync(buffer, 0, buffer.Length);
                string responseText = Encoding.UTF8.GetString(buffer, 0, response);
                if (responseText.Contains("Left"))
                {
                    MessageBox.Show("Fick vänster spelare");
                    playerLeft.SetPlayer(responseText);
                    motståndare.Location = playerLeft.Location;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            Point point = spelare.Location;
            Size formSize = Size;

            lblKord.Text = point.X.ToString() + ", " + point.Y.ToString();


            if (e.KeyCode == Keys.Up)
            {
                point.Y = point.Y - 10;

                if (point.Y <= 0) return;

                spelare.Location = point;
                await Task.Delay(100);
            }
            if (e.KeyCode == Keys.Down)
            {
                point.Y = point.Y + 10;

                if (point.Y + 50 >= formSize.Height) return;


                spelare.Location = point;
                await Task.Delay(100);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                klient.Close();
                klient.Dispose();
            }
            catch { }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playerRight = new Player(spelare.Location, "Right");
            playerLeft = new Player(motståndare.Location, "Left");
        }

        private async void ReadFromServer()
        {
            byte[] buffer = new byte[1024];
            await klient.GetStream().ReadAsync(buffer, 0, buffer.Length);
            string message = Encoding.UTF8.GetString(buffer);
            lblUppeVänster.Text = message;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (klient.Connected && gameRunning)
            {
                playerRight.Location = spelare.Location;
                Send(playerRight.ToString());

                ReadFromServer();
            }
            else
            {
                lblUppeVänster.Text = "Running: " + gameRunning + " Connected: " + klient.Connected;
            }
        }
    }
}

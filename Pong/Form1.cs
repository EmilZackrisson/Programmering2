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
        TcpListener TcpListener;
        TcpClient klient;
        int port = 34512;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            startaServer();
            anslutTillServer();
        }

        private void startaServer()
        {
            try
            {
                TcpListener = new TcpListener(IPAddress.Any, port);
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
        }

        private async void anslutTillServer()
        {
            try
            {
                IPAddress address = IPAddress.Parse(tbxIp.Text);
                lblUppeVänster.Text = "Försöker ansluta till: " + address.ToString();
                await klient.ConnectAsync(address, port);
                if (klient.Connected)
                {
                    send("redo");
                    MessageBox.Show("Ansluten!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


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
        }

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

        public async void send(string message)
        {
            byte[] utData = Encoding.UTF8.GetBytes(message);
            try
            {
                await klient.GetStream().WriteAsync(utData, 0, utData.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void startGame()
        {
            sendLocation();
        }

        private async void sendLocation()
        {
            while (klient.Connected)
            {
                Point point = spelare.Location;
                send(point.ToString());
                await Task.Delay(100);
            }
            MessageBox.Show("Not sending");
        }


        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            Point point = spelare.Location;
            Size formSize = Size;

            lblKord.Text = point.X.ToString() + ", " + point.Y.ToString();


            if (e.KeyCode == Keys.Up)
            {
                point.Y = point.Y - 20;

                if(point.Y <= 0) return;

                spelare.Location = point;
                await Task.Delay(100);
            }
            if (e.KeyCode == Keys.Down)
            {
                point.Y = point.Y + 20;

                if (point.Y + 70 >= formSize.Height) return;
                

                spelare.Location = point;
                await Task.Delay(100);
            }
        }
    }
}

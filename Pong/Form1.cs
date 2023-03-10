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
        Ball Ball;

        bool leftConnected = false;

        // int port = 34512;
        int serverPort = 34513;
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
                    Send("högerRedo");
                    MessageBox.Show("Ansluten!");
                    gbxMenu.Enabled = false;
                    gbxMenu.Visible = false;
                    lblUppeVänster.Text = "Ansluten till: " + address.ToString();
                    gameRunning = true;

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public async void Send(string message)
        {
            byte[] utData = Encoding.UTF8.GetBytes(message);
            try
            {
                await klient.GetStream().WriteAsync(utData, 0, utData.Length);
                NetworkStream stream = klient.GetStream();
                //await using NetworkStream stream = klient.GetStream();

                // Väntar svar från server med information om måståndare
                var buffer = new byte[1_024];
                int response = await klient.GetStream().ReadAsync(buffer, 0, buffer.Length);
                string responseText = Encoding.UTF8.GetString(buffer, 0, response);
                if (responseText.Contains("Left"))
                {
                    playerLeft.SetPlayer(responseText);
                    motståndare.Location = playerLeft.Location;
                    leftConnected = true;
                    timer1.Start();
                }
                if (responseText.Contains("balldir"))
                {
                    Ball = new Ball(responseText);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (klient.Connected && gameRunning)
            {
                playerRight.Location = spelare.Location;
                Send(playerRight.ToString());

                Point ball = boll.Location;
                ball.X += Ball.vX;
                ball.Y += Ball.vY;
                boll.Location = ball;

                if (boll.Bounds.IntersectsWith(pnRight.Bounds))
                {
                    Ball.vX = -3;
                }
                if (boll.Bounds.IntersectsWith(pnLeft.Bounds))
                {
                    Ball.vX = 3;
                }
                if (boll.Bounds.IntersectsWith(pnTop.Bounds)) // Slår i taket
                {
                    Ball.vY = 3;
                }
                if (boll.Bounds.IntersectsWith(pnBottom.Bounds)) // Slår i golvet
                {
                    Ball.vY = -3;
                }

                // Kolla om boll utanför
                if (ball.X < 0)
                {
                    playerRight.AddPoint();
                    lblPointRight.Text = playerRight.Point.ToString();
                }
                if (ball.X > 816)
                {
                    playerLeft.AddPoint();
                    lblLeftPoint.Text = playerLeft.Point.ToString();
                }
            }
            else
            {
                lblUppeVänster.Text = "Running: " + gameRunning + " Connected: " + klient.Connected;
            }
        }


    }
}

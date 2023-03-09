using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        int port = 34512;

        int vX = 1;
        int vY = 1;

        Point ballStart;
        Point playerRightStart;
        Point playerLeftStart;

        Player playerRight;
        Player playerLeft;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            lyssnare = new TcpListener(IPAddress.Any, port);
            lyssnare.Start();

            btnStartServer.Enabled = false;
            StartaMottagning();
        }

        public async void StartaMottagning()
        {
            try
            {
                klient = await lyssnare.AcceptTcpClientAsync();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            StartaLäsning(klient);
        }

        public async void StartaLäsning(TcpClient klient)
        {
            byte[] buffert = new byte[1024];

            try
            {
                await klient.GetStream().ReadAsync(buffert, 0, buffert.Length);
                string text = Encoding.UTF8.GetString(buffert);
                Log(text);

                if (text.Contains("Left"))
                {
                    playerLeft.SetPlayer(text);
                    pnLeft.Location = playerLeft.Location;
                }
                if (text.Contains("Right"))
                {
                    playerRight.SetPlayer(text);
                    pnRight.Location = playerRight.Location;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                Log(error.ToString());
            }

            StartaLäsning(klient);
        }

        public async void send(string message, TcpClient klient)
        {
            byte[] utData = Encoding.UTF8.GetBytes(message);
            await klient.GetStream().WriteAsync(utData, 0, utData.Length);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            klient.Close();
            klient.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playerRight = new Player(pnRight.Location, "Right");
            playerLeft = new Player(pnLeft.Location, "Left");
            timer1.Start();

            playerRightStart = playerRight.Location;
            playerLeftStart = playerLeft.Location;
            ballStart = pnBall.Location;

        }

        private void resetPositions()
        {
            pnBall.Location = ballStart;
            playerLeft.Location = playerLeftStart;
            playerRight.Location = playerRightStart;
        }

        private void Log(string message)
        {
            rtbInkorg.Text += message + Environment.NewLine;
            rtbInkorg.SelectionStart = rtbInkorg.Text.Length;
            rtbInkorg.ScrollToCaret();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Point ball = pnBall.Location;
            ball.X += vX;
            ball.Y += vY;
            pnBall.Location = ball;

            if (pnBall.Bounds.IntersectsWith(pnRight.Bounds))
            {
                vX = -1;
            }
            if (pnBall.Bounds.IntersectsWith(pnLeft.Bounds))
            {
                vX = 1;
            }
            if (pnBall.Bounds.IntersectsWith(pnTop.Bounds)) // Slår i taket
            {
                vY = 1;
            }
            if (pnBall.Bounds.IntersectsWith(pnBottom.Bounds)) // Slår i golvet
            {
                vY = -1;
            }

            // Kolla om boll utanför
            if (ball.X < 0)
            {
                playerRight.AddPoint();
                lblRightPoints.Text = playerRight.Point.ToString();
                resetPositions();
            }
            if (ball.X > 816)
            {
                playerLeft.AddPoint();
                lblLeftPoints.Text = playerLeft.Point.ToString();
                resetPositions();
            }

            //send(ball.ToString());
            //send(playerLeft.ToString());
            //send(playerRight.ToString());
        }
    }
}

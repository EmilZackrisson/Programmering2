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
        TcpListener lyssnare1;
        TcpListener lyssnare2;
        TcpClient klient1;
        TcpClient klient2;

        int port1 = 34512;
        int port2 = 34513;

        int vX = 1;
        int vY = 1;

        Point ballStart;
        Point playerRightStart;
        Point playerLeftStart;

        Player playerRight;
        Player playerLeft;

        Ball ball;
        int[] ballDir;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            lyssnare1 = new TcpListener(IPAddress.Any, port1);
            lyssnare2 = new TcpListener(IPAddress.Any, port2);

            lyssnare1.Start();
            lyssnare2.Start();


            btnStartServer.Enabled = false;
            StartaMottagning();
        }

        public async void StartaMottagning()
        {
            try
            {
                klient1 = await lyssnare1.AcceptTcpClientAsync();
                klient2 = await lyssnare2.AcceptTcpClientAsync();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            StartaLäsning(klient1);
            StartaLäsning(klient2);
        }

        public async void StartaLäsning(TcpClient klient)
        {
            byte[] buffert = new byte[1024];

            try
            {
                await klient.GetStream().ReadAsync(buffert, 0, buffert.Length);
                string text = Encoding.UTF8.GetString(buffert);
                Log(text);

                if (text.Contains("högerRedo"))
                {
                    byte[] utdata = Encoding.UTF8.GetBytes("{balldir|" + ballDir.ToString() + "}");
                    await klient2.GetStream().WriteAsync(utdata, 0, utdata.Length);
                    return;
                }
                if (text.Contains("vänsterRedo"))
                {
                    byte[] utdata = Encoding.UTF8.GetBytes("{balldir|" + ballDir.ToString() + "}");
                    await klient1.GetStream().WriteAsync(utdata, 0, utdata.Length);
                    return;
                }

                if (text.Contains("Left"))
                {
                    Player checkPlayer = playerLeft;
                    playerLeft.SetPlayer(text);

                    if (playerLeft.Point > checkPlayer.Point)
                    {
                        byte[] utdataBoll = Encoding.UTF8.GetBytes("{balldir|" + ball.randomizeDirection().ToString() + "}");
                        await klient2.GetStream().WriteAsync(utdataBoll, 0, utdataBoll.Length);
                    }
                    else
                    {
                        pnLeft.Location = playerLeft.Location;
                        byte[] utdata = Encoding.UTF8.GetBytes(playerRight.ToString());
                        await klient1.GetStream().WriteAsync(utdata, 0, utdata.Length);
                    }
                }
                if (text.Contains("Right"))
                {
                    Player checkPlayer = playerRight;
                    playerRight.SetPlayer(text);

                    if (playerRight.Point > checkPlayer.Point)
                    {
                        // Poäng till playerRight, gör ny boll


                        byte[] utdata = Encoding.UTF8.GetBytes("{balldir|" + ball.randomizeDirection().ToString() + "}");
                        await klient2.GetStream().WriteAsync(utdata, 0, utdata.Length);
                    }
                    else
                    {
                        pnRight.Location = playerRight.Location;
                        byte[] utdata = Encoding.UTF8.GetBytes(playerLeft.ToString());
                        await klient2.GetStream().WriteAsync(utdata, 0, utdata.Length);
                    }
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
            klient1.Close();
            klient1.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playerRight = new Player(pnRight.Location, "Right");
            playerLeft = new Player(pnLeft.Location, "Left");
            timer1.Start();

            playerRightStart = playerRight.Location;
            playerLeftStart = playerLeft.Location;
            ballStart = pnBall.Location;

            ball = new Ball();
            ballDir = ball.randomizeDirection();
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
        }
    }
}

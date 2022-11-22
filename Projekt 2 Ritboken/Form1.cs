using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_2_Ritboken
{
    public partial class Form1 : Form
    {
        List<Point> points = new List<Point>();
        List<Point> drawPoints = new List<Point>();
        List<Panel> panelsColor = new List<Panel>();
        Color currentColor = Color.White;
        public Form1()
        {
            InitializeComponent();
        }

        private void pnDraw_MouseClick(object sender, MouseEventArgs e)
        {
            lblInfo.Text = "(" + e.X + ", "+ e.Y + ")";
            points.Add(new Point(e.X, e.Y));
            Graphics g = pnDraw.CreateGraphics();
            int antalPunkter = points.Count;
            if (rdbLine.Checked)
            {
                if (antalPunkter > 1)
                {
                    int sista = antalPunkter - 1;
                    Point from = points[sista - 1];
                    Point to = points[sista];
                    Pen pen = new Pen(currentColor, tbrPenThickness.Value);
                    g.DrawLine(pen, from, to);
                    points.Clear();
                }
            }
            if (rdbRect.Checked)
            {
                if (antalPunkter > 1)
                {
                    int sista = antalPunkter - 1;
                    Point from = points[sista - 1];
                    Point to = points[sista];
                    //int width = from.X - to.X;
                    int width = to.X - from.X;
                    //int height = from.Y - to.Y;
                    int height = to.Y - from.Y;

                    int w = Math.Abs(from.X- to.X);
                    int h = Math.Abs(from.Y - to.Y);

                    if (to.X >= from.X)
                    {
                        if (to.Y >= from.Y)
                        {
                            Rectangle rect = new Rectangle(from.X, from.Y, w, h);

                            Pen pen = new Pen(currentColor, tbrPenThickness.Value);
                            g.DrawRectangle(pen, rect);
                            points.Clear();
                        }
                        else
                        {
                            Rectangle rect = new Rectangle(from.X, to.Y, w, h);

                            Pen pen = new Pen(currentColor, tbrPenThickness.Value);
                            g.DrawRectangle(pen, rect);
                            points.Clear();
                        }
                    }
                    else
                    {
                        if (to.Y >= from.Y)
                        {
                            Rectangle rect = new Rectangle(to.X, from.Y, w, h);

                            Pen pen = new Pen(currentColor, tbrPenThickness.Value);
                            g.DrawRectangle(pen, rect);
                            points.Clear();
                        }
                        else
                        {
                            Rectangle rect = new Rectangle(to.X, to.Y, w, h);

                            Pen pen = new Pen(currentColor, tbrPenThickness.Value);
                            g.DrawRectangle(pen, rect);
                            points.Clear();
                        }
                    }

                    
                }
            }
            if (rdbCirkel.Checked)
            {
                if (antalPunkter > 1)
                {
                    int sista = antalPunkter - 1;
                    Point from = points[sista - 1];
                    Point to = points[sista];
                    //int width = from.X - to.X;
                    int width = to.X - from.X;
                    //int height = from.Y - to.Y;
                    int height = to.Y - from.Y;

                    Rectangle rect = new Rectangle(from.X, from.Y, width, height);

                    Pen pen = new Pen(currentColor, tbrPenThickness.Value);
                    g.DrawEllipse(pen, rect);
                    points.Clear();
                }
            }
        }

        private void pnColor_Click(object sender, EventArgs e)
        {
            // tar bort 3d border
            foreach (Panel panel in panelsColor)
            {
                if (panel.BorderStyle == BorderStyle.Fixed3D)
                {
                    panel.BorderStyle = BorderStyle.None;
                }
            }
            Panel klickadPanel = (Panel)sender;
            
            foreach(Panel panel in panelsColor)
            {
                if (panel == klickadPanel)
                {
                    panel.BorderStyle = BorderStyle.Fixed3D;
                    currentColor = panel.BackColor;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelsColor.Add(pnCyan);
            panelsColor.Add(pnBlack);
            panelsColor.Add(pnBlue);
            panelsColor.Add(pnGreen);
            panelsColor.Add(pnMagenta);
            panelsColor.Add(pnRed);
            panelsColor.Add(pnWhite);
            panelsColor.Add(pnYellow);
            panelsColor.Add(pnIndigo);
            panelsColor.Add(pnHotPink);
        }

        private void pnDraw_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "(" + e.X + ", " + e.Y + ")";
            if (e.Button == MouseButtons.Left && rdbPenna.Checked)
            {
                Pen pen = new Pen(currentColor, tbrPenThickness.Value);
                Point currentPosition = new Point(e.X, e.Y);
                //Point clickedPosition = points.Last();
                Graphics g = pnDraw.CreateGraphics();
                if (drawPoints.Count == 0)
                {
                    drawPoints.Add(currentPosition);
                }
                else if (drawPoints.Count != 0)
                {
                    if (currentPosition.X != drawPoints.Last().X || currentPosition.Y != drawPoints.Last().Y)
                    {
                        
                        g.DrawLine(pen, drawPoints.Last(), currentPosition);
                        drawPoints.Add(currentPosition);
                    }
                }
            }
        }

        private void pnDraw_MouseUp(object sender, MouseEventArgs e)
        {
            drawPoints.Clear();
        }

        private void changeTool(object sender, EventArgs e)
        {
            points.Clear();
            drawPoints.Clear();
        }
    }
}
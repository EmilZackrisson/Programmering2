using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_1._3
{
    public partial class Form1 : Form
    {
        PictureBox[,] bilder = new PictureBox[5, 5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int xLed = 0; // Start pos för x
            int yLed = 0;
            for (int r = 0; r < 5; r++)
            {
                for (int k = 0; k < 5; k++)
                {
                    bilder[r, k] = new PictureBox();
                    bilder[r, k].Width = 100;
                    bilder[r, k].Height = 100;
                    bilder[r, k].Left = xLed + k * 100;
                    bilder[r, k].Top = yLed + r * 100;
                    bilder[r, k].BackgroundImage = Image.FromFile("Blomma.png");
                    this.Controls.Add(bilder[r, k]);

                    bilder[r, k].Click += pbxBlommaClick;
                }
            }
        }

        private void pbxBlommaClick(object sender, EventArgs e)
        {
            PictureBox klickadBlomma = (PictureBox)sender;
            klickadBlomma.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}

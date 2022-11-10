using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exempel1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PictureBox[] bilder = new PictureBox[5];

            int x = 0, y = 0, width = 100, height = 100;

            for (int i = 0; i < bilder.Length; i++)
            {
                bilder[i] = new PictureBox();
                bilder[i].Left = x;
                bilder[i].Top = y;
                bilder[i].Width = width;
                bilder[i].Height = height;
                bilder[i].BackgroundImage = Image.FromFile("C:\\Programmering 2\\C#\\Exempel1.2\\Blomma.png");
                bilder[i].Click += pbxBlomma_Click;

                this.Controls.Add(bilder[i]);
                x += width;
            }
        }

        private void pbxBlomma_Click(object sender, EventArgs e)
        {
            PictureBox klickadBlomma = (PictureBox)sender;
            klickadBlomma.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}

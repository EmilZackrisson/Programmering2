using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skrivprogram___RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void färgväljare(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
                panelColor.BackColor = colorDialog1.Color;
            }
        }

        private void rdbVänster_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void rdbCenter_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void rdbHöger_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void vänsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ikonen måste vara 25x25 pixlar i storlek",
                "Ikonväljare",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rdbVänster.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
        }

        private void mittenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ikonen måste vara 25x25 pixlar i storlek",
                "Ikonväljare",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rdbCenter.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
        }

        private void högerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ikonen måste vara 25x25 pixlar i storlek",
                "Ikonväljare",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rdbHöger.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
        }
    }
}

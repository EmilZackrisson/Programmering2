using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                btnFont.Text = "Teckensnitt: " + fontDialog1.Font.Name;
                btnFont.Font = fontDialog1.Font;
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
            if (MessageBox.Show("Ikonen måste vara 25x25 pixlar i storlek",
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

        private void Form1_Load(object sender, EventArgs e)
        {
            btnFont.Text = "Teckensnitt: " + richTextBox1.Font.Name;
            btnFont.Font = richTextBox1.Font;


            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily fa in col.Families)
                {
                    cbxFonts.Items.Add(fa.Name);

                }
            }
            cbxFonts.SelectedItem = richTextBox1.Font.Name;
        }

        private void öppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                FileStream inStröm = new FileStream(openFileDialog2.FileName, FileMode.Open, FileAccess.Read);
                StreamReader läsare = new StreamReader(inStröm);

                string filText = läsare.ReadToEnd();
                richTextBox1.Text = filText;
                läsare.Dispose();
            }
        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream utStröm = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(utStröm);

                writer.Write(richTextBox1.Text);
                writer.Dispose();
            }


        }

        private void cbxFonts_SelectedValueChanged(object sender, EventArgs e)
        {
            updateFont(cbxFonts.SelectedItem.ToString(), (int)numericUpDown1.Value, cbxBold.Checked, cbxItalic.Checked);
            Font font = new Font(cbxFonts.SelectedItem.ToString(), 8);
            cbxFonts.Font = font;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            updateFont(cbxFonts.SelectedItem.ToString(), (int)numericUpDown1.Value, cbxBold.Checked, cbxItalic.Checked);

        }

        private void cbxItalic_CheckedChanged(object sender, EventArgs e)
        {
            updateFont(cbxFonts.SelectedItem.ToString(), (int)numericUpDown1.Value, cbxBold.Checked, cbxItalic.Checked);
        }

        private void cbxBold_CheckedChanged(object sender, EventArgs e)
        {
            updateFont(cbxFonts.SelectedItem.ToString(), (int)numericUpDown1.Value, cbxBold.Checked, cbxItalic.Checked);

        }

        private void updateFont(string font, int fontSize, bool bold, bool italic)
        {
            Font font1 = new Font(font, fontSize);
            if (bold)
            {
                richTextBox1.SelectionFont = new Font(font1, FontStyle.Bold);
            }
            if (italic)
            {
                richTextBox1.SelectionFont = new Font(font1, FontStyle.Italic);
            }
            if (bold && italic)
            {
                richTextBox1.SelectionFont = new Font(font1, FontStyle.Bold | FontStyle.Italic);
            }
            if (!bold && !italic)
            {
                richTextBox1.SelectionFont = new Font(font1, FontStyle.Regular);
            }
        }
    }
}

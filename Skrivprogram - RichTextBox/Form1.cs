using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Skrivprogram___RichTextBox
{

    public partial class Form1 : Form
    {
        bool sparat = false;
        string savePath = "";

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
                Font font = new Font(fontDialog1.Font.Name, 8, fontDialog1.Font.Style);
                btnFont.Font = font;
                cbxFonts.SelectedText = font.Name;
                cbxFonts.Font = font;
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
            open();
        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
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

        private void saveAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                savePath = saveFileDialog1.FileName;
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                sparat = true;
                string filenameWithExtention = Path.GetFileName(saveFileDialog1.FileName);
                Form1.ActiveForm.Text = filenameWithExtention;

            }
        }

        private void save()
        {
            if (savePath != "")
            {
                richTextBox1.SaveFile(savePath, RichTextBoxStreamType.RichText);
                sparat = true;

                string filenameWithExtention = Path.GetFileName(savePath);
                Form1.ActiveForm.Text = filenameWithExtention;
            }
            else
            {
                saveAs();
            }
        }

        private void open()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                sparat = true;
                Form1.ActiveForm.Text = openFileDialog1.SafeFileName;
                savePath = openFileDialog1.FileName;
            }
        }

        private void newFile()
        {
            DialogResult dialogResult = MessageBox.Show("Vill du spara?", "Spara?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                save();
                richTextBox1.Clear();
                sparat = false;
                savePath = "";
            }
            else if (dialogResult == DialogResult.No)
            {
                richTextBox1.Clear();
                sparat = false;
                savePath = "";
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
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

        private void sparaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            save();
        }


        private void nyttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            sparat = false;
            if (!Form1.ActiveForm.Text.Contains("(unsaved)"))
            {
                string title = Form1.ActiveForm.Text + " (unsaved)";
                Form1.ActiveForm.Text = title;
            }

        }

        
    }
}

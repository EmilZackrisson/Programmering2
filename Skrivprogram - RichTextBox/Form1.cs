﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
                    //rdbVänster.Image = Image.FromFile(openFileDialog1.FileName);
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
                    //rdbCenter.Image = Image.FromFile(openFileDialog1.FileName);
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
                    //rdbHöger.Image = Image.FromFile(openFileDialog1.FileName);
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

                string text = läsFormattering();
                File.WriteAllText(savePath, text);

                sparat = true;
                string filenameWithExtention = Path.GetFileName(saveFileDialog1.FileName);
                Form1.ActiveForm.Text = filenameWithExtention;
            }
        }

        private void save()
        {
            
            // Sparar en fil med ett nytt fränt filformat (.skitformat)
            try
            {
                if (savePath != "")
                {
                    File.WriteAllText(savePath, läsFormattering());
                    sparat = true;

                    string filenameWithExtention = Path.GetFileName(savePath);
                    Form1.ActiveForm.Text = filenameWithExtention;
                }
                else
                {
                    saveAs();
                }
            }
            catch (Exception error)
            {
                showErrorMessage(error);
            } 


        }

        private void open()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialog1.FileName);
                decodeFormatting(text);
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
                //save();
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
            //läsFormattering();

            lblAntalOrd.Text = "Antal ord: " + ordräknare();
            lblAntalTecken.Text = "Antal tecken: " + teckenräknare().ToString();


        }
        private int ordräknare()
        {
            int count = 0;
            bool inWord = false;

            string text = richTextBox1.Text;
            foreach (char t in text)
            {
                if (char.IsWhiteSpace(t))
                {
                    inWord = false;
                }
                else
                {
                    if (!inWord) count++;
                    inWord = true;
                }
            }
            return count;
        }

        private int teckenräknare()
        {
            int antal = 0;
            foreach (char tecken in richTextBox1.Text)
            {
                antal++;
            }
            return antal;
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            int nuvarandeRad = richTextBox1.GetLineFromCharIndex(richTextBox1.GetFirstCharIndexOfCurrentLine()) + 1;
            lblRad.Text = "Rad: " + nuvarandeRad.ToString();

            int plats = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine();
            lblPlats.Text = plats.ToString();
        }

        private string läsFormattering()
        {
            string text = richTextBox1.Text;
            string textExtra = "";
            for (int i = 0; i < text.Length; i++)
            {
                // Extract the character at the current index
                char currentChar = text[i];

                // Get the character's formatting
                int charFormatStart = richTextBox1.GetFirstCharIndexFromLine(richTextBox1.GetLineFromCharIndex(i));
                int charFormatLength = i - charFormatStart + 1;

                // Get the font style of the character
                richTextBox1.SelectionStart = i;
                Font charFormatFont = richTextBox1.SelectionFont;
                FontStyle fontStyle = richTextBox1.SelectionFont.Style;
                Color charColor = richTextBox1.SelectionColor;

                

                // Formats the file correctly with all nessecary values
                textExtra = textExtra + "{" + currentChar + "Î" + charFormatFont + "Î" + fontStyle + "Î" + charColor + "}";

                
            }
            return textExtra;
        }

        

        private void decodeFormatting(string formattedText)
        {
            try
            {
                List<string> tecken = formattedText.Split('}').ToList();
                tecken.RemoveAt(tecken.Count - 1);
                int index = 0;
                foreach (string teckenItem in tecken)
                {
                    //rtbDebug.AppendText(teckenItem + "\n");
                    string text = teckenItem.Remove(0, 1);
                    List<string> format = text.Split('Î').ToList();
                    richTextBox1.AppendText(format[0]);
                    richTextBox1.Select(index, 1);
                    richTextBox1.SelectionFont = decodeFont(format[1], format[2]);

                    // Extract and set color from file
                    string colorName = format[2].Substring(7);
                    colorName = colorName.Remove(colorName.Length - 1, 1);
                    richTextBox1.SelectionColor = Color.FromName(colorName);


                    index++;
                }
            }
            catch (Exception error)
            {
                showErrorMessage(error);
                throw;
            }
            
        }

        private Font decodeFont(string fontString, string fontStyle)
        {
            try
            {
                // Remove ] from the end of the string
                fontString = fontString.Remove(fontString.Length - 1);

                string[] properties = fontString.Split(',');
                Font font = new Font(properties[0].Split('=')[1], 9);
                for (int i = 1; i < properties.Length; i++)
                {
                    string[] property = properties[i].Split('=');
                    string propertyName = property[0].Trim();
                    string propertyValue = property[1].Trim();

                    if (propertyName.Contains("Size"))
                    {
                        float size = float.Parse(propertyValue);
                        font = new Font(font.Name, size);
                    }

                    if (fontStyle != "")
                    {
                        var fontSyle = (FontStyle)Enum.Parse((typeof(FontStyle)), fontStyle);
                        font = new Font(font.Name, font.Size, fontSyle);
                    }


                    //rtbDebug.AppendText(properties[i].ToString() + "\n");
                }
                return font;
            }
            catch (Exception error)
            {
                showErrorMessage(error);
                throw;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontStyle style = richTextBox1.SelectionFont.Style;

            Font font = new Font(richTextBox1.SelectionFont, FontStyle.Bold | FontStyle.Italic);
            MessageBox.Show(font.ToString());
        }

        private void showErrorMessage(Exception error)
        {
            MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}

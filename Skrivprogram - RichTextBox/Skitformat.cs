using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RichTextBox = System.Windows.Forms.RichTextBox;

namespace Skrivprogram___RichTextBox
{
    internal class Skitformat
    {

        // Encodes a richtextbox to the format skitformat for saving
        public string richTextBoxToString(RichTextBox richTextBox)
        {
            string text = richTextBox.Text;
            string textExtra = "";
            for (int i = 0; i < text.Length; i++)
            {
                // Extract the character at the current index
                char currentChar = text[i];

                // Get the character's index
                int charFormatStart = richTextBox.GetFirstCharIndexFromLine(richTextBox.GetLineFromCharIndex(i));
                int charFormatLength = i - charFormatStart + 1;

                // Get the font, style and color for char
                richTextBox.SelectionStart = i;
                Font charFormatFont = richTextBox.SelectionFont;
                FontStyle fontStyle = richTextBox.SelectionFont.Style;
                Color charColor = richTextBox.SelectionColor;
                HorizontalAlignment alignment = richTextBox.SelectionAlignment;

                // Formats the file correctly with all nessecary values
                textExtra = textExtra + "{" + currentChar + "Î" + charFormatFont + "Î" + fontStyle + "Î" + charColor + "Î" + alignment + "}";
            }
            return textExtra;
        }

        // Reads formatted file and fills in the rich text box
        public void readFile(RichTextBox richTextBox, string formattedText)
        {
            try
            {
                richTextBox.Clear();
                List<string> tecken = formattedText.Split('}').ToList();
                tecken.RemoveAt(tecken.Count - 1);
                int index = 0;
                foreach (string teckenItem in tecken)
                {
                    // Remove first { from string
                    string text = teckenItem.Remove(0, 1);

                    List<string> format = text.Split('Î').ToList(); // Split properties
                    richTextBox.AppendText(format[0]); // Print char into textbox

                    // Sets correct font and style to char
                    richTextBox.Select(index, 1);
                    richTextBox.SelectionFont = decodeFont(format[1], format[2]);

                    // Extract and set color from file
                    string colorName = format[3].Substring(7);
                    colorName = colorName.Remove(colorName.Length - 1, 1);
                    richTextBox.SelectionColor = Color.FromName(colorName);

                    // Set the horizontal alignment from file
                    var horizontalAlignment = (HorizontalAlignment)Enum.Parse(typeof(HorizontalAlignment), format[4]);
                    richTextBox.SelectionAlignment = horizontalAlignment;

                    index++;
                }
            }
            catch (Exception error)
            {
                showErrorMessage(error);
                throw;
            }
        }

        // Decodes skitformat string to a font
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
                }
                return font;
            }
            catch (Exception error)
            {
                showErrorMessage(error);
                throw;
            }
        }

        private void showErrorMessage(Exception error)
        {
            MessageBox.Show(error.Message, "Error with Skitformat", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int storlek = 10;

            if (tbxStorlek.Text != "")
            {
                storlek = Convert.ToInt32(tbxStorlek.Text);
            }
            FontStyle stil = FontStyle.Regular;

            if (cbxFet.Checked)
            {
                stil = stil | FontStyle.Bold;
            }
            if (cbxKursiv.Checked)
            {
                stil = stil | FontStyle.Italic;
            }
            if (cbxUnderstruket.Checked)
            {
                stil = stil | FontStyle.Underline;
            }

            Font font = new Font(tbxTeckensnitt.Text, storlek, stil);
            richTextBox1.Font = font;
        }
    }
}

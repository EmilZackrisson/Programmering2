using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heltal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrollera_Click(object sender, EventArgs e)
        {
            int heltal = 0;
            bool ärJagHeltal = int.TryParse(textBox1.Text, out heltal);
            if (ärJagHeltal)
            {
                MessageBox.Show("Du matade in heltal.");
            }
            else
            {
                MessageBox.Show("Du matade in fel tal.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox2.Text;
            Password password;
            try
            {
                password = new Password(str);
            }
            catch (CheckMyPasswordExeption error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}

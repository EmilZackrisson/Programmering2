using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Undantagshantering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            try
            {
                a = Convert.ToInt32(textBox1.Text);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + "Textbox 1");
            }
            try
            {
                b = Convert.ToInt32(textBox2.Text);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + "Textbox 2");
            }
            label1.Text = (a + b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] fält = new int[10];
            int index = 0;

            try
            {
                index = Convert.ToInt32(textBox4.Text);
                fält[index] = 0;
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }

            try
            {
                fält[index] = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}

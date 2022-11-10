using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Each_vs_For
{
    public partial class Form1 : Form
    {

        string[] namnArr = { "Kalle", "Erik", "Jonas", "Hejsan" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < namnArr.Length; i++)
            {
                if (namnArr[i] == textBox1.Text)
                {
                    index = i;
                }
            }
            if (index != -1)
            {
                label1.Text = "Ditt namn finns på index " + index;
            }
            else
            {
                label1.Text = "Namnet du sökte på finns inte i listan.";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool hittad = false;
            foreach (string s in namnArr)
            {
                if (s == textBox1.Text)
                {
                    hittad = true;
                }

            }
            if (hittad)
            {
                label1.Text = "Namnet finns i listan";
            }
            else
            {
                label1.Text = "Namnet finns inte i listan";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lektion3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Kalle";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            if (str.Contains("+"))
            {
                int teckenIndex = str.IndexOf("+");
                string förstaStr = str.Substring(0, teckenIndex);
                string andraStr = str.Substring(teckenIndex + 1);

                int första = Convert.ToInt32(förstaStr);
                int andra = Convert.ToInt32(andraStr);


                button1.Text = (första + andra).ToString();
            }
            else if (str.Contains("-"))
            {
                int teckenIndex = str.IndexOf("-");
                string förstaStr = str.Substring(0, teckenIndex);
                string andraStr = str.Substring(teckenIndex + 1);

                int första = Convert.ToInt32(förstaStr);
                int andra = Convert.ToInt32(andraStr);


                button1.Text = (första - andra).ToString();
            }
            else if (str.Contains("*"))
            {
                int teckenIndex = str.IndexOf("*");
                string förstaStr = str.Substring(0, teckenIndex);
                string andraStr = str.Substring(teckenIndex + 1);

                int första = Convert.ToInt32(förstaStr);
                int andra = Convert.ToInt32(andraStr);


                button1.Text = (första * andra).ToString();
            }
            else
            {
                int teckenIndex = str.IndexOf("/");
                string förstaStr = str.Substring(0, teckenIndex);
                string andraStr = str.Substring(teckenIndex + 1);

                int första = Convert.ToInt32(förstaStr);
                int andra = Convert.ToInt32(andraStr);


                button1.Text = (första / andra).ToString();
            }
        }
    }
}

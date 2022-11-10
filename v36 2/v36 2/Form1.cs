using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v36_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string avrundare(string exaktText)
        {
            double tal = Convert.ToDouble(exaktText);
            double trix = tal + 0.5;
            int avrundat = (int)trix;
            return avrundat.ToString();
        }

        private void btnAvrunda_Click(object sender, EventArgs e)
        {
            tbxAvrundat.Text = avrundare(tbxExakt.Text);
        }
    }
}

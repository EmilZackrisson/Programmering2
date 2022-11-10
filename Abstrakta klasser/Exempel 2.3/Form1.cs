using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exempel_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRäkna_Click(object sender, EventArgs e)
        {
            string namn = tbxNamn.Text;
            double försäljning = Convert.ToDouble(tbxFörsäljning.Text);
            double provision = Convert.ToDouble(tbxProvision.Text);

            Anställd anställd = new Säljare(namn, försäljning, provision);
            double lön = anställd.BeräknaLön();
            lblLön.Text = "Lön: " + lön;
        }
    }
}

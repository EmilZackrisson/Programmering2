using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sparbanken_Banken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUppÅrsränta_Click(object sender, EventArgs e)
        {

        }

        private void btnUttag_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            if (tbxPersonNr.Text != "")
            {
                if (tbxKredit.Text != "")
                {
                    // Skapa ett kredit konto
                    string personnummer = tbxPersonNr.Text;
                    double räntesats = Convert.ToDouble(tbxRäntesats.Text);
                    Lånekonto lånekonto = new Lånekonto(personnummer, räntesats);
                }
                else
                {
                    // Skapa ett sparkonto
                }
            }
        }

        private void btnInsättning_Click(object sender, EventArgs e)
        {
            string belopp = tbxBelopp.Text;

        }
    }
}

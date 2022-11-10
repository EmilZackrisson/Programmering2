using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Användarkonton
{
    public partial class Form1 : Form
    {
        private List<Konto> konton = new List<Konto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            foreach (Konto konto in konton)
            {
                if (konto.Namn == tbxAnvändare.Text && konto.Lösenord == tbxLösenord.Text)
                {
                    lblVälkommen.Text = "Välkommen\r\n" + konto.Namn;
                    lblVälkommen.Visible = true;
                }
            }
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            if (Konto.GodkännLösenord(tbxLösenord.Text))
            {
                Konto nyttKonto = new Konto(tbxAnvändare.Text, tbxLösenord.Text);
                konton.Add(nyttKonto);
                lbxAnvändare.Items.Add(nyttKonto);

            }
            else
            {
                MessageBox.Show("Lösenordet måste innehålla minst 8 tecken");
            }
        }

    }
}

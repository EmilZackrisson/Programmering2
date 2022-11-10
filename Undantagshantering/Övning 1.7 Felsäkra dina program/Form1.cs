using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Övning_1._7_Felsäkra_dina_program.Konto;

namespace Övning_1._7_Felsäkra_dina_program
{
    public partial class Form1 : Form
    {
        Konto konto;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSkapa_Click(object sender, EventArgs e)
        {
            string epost = tbxEpost.Text;
            string lösenord = tbxLösenord.Text;

            try
            {
                konto = new Konto(epost, lösenord);

            }
            catch (LösenFormatExeption error)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            catch (EpostFormatExeption error)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            MessageBox.Show("Kontot skapat");
        }
    }
}

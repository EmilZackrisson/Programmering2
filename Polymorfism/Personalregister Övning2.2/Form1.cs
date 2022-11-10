using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personalregister_Övning2._2
{
    public partial class Form1 : Form
    {
        List<Anställd> anställda = new List<Anställd>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSäljareRegistrera_Click(object sender, EventArgs e)
        {
            try
            {
                Säljare säljare = new Säljare(tbxSäljareNamn.Text, Convert.ToDouble(tbxSäljareProvision.Text), Convert.ToDouble(tbxSäljareFörsäljning.Text));
                anställda.Add(säljare);

                uppdateraListaAnställda();
                uppdateraListaLöneutbetalningar();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        void uppdateraListaAnställda()
        {
            lbxRegister.Items.Clear();
            foreach (var anställd in anställda)
            {
                lbxRegister.Items.Add(anställd.ToString());
            }

        }

        void uppdateraListaLöneutbetalningar()
        {
            lbxLöneutbetalningar.Items.Clear();
            foreach (var anställd in anställda)
            {
                lbxLöneutbetalningar.Items.Add(anställd.ToString() + anställd.BeräknaLön());
            }
        }

        private void btnRegArbetspass_Click(object sender, EventArgs e)
        {
            try
            {
                Konsult konsult = new Konsult(tbxKonsultNamn.Text, Convert.ToDouble(tbxKonsultArbetadTid.Text), Convert.ToDouble(tbxKonsultTimlön.Text));
                anställda.Add(konsult);

                uppdateraListaAnställda();
                uppdateraListaLöneutbetalningar();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnRegistreraMånadslön_Click(object sender, EventArgs e)
        {
            try
            {
                Kontorist kontorist = new Kontorist(tbxKontoristNamn.Text, Convert.ToDouble(tbxKontoristMånadslön.Text));
                anställda.Add(kontorist);

                uppdateraListaAnställda();
                uppdateraListaLöneutbetalningar();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnBeräknaLöner_Click(object sender, EventArgs e)
        {
            double summa = 0;
            for (int i = 0; i < anställda.Count; i++)
            {
                summa = summa + anställda[i].BeräknaLön();
            }
            tbxTotalLönekostnad.Text = Convert.ToString(summa);
        }
    }
}

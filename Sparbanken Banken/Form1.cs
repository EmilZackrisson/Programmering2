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
        Bank bank = new Bank();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUppdateraMedÅrsränta_Click(object sender, EventArgs e)
        {

        }

        private void btnUttag_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            if (tbxKredit.Text == "")
            {
                SparKonto sparKonto = new SparKonto(tbxPersonNr.Text, 0, 0);
                bank.konton.Add(sparKonto);
                listBox1.Items.Add(sparKonto.ToString());
                
            }
            else
            {
               // LåneKonto låneKonto = new LåneKonto();
            }
        }

        private void uppdateraLista(List<BankKonto> lista)
        {

        }

        private void btnInsättning_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}

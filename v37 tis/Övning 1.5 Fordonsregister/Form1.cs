using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Övning_1._5_Fordonsregister
{
    public partial class Form1 : Form
    {
        List<Fordon> registreradeFordon = new List<Fordon>();
        enum FordonsTyp { Bil, MC };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            Fordon nyttFordon = new Fordon();
            if (Fordon.GodkännRegNr(tbxRegNr.Text) && ledigtRegNr(tbxRegNr.Text))
            {
                nyttFordon.RegNr = tbxRegNr.Text;
            }
            if (!Fordon.GodkännRegNr(tbxRegNr.Text))
            {
                MessageBox.Show("RegNr är inte i rätt format (ABC123)");
            }
            if (tbxMärke.Text != "")
            {
                nyttFordon.Märke = tbxMärke.Text;
            }
            else
            {
                MessageBox.Show("Inget märke?");
            }
            if (tbxModell.Text != "")
            {
                nyttFordon.Modell = tbxModell.Text;
            }
            else
            {
                MessageBox.Show("Ingen modell?");
            }

            nyttFordon.Typ = cbxTyp.Text;

            if (ledigtRegNr(tbxRegNr.Text) && Fordon.GodkännRegNr(tbxRegNr.Text))
            {
                registreradeFordon.Add(nyttFordon);
                uppdateraLista(registreradeFordon);
            }
        }

        private void uppdateraLista(List<Fordon> registreradeFordon)
        {
            listBox1.Items.Clear();
            foreach (var fordon in registreradeFordon)
            {
                if (rbxAlla.Checked)
                {
                    listBox1.Items.Add(fordon.ToString());
                }
                if (rbxBilar.Checked)
                {
                    if (fordon.Typ == "Bil")
                    {
                        listBox1.Items.Add(fordon.ToString());
                    }
                }
                if (rbxMC.Checked)
                {
                    if (fordon.Typ == "MC")
                    {
                        listBox1.Items.Add(fordon.ToString());
                    }
                }
            }
        }

        private bool ledigtRegNr(string regNr)
        {
            foreach (var registreradeFordon in registreradeFordon)
            {
                if (registreradeFordon.RegNr == regNr)
                {
                    MessageBox.Show("Registreringsnummret finns redan i listan.");
                    return false;
                }
            }
            return true;
        }

        private void rbxAlla_CheckedChanged(object sender, EventArgs e)
        {
            uppdateraLista(registreradeFordon);
        }

        private void rbxBilar_CheckedChanged(object sender, EventArgs e)
        {
            uppdateraLista(registreradeFordon);
        }

        private void rbxMC_CheckedChanged(object sender, EventArgs e)
        {
            uppdateraLista(registreradeFordon);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxTyp.Items.Clear();
            cbxTyp.DataSource = Enum.GetValues(typeof(FordonsTyp));
        }

        private void btnSök_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            for (int i = 0; i < registreradeFordon.Count; i++)
            {
                if (registreradeFordon[i].RegNr.ToUpper() == tbxSök.Text.ToUpper())
                {
                    listBox1.SelectedIndex = i;
                }
                if (registreradeFordon[i].Märke.ToUpper() == tbxSök.Text.ToUpper())
                {
                    listBox1.SelectedIndex = i;
                }
                if (registreradeFordon[i].Modell.ToUpper() == tbxSök.Text.ToUpper())
                {
                    listBox1.SelectedIndex = i;
                }
                listBox1.Update();
                listBox1.Focus();
            }
        }
    }
}
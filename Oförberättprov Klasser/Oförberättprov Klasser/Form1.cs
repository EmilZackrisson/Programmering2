using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oförberättprov_Klasser
{
    public partial class Form1 : Form
    {
        List<Planet> lista = new List<Planet>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lista.Clear();
            uppdateraLista(lista);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                bool beboelig;
                if (rdbBeboeligJa.Checked)
                {
                    beboelig = true;
                }
                else if (rdbBeboeligNej.Checked)
                {
                    beboelig = false;
                }
                else
                {
                    MessageBox.Show("Du måste säga om den är beboelig eller inte.");
                    return;
                }
                Planet planet = new Planet(
                    tbxRegNamn.Text,
                    Convert.ToInt32(tbxRegVolym.Text),
                    Convert.ToDouble(tbxRegRadie.Text),
                    beboelig
                );
                lista.Add(planet);
                uppdateraLista(lista);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        void uppdateraLista(List<Planet> lista)
        {
            if (checkBox1.Checked)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Beboelig)
                    {
                        listBox1.Items.Add(lista[i].ToString());
                    }
                }
                listBox1.Update();
            }
            else
            {
                listBox1.Items.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    listBox1.Items.Add(lista[i].ToString());
                }
                listBox1.Update();
            }
        }

        private void btnRensaReg_Click(object sender, EventArgs e)
        {
            tbxRegNamn.Clear();
            tbxRegRadie.Clear();
            tbxRegVolym.Clear();
            rdbBeboeligJa.Checked = false;
            rdbBeboeligNej.Checked = false;
        }

        private void btnUppdatera_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = listBox1.SelectedIndex;

                bool beboelig;
                if (rdbBeboeligUppdateraJa.Checked)
                {
                    beboelig = true;
                }
                else if (rdbBeboeligUppdateraNej.Checked)
                {
                    beboelig = false;
                }
                else
                {
                    MessageBox.Show("Du måste säga om den är beboelig eller inte.");
                    return;
                }
                Planet planet = new Planet(
                    tbxUppdateraNamn.Text,
                    Convert.ToInt32(tbxUppdateraVolym.Text),
                    Convert.ToDouble(tbxUppdateraRadie.Text),
                    beboelig
                );
                lista.RemoveAt(selectedIndex);
                lista.Add(planet);
                uppdateraLista(lista);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnRemoveSel_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                lista.RemoveAt(index);
                uppdateraLista(lista);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void rdbBeboeligJa_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdbBeboeligJa.Checked && !rdbBeboeligNej.Checked)
            {
                btnReg.Enabled = false;
            }
            else
            {
                btnReg.Enabled = true;
            }
        }

        private void rdbBeboeligNej_CheckedChanged(object sender, EventArgs e)
        {
            kollaIndata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnReg.Enabled = false;
            btnUppdatera.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            uppdateraLista(lista);
        }

        private void btnKopiera_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                lista.Add(lista[listBox1.SelectedIndex]);
                uppdateraLista(lista);
            }
        }

        private void tbxRegNamn_TextChanged(object sender, EventArgs e)
        {
            kollaIndata();
        }

        private void tbxRegRadie_TextChanged(object sender, EventArgs e)
        {
            kollaIndata();
        }

        private void tbxRegVolym_TextChanged(object sender, EventArgs e)
        {
            kollaIndata();
        }

        void kollaIndata()
        {
            if (tbxRegNamn.Text == "" || tbxRegRadie.Text == "" || tbxRegVolym.Text == "" || !rdbBeboeligJa.Checked && !rdbBeboeligNej.Checked)
            {
                btnReg.Enabled = false;
            }
            else
            {
                btnReg.Enabled = true;
            }
        }

        private void tbxUppdateraRadie_TextChanged(object sender, EventArgs e)
        {
            kollaIndataUppdatera();
        }

        private void tbxUppdateraNamn_TextChanged(object sender, EventArgs e)
        {
            kollaIndataUppdatera();
        }

        private void tbxUppdateraVolym_TextChanged(object sender, EventArgs e)
        {
            kollaIndataUppdatera();
        }

        private void rdbBeboeligUppdateraJa_CheckedChanged(object sender, EventArgs e)
        {
            kollaIndataUppdatera();
        }

        private void rdbBeboeligUppdateraNej_CheckedChanged(object sender, EventArgs e)
        {
            kollaIndataUppdatera();
        }

        void kollaIndataUppdatera()
        {
            if (tbxUppdateraNamn.Text == "" || tbxUppdateraRadie.Text == "" || tbxUppdateraVolym.Text == "" || !rdbBeboeligUppdateraJa.Checked && !rdbBeboeligUppdateraNej.Checked)
            {
                btnUppdatera.Enabled = false;
            }
            else
            {
                btnUppdatera.Enabled = true;
            }
        }
    }
}
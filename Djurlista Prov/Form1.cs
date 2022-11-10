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
using ListView = System.Windows.Forms.ListView;

namespace Djurlista_Prov
{
    public partial class Form1 : Form
    {
        List<Djur> minaDjur = new List<Djur>();
        int indexSelection;
        public Form1()
        {
            InitializeComponent();
        }

        // Körs när någon checkbox ändras
        private void checkChanged(object sender, EventArgs e)
        {
            if (rdbHund.Checked)
            {
                gbxRegHund.Visible = true;
                gbxRegKatt.Visible = false;
            }
            if (rdbKatt.Checked)
            {
                gbxRegKatt.Visible = true;
                gbxRegHund.Visible = false;
            }
            if(!rdbHund.Checked && !rdbKatt.Checked)
            {
                gbxRegKatt.Visible = false;
                gbxRegHund.Visible = false;
            }
            
        }

        private void tbxRegHundChanged(object sender, EventArgs e)
        {

        }

        private void tbxRegKattNamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegHund_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(kollaId(tbxRegHundId.Text).ToString());
            if (kollaId(tbxRegHundId.Text))
            {
                Hund nyHund = new Hund(tbxRegHundNamn.Text, tbxRegHundRas.Text, tbxRegHundId.Text);
                
                minaDjur.Add(nyHund);
                //MessageBox.Show(nyHund.Namn + nyHund.Ras + nyHund.Id);
                uppdateraLista(minaDjur);
            }
            else
            {
                MessageBox.Show("Fel ID format: minst 2st #, max 5 små bokstäver, 1 dollar tecken", "Fel ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRegKatt_Click(object sender, EventArgs e)
        {
            try
            {
                Katt nyKatt = new Katt(tbxRegKattNamn.Text, Convert.ToInt32(tbxRegKattÅlder.Text), cbxRegKattOpererad.Checked);
                minaDjur.Add(nyKatt);
                uppdateraLista(minaDjur);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbKatt.Checked = false;
            rdbHund.Checked = false;

            lvDjur.View = View.Details;
            lvDjur.GridLines = true;
            lvDjur.FullRowSelect = true;
        }

        bool kollaId(string id)
        {
            int antalSmå = 0;
            int antalDollar = 0;
            int antalHash = 0;

            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == '#')
                {
                    antalHash++;
                }
                if ((int)id[i] >= 97 && (int)id[i] <= 122)
                {
                    antalSmå++;
                }
                if (id[i] == '$')
                {
                    antalDollar++;
                }
            }

            if (antalSmå <= 5 && antalHash>=2 && antalDollar==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void uppdateraLista(List<Djur> minaDjur)
        {
            lvDjur.Items.Clear();
            foreach (var djur in minaDjur)
            {
                //MessageBox.Show(djur.Namn + djur.Id);
                if (djur.ToString().Contains("Opererad"))
                {
                    // Det är en katt
                    string[] kattArr = new string[5];
                    

                    kattArr[0] = djur.Namn;
                    
                    kattArr[3] = djur.Ålder.ToString();
                    kattArr[4] = djur.Opererad.ToString();

                    ListViewItem item = new ListViewItem(kattArr);
                    lvDjur.Items.Add(item);
                    
                }
                else
                {
                    string[] hundArr = new string[5];

                    hundArr[0] = djur.Namn;
                    hundArr[1] = djur.Ras;
                    hundArr[2] = djur.Id;
                    hundArr[3] = "n/a";
                    hundArr[4] = "n/a";

                    // här går det fel
                    ListViewItem item = new ListViewItem(hundArr);
                    lvDjur.Items.Add(item);
                }
            }
        }

        private void lvDjur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                ListView.SelectedIndexCollection indexes = lvDjur.SelectedIndices;


                foreach (int index in indexes)
                {
                    indexSelection = index;
                    //Hund
                    if (lvDjur.Items[index].SubItems[4].Text == "n/a")
                    {
                        string namn = lvDjur.Items[index].SubItems[0].Text;
                        string ras = lvDjur.Items[index].SubItems[1].Text;
                        string id = lvDjur.Items[index].SubItems[2].Text;

                        gbxUppHund.Visible = true;
                        gbxUppKatt.Visible = false;
                    }
                    // Katt
                    else
                    {

                    
                    
                        string namn = lvDjur.Items[index].SubItems[0].Text;
                        int ålder = Convert.ToInt32(lvDjur.Items[index].SubItems[3].Text);
                        bool opererad = Convert.ToBoolean( lvDjur.Items[index].SubItems[4].Text);

                        gbxUppKatt.Visible = true;
                        gbxUppHund.Visible = false;

                        tbxUppKattNamn.Text = namn;
                        tbxUppKattÅlder.Text = ålder.ToString();
                        cbxUppKattOpererad.Checked = opererad;
                        
                    }

                    

                    
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUppHund_Click(object sender, EventArgs e)
        {

        }

        private void btnUppKatt_Click(object sender, EventArgs e)
        {
            try
            {
                Katt nyKatt = new Katt(tbxUppKattNamn.Text, Convert.ToInt32(tbxUppKattÅlder.Text), cbxUppKattOpererad.Checked);
                minaDjur.RemoveAt(indexSelection);
                minaDjur.Add(nyKatt);
                uppdateraLista(minaDjur);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

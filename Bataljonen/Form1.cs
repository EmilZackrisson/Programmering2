using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bataljonen
{
    public partial class Form1 : Form
    {
        const int BATALJON = 0, KOMPANI = 1, PLUTON = 2, GRUPP = 3;
        private string[] info = { "Bataljon", "Kompani", "Pluton", "Grupp" };
        public Form1()
        {
            InitializeComponent();
            treeView1.SelectedNode = treeView1.Nodes[0];
        }

        private void btnLäggTillNy_Click(object sender, EventArgs e)
        {
            TreeNode valdNod = treeView1.SelectedNode;
            if (valdNod != null)
            {
                TreeNode nyNod = new TreeNode(tbxNyNamn.Text);
                valdNod.Nodes.Add(nyNod);
                if (nyNod.Level == GRUPP) nyNod.Tag = int.Parse(tbxNyAntal.Text);



            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode valdNod = treeView1.SelectedNode;
            rtbInfo.Text = info[valdNod.Level];
            rtbInfo.AppendText("\r\nNamn: " + valdNod.Text);

            if (valdNod.Level == GRUPP) gbxNyEnhet.Enabled = false;
            else gbxNyEnhet.Enabled = true;

            if (valdNod.Level == PLUTON)
            {
                tbxNyAntal.Enabled = true;
                if (valdNod.Tag != null)
                {
                    rtbInfo.AppendText("\r\nAntal soldater: " + valdNod.Tag.ToString());

                }
            }
            else tbxNyAntal.Enabled = false;

            if (valdNod.Level == GRUPP)
            {
                rtbInfo.AppendText("\r\nAntal soldater: " + valdNod.Tag.ToString());
            }


        }
    }
}

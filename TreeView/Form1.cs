using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSkapaNoder_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            selectedNode.Nodes.Add(tbxNodeName.Text);
            selectedNode.Expand();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string valtTräd = e.Node.ToString();
            lblSelectedNodeName.Text = valtTräd;
        }
    }
}

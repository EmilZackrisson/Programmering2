using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_1._2
{
    public partial class Form1 : Form
    {

        int[,] tal = new int[2, 2];
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnÄndra_Click(object sender, EventArgs e)
        {
            tal[Convert.ToInt32(tbxRad), Convert.ToInt32(tbxKol)] = Convert.ToInt32(tbxVärde);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klass
{
    public partial class Form1 : Form
    {
        Jämnt_tal mittTal = new Jämnt_tal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uppdateraLabel();
            int a = 3;
            int b = a;
            Jämnt_tal tal2 = new Jämnt_tal(mittTal);

            int c = 4;
            bool jämnt = Jämnt_tal.ÄrJämnt(c);
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            mittTal.Öka();
            uppdateraLabel();
        }

        private void btnÄndra_Click(object sender, EventArgs e)
        {
            int tal = Convert.ToInt32(tbxTal.Text);
            mittTal.Tal = tal;
            uppdateraLabel();
        }

        private void tbxTal_TextChanged(object sender, EventArgs e)
        {

        }

        private void uppdateraLabel()
        {
            lblTal.Text = mittTal.ToString();
        }
    }
}

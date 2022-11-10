using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorfism
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

        private void btnSkapa_Click(object sender, EventArgs e)
        {
            A r;

            if (rbnTypA.Checked)
            {
                r = new A();
            }
            else
            {
                r = new B();
                B nyttB = (B)r;
            }

            tbxBeskrivning.Text = r.Beskrivning();
        }
    }
}

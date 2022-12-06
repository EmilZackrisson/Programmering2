using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fotbollsligan_DataGridView
{
    public partial class Form1 : Form
    {
        private List<Match> matcher = new List<Match>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMålrikast_Click(object sender, EventArgs e)
        {
            string hemmalag = "";
            string bortalag = "";
            int antalMål = 0;
            for (int i = 0; i < matcher.Count; i++)
            {
                if (matcher[i].MålHemmalag + matcher[i].MålBortalag > antalMål)
                {
                    hemmalag = matcher[i].Hemmalag;
                    bortalag = matcher[i].Bortalag;
                    antalMål = matcher[i].MålHemmalag + matcher[i].MålBortalag;
                }
            }
            textBox1.Text = hemmalag + " " + bortalag + ": " + antalMål;
        }

        private void dgvMatcher_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Match nyMatch = new Match();
            matcher.Add(nyMatch);
        }

        private void dgvMatcher_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (e.ColumnIndex == 0)
            {
                matcher[i].Hemmalag = (string)dgvMatcher.Rows[i].Cells[0].Value;
            }
            else if (e.ColumnIndex == 1)
            {
                matcher[i].Bortalag = (string)dgvMatcher.Rows[i].Cells[1].Value;
            }
            else if (e.ColumnIndex == 2)
            {
                matcher[i].MålHemmalag = int.Parse((string)dgvMatcher.Rows[i].Cells[2].Value);
            }
            else if (e.ColumnIndex == 3)
            {
                matcher[i].MålBortalag = int.Parse((string)dgvMatcher.Rows[i].Cells[3].Value);
            }
        }

        private void dgvMatcher_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int rowIndex = e.Row.Index;

            matcher.RemoveAt(rowIndex);
        }

        private void btnStörstaMålskillnad_Click(object sender, EventArgs e)
        {
            int störstaMålskilland = 0;
            string hemmalag = "";
            string bortalag = "";

            foreach (var match in matcher)
            {
                double skillnad = match.MålHemmalag - match.MålBortalag;
                if (Math.Abs(skillnad) > störstaMålskilland)
                {
                    störstaMålskilland = (int)Math.Abs(skillnad);
                    hemmalag = match.Hemmalag;
                    bortalag = match.Bortalag;
                }
            }
            textBox1.Text = "Största målskillnaden är " + störstaMålskilland + " mellan " + hemmalag + " och " + bortalag;
        }

        private void btnUpp_Click(object sender, EventArgs e)
        {

        }

        private void btnNer_Click(object sender, EventArgs e)
        {

        }
    }
}

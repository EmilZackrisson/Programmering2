using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;
using ListView = System.Windows.Forms.ListView;

namespace My_XL
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();
        bool saved = true;
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e) // Delete row
        {
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
            DataGridViewRow row = rows[0];
            dataGridView1.Rows.Remove(row);
        }

        private void button2_Click(object sender, EventArgs e) // Add row
        {
            dataGridView1.Rows.Add(null, null, null, null);
        }

        private void btnUpdateCell_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateHeader_Click(object sender, EventArgs e)
        {

        }

        private void rdbRowSel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRowSel.Checked)
            {
                
            }
        }

        private void rdbCellSel_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
       

            rdbRowSel.Checked = true;

           
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                DialogResult result = MessageBox.Show("Du har inte sparat dina ändringar. Vill du göra det?", "Spara?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                else if (result == DialogResult.Yes)
                {
                    save();
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        void save()
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                

                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    string name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string ssn = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string gender = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string age = dataGridView1.Rows[i].Cells[3].Value.ToString();

                    string row = name + ";" + ssn + ";" + gender + ";" + age;
                    streamWriter.WriteLine(row);
                    rtxDebug.AppendText(row);
                }

                streamWriter.Dispose();
                saved = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);

                while (!streamReader.EndOfStream)
                {
                    string[] arr = streamReader.ReadLine().Split(';');
                    dataGridView1.Rows.Add(arr);
                }
                streamReader.Dispose();
                saved = true;
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            saved = false;
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            saved = false;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            saved = false;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}

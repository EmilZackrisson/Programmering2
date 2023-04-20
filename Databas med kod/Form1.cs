using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Databas_med_kod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new DBEntities();
            var personer = from person in db.Table
                           select person;

            foreach (var person in personer)
            {
                dataGridView1.Rows.Add(person.PersonNr, person.Förnamn, person.Efternamn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string personNr = textBox1.Text.Trim();
            string förnamn = textBox2.Text.Trim();
            string efternamn = textBox3.Text.Trim();

            var person = new Person();
            person.PersonNr = personNr;
            person.Förnamn = förnamn;
            person.Efternamn = efternamn;

            var db = new DBEntities();


            db.Table.Add(person);
            db.SaveChanges();
        }
    }
}

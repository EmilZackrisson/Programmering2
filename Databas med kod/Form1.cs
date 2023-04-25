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

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string personNrToDelete = e.Row.Cells[0].Value.ToString();

            var db = new DBEntities();
            var removedPerson = from person in db.Table
                                where person.PersonNr == personNrToDelete
                                select person;
            db.Table.Remove(removedPerson.First());
            var changedRows = db.SaveChanges();
            if (changedRows > 0)
            {
                MessageBox.Show(changedRows + " rader ändrades.");
            }

        }

        private void btnBokReg_Click(object sender, EventArgs e)
        {
            var db = new DBEntities();
            var bok = new Bok();
            bok.Titel = tbxBokTitel.Text;
            bok.Ämne = tbxBokÄmne.Text;
            bok.Författare = tbxBokFörfattare.Text;

            db.Böcker.Add(bok);
            int rowsChanged = db.SaveChanges();
            if (rowsChanged > 0)
            {
                MessageBox.Show(rowsChanged + " rader ändrades");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var db = new DBEntities();
            var boklån = new Boklån();
            boklån.PersonNr = tbxBoklånBokNr.Text;
            boklån.BokNr = int.Parse(tbxBoklånBokNr.Text);
            boklån.Datum = dateTimePicker1.Value;

            db.Boklån.Add(boklån);
            int rowsChanged = db.SaveChanges();
            if (rowsChanged > 0)
            {
                MessageBox.Show(rowsChanged + " rader ändrades");
            }
        }
    }
}

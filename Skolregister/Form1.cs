using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Skolregister
{
    public partial class Form1 : Form
    {
        private const int ELEVER = 0, BÖCKER = 1, KURSER = 2, LEDIGA_BÖCKER = 3, LÅNADE_BÖCKER = 4, KURSGRUPP = 5;

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UppdateraDataVy();


        }

        private void btnNyttLån_Click(object sender, EventArgs e)
        {
            int bokNr;
            if( ! int.TryParse(tbxBokNrLån.Text, out bokNr))
            {
                MessageBox.Show("Ogiltigt format på boknummer.");
                return;
            }

            DateTime datum;
            if (! DateTime.TryParse(tbxLåneDatum.Text, out datum))
            {
                MessageBox.Show("Ogiltigt datumformat");
                return;
            }

            using (var db = new SkolregisterEntities())
            {
                // Leta upp eleven
                var elevUrval = from elev in db.Elever where elev.PersonNr == tbxPersonNrLån.Text select elev;

                // Leta upp boken
                var bokUrval = from bok in db.Böcker where bok.BokNr == bokNr select bok;

                if(elevUrval.Count() == 1 && bokUrval.Count() == 1)
                {
                    try
                    {
                        bokUrval.First().Elev = elevUrval.First();
                        bokUrval.First().Lånedatum = datum;
                        db.SaveChanges();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                    finally
                    {
                        tbxPersonNrLån.Clear();
                        tbxBokNrLån.Clear();
                        tbxLåneDatum.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Eleven eller boken finns inte");
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUppdatera_Click(object sender, EventArgs e)
        {
            UppdateraDataVy();
        }

        private void btnRegElev_Click(object sender, EventArgs e)
        {
            Elev nyElev = new Elev();
            nyElev.PersonNr = tbxPersonnummer.Text.Trim();
            nyElev.Förnamn = tbxElevFörnamn.Text.Trim();
            nyElev.Efternamn = tbxElevEfternamn.Text.Trim();

            using (var db = new SkolregisterEntities())
            {
                try
                {
                    db.Elever.Add(nyElev);
                    db.SaveChanges();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnRegBok_Click(object sender, EventArgs e)
        {
            Bok nyBok = new Bok();
            nyBok.Titel = tbxRegBokTitel.Text.Trim();
            nyBok.Ämne = tbxRegBokÄmne.Text.Trim();

            using (var db = new SkolregisterEntities())
            {
                try
                {
                    db.Böcker.Add(nyBok);
                    db.SaveChanges();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    tbxRegBokTitel.Clear();
                    tbxRegBokÄmne.Clear();
                }
            }
        }

        private void btnRegKurs_Click(object sender, EventArgs e)
        {
            Kurs kurs = new Kurs();
            kurs.Kurskod = tbxRegKurskod.Text.Trim();
            kurs.Kursnamn = tbxRegKursnamn.Text.Trim();
            kurs.Poäng = int.Parse(tbxRegPoäng.Text.Trim());

            using ( var db =  new SkolregisterEntities())
            {
                try
                {
                    db.Kurser.Add(kurs);
                    db.SaveChanges();
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Error: {error.Message}");
                }
                finally
                {
                    tbxRegKurskod.Clear();
                    tbxRegKursnamn.Clear();
                    tbxRegPoäng.Clear();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valdFlik = tabControl1.SelectedTab.Text;
            if (valdFlik == "Kursval")
            {
                // Lägg in alla kurser i combobox
                using (var db = new SkolregisterEntities())
                {
                    var urval = from kurs in db.Kurser select kurs;
                    foreach (var kurs in urval)
                    {
                        cbxKurskod.Items.Add(kurs.Kurskod);
                    }
                }
            }
        }

        private void btnKursvalReg_Click(object sender, EventArgs e)
        {
            string kurskod = cbxKurskod.Text.Trim();
            string personNr = tbxKursPersonNr.Text.Trim();

            using (var db = new SkolregisterEntities())
            {
                // Leta upp eleven
                var elevUrval = from elev in db.Elever where elev.PersonNr == personNr select elev;

                // Leta upp kursen
                var kursUrval = from kurs in db.Kurser where kurs.Kurskod == kurskod select kurs;

                if (elevUrval.Count() == 1 && kursUrval.Count() == 1)
                {
                    try
                    {
                        
                        db.SaveChanges();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                    finally
                    {
                        tbxPersonNrLån.Clear();
                        tbxBokNrLån.Clear();
                        tbxLåneDatum.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Eleven eller boken finns inte");
                }
            }
        }

        private void VisaElever()
        {
            dataVy.Columns[0].HeaderText = "PersonNr";
            dataVy.Columns[1].HeaderText = "Förnamn";
            dataVy.Columns[2].HeaderText = "Efternamn";
            dataVy.Rows.Clear();

            using (var db = new SkolregisterEntities())
            {
                var urval = from elev in db.Elever select elev;
                foreach (var elev in urval)
                {
                    dataVy.Rows.Add(elev.PersonNr, elev.Förnamn, elev.Efternamn);
                }
            }
        }

        private void VisaBöcker()
        {
            dataVy.Columns[0].HeaderText = "Boknummer";
            dataVy.Columns[1].HeaderText = "Titel";
            dataVy.Columns[2].HeaderText = "Ämne";

            dataVy.Rows.Clear();

            using ( var db = new SkolregisterEntities())
            {
                var urval = from bok in db.Böcker select bok;
                foreach (var bok in urval)
                {
                    dataVy.Rows.Add(bok.BokNr, bok.Titel, bok.Ämne);
                }
            }
        }

        private void VisaKurser()
        {
            dataVy.Columns[0].HeaderText = "Kurskod";
            dataVy.Columns[1].HeaderText = "Kursnamn";
            dataVy.Columns[2].HeaderText = "Poäng";
            dataVy.Rows.Clear();

            using (var db = new SkolregisterEntities())
            {
                var urval = from kurs in db.Kurser select kurs;
                foreach (var kurs in urval)
                {
                    dataVy.Rows.Add(kurs.Kurskod, kurs.Kursnamn, kurs.Poäng);
                }
            }
        }

        private void VisaKursGrupp(string kurskod)
        {
            dataVy.Columns[0].HeaderText = "PersonNr";
            dataVy.Columns[1].HeaderText = "Förnamn";
            dataVy.Columns[2].HeaderText = "Efternamn";
            dataVy.Rows.Clear();

            using ( var db = new SkolregisterEntities())
            {
                var urval = from kurs in db.Kurser where kurs.Kursnamn == kurskod from elev in kurs.Elever select elev;

                if (urval.Count() == 0) MessageBox.Show("Kursen har inga elever");
                else
                {
                    foreach (var elev in urval)
                    {
                        dataVy.Rows.Add(elev.PersonNr, elev.Förnamn, elev.Efternamn);
                    }
                }
            }
        }

        private void UppdateraDataVy()
        {
            string valt = cbxFilter.Text;

            switch (valt)
            {
                case "Visa alla elever":
                    VisaElever();
                    break;
                case "Visa kursgrupp":
                    if (tbxFilter.Text.Length > 0)
                    {
                        VisaKursGrupp(tbxFilter.Text);
                    }
                    else
                    {
                        MessageBox.Show("Du måste fylla i kurskoden.");
                        tbxFilter.Select();
                    }
                    break;
                case "Visa alla böcker":
                    VisaBöcker();
                    break;
                case "Visa alla kurser":
                    VisaKurser();
                    break;

                default:
                    break;
            }
        }

        

    }
}

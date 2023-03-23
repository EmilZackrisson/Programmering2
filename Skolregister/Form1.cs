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
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Programmering 2\C#\Skolregister\db.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegElev_Click(object sender, EventArgs e)
        {
            Elev nyElev = new Elev(tbxPersonnummer.Text, tbxElevFörnamn.Text, tbxElevEfternamn.Text);
            string query = "INSERT INTO [Elever] (PersonNr, Förnamn, Efternamn) VALUES (@personNr, @förnamn, @efternamn);";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    try
                    {
                        cnn.Open();

                        using (SqlCommand cmd = new SqlCommand(query, cnn))
                        {

                            cmd.Parameters.AddWithValue("@personNr", nyElev.PersonNr);
                            cmd.Parameters.AddWithValue("@förnamn", nyElev.Förnamn);
                            cmd.Parameters.AddWithValue("@efternamn", nyElev.Efternamn);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"{rowsAffected} rader ändrade.");
                            }
                            else
                            {
                                MessageBox.Show("Inget ändrat");
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        // We should log the error somewhere, 
                        // for this example let's just show a message
                        MessageBox.Show("ERROR:" + ex.Message);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void UpdateGridView()
        {
            string söktext = tbxFilter.Text;
            string selected = cbxFilter.GetItemText(cbxFilter.Text);
            string query = $"SELECT * FROM [Personer]";

            switch (selected)
            {
                case "Visa alla elever":
                    query = "SELECT * FROM [Elever]";
                    break;
                case "Visa alla böcker":
                    query = "SELECT * FROM [Böcker]";
                    break;
                case "Visa alla kurser":
                    query = "SELECT * FROM [Kurser]";
                    break;
                case "Visa lediga böcker":
                    query = "SELECT * FROM [Böcker] WHERE ";
                    break;
                default:
                    break;
            }

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string personnummer = reader.GetString(0);
                        string förnamn = reader.GetString(1);
                        string efternamn = reader.GetString(2);
                        DateTime född = reader.GetDateTime(3);
                    }
                    reader.Close();
                }
            }
        }
    }
}

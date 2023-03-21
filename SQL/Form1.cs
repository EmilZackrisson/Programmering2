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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSök_Click(object sender, EventArgs e)
        {
            string söktext = textBox1.Text;
            string selected = comboBox1.GetItemText(comboBox1.Text);
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Programmering 2\C#\SQL\Kundregister.mdf;Integrated Security=True";
            string query = $"SELECT * FROM [Personer] WHERE {selected}='{söktext}'";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                lbxResultat.Items.Clear();
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

                        lbxResultat.Items.Add($"{personnummer} {förnamn} {efternamn} {född.ToString("yyyy-MM-dd")}");
                    }
                    reader.Close();
                }
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            DateTime född = dateTimePicker1.Value;
            string förnamn = tbxFörnamn.Text;
            string efternamn = tbxEfternamn.Text;
            string personnummer = tbxPersonnummer.Text;

            tbxFörnamn.Clear();
            tbxEfternamn.Clear();
            tbxPersonnummer.Clear();

            string query = $"INSERT INTO [Personer] (Personnummer, FNamn, ENamn, Född) VALUES('{personnummer}', '{förnamn}', '{efternamn}', '{född.ToString("yyyy-MM-dd")}');";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Programmering 2\C#\SQL\Kundregister.mdf;Integrated Security=True";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection to the database. 
                    // This is the first critical step in the process.
                    // If we cannot reach the db then we have connectivity problems
                    cnn.Open();

                    // Prepare the command to be executed on the db
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        // Let's ask the db to execute the query
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            MessageBox.Show($"Antal rader som berörs: {rowsAdded}");
                        else
                            // Well this should never really happen
                            MessageBox.Show("Inget insatt");

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
}

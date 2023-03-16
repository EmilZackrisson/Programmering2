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
                        int personnummer = reader.GetInt32(0);
                        string förnamn = reader.GetString(1);
                        string efternamn = reader.GetString(2);
                        DateTime född = reader.GetDateTime(3);

                        lbxResultat.Items.Add($"{personnummer} {förnamn} {efternamn} {född.ToString("yyyy-MM-dd")}");
                    }
                    reader.Close();
                }
            }
        }
    }
}

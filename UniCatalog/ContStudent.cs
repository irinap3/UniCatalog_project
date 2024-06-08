using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniCatalog
{
    public partial class ContStudent : Form
    {
        public ContStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string adminConnectionString = "server=localhost;database=admin;port=3306;username=root;password=";
        private string loginTableConnectionString = "server=localhost;database=LoginTable;port=3306;username=root;password=";

        private void genCont(string nume, string prenume, string username,string password)
        {
            try
            {
                using (MySqlConnection connectionUsers = new MySqlConnection(loginTableConnectionString))
                {
                    connectionUsers.Open();

                    // Verificăm dacă utilizatorul există deja în LoginTable.users
                    string checkQ = "SELECT COUNT(*) FROM users WHERE username = @username";
                    using (MySqlCommand check_cmd = new MySqlCommand(checkQ, connectionUsers))
                    {
                        check_cmd.Parameters.AddWithValue("@username", username);
                        int count = Convert.ToInt32(check_cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            // Dacă utilizatorul există, afișăm un mesaj
                            MessageBox.Show("Utilizatorul exista deja in baza de date!");
                        }
                        else
                        {
                            using (MySqlConnection connectionAdmin = new MySqlConnection(adminConnectionString))
                            {
                                connectionAdmin.Open();

                                // Inserăm în LoginTable.users
                                string insertQuery1 = "INSERT INTO users (username,password) VALUES (@username,@password)";
                                using (MySqlCommand insertCmd1 = new MySqlCommand(insertQuery1, connectionUsers))
                                {
                                    insertCmd1.Parameters.AddWithValue("@username", username);
                                    insertCmd1.Parameters.AddWithValue("@password", password);
                                    insertCmd1.ExecuteNonQuery();
                                }

                                // Inserăm în admin.contStudent
                                string insertQuery2 = "INSERT INTO contStudent (nume, prenume, username, password) VALUES (@nume, @prenume, @username, @password)";
                                using (MySqlCommand insertCmd2 = new MySqlCommand(insertQuery2, connectionAdmin))
                                {
                                    insertCmd2.Parameters.AddWithValue("@nume", nume);
                                    insertCmd2.Parameters.AddWithValue("@prenume", prenume);
                                    insertCmd2.Parameters.AddWithValue("@username", username);
                                    insertCmd2.Parameters.AddWithValue("@password", password);
                                    insertCmd2.ExecuteNonQuery();
                                }

                                MessageBox.Show("Utilizatorul a fost adăugat cu succes!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox2.Text;
            string prenume = textBox3.Text;
            string username = textBox4.Text;
            string password = textBox1.Text;
            genCont(nume, prenume, username, password);
        }
    }
}


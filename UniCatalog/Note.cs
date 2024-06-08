using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UniCatalog
{
    public partial class Note : Form
    {
        private string username;
        public Note(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadUserData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }
        private void LoadUserData()
        {
            try
            {
                // Conexiune la baza de date studenti
                using (MySqlConnection connectionStud = new MySqlConnection("server=localhost;database=LoginTable;port=3306;username=root;password="))
                {
                    connectionStud.Open();

                    // Conexiune la baza de date profesori
                    using (MySqlConnection connectionProf = new MySqlConnection("server=localhost;database=profesori;port=3306;username=root;password="))
                    {
                        connectionProf.Open();

                        // Selectăm notele din adaugareNote
                        string query = "SELECT user_id, materie, nota FROM adaugareNote";
                        using (MySqlCommand cmd = new MySqlCommand(query, connectionProf))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int userId = reader.GetInt32("user_id");
                                string materie = reader.GetString("materie");
                                float nota = reader.GetFloat("nota");

                                // Verificăm dacă nota există deja în studenti.note
                                string checkQ = "SELECT COUNT(*) FROM note WHERE user_id = @user_id AND materie = @materie";
                                using (MySqlCommand check_cmd = new MySqlCommand(checkQ, connectionStud))
                                {
                                    check_cmd.Parameters.AddWithValue("@user_id", userId);
                                    check_cmd.Parameters.AddWithValue("@materie", materie);
                                    int count = Convert.ToInt32(check_cmd.ExecuteScalar());

                                    if (count > 0)
                                    {
                                        // Dacă nota există, facem UPDATE
                                        string updateQuery = "UPDATE note SET nota = @nota WHERE user_id = @user_id AND materie = @materie";
                                        using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connectionStud))
                                        {
                                            updateCmd.Parameters.AddWithValue("@nota", nota);
                                            updateCmd.Parameters.AddWithValue("@user_id", userId);
                                            updateCmd.Parameters.AddWithValue("@materie", materie);
                                            updateCmd.ExecuteNonQuery();
                                        }
                                    }
                                    else
                                    {
                                        // Dacă nota nu există, facem INSERT
                                        string insertQuery = "INSERT INTO note (user_id, materie, nota) VALUES (@user_id, @materie, @nota)";
                                        using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connectionStud))
                                        {
                                            insertCmd.Parameters.AddWithValue("@user_id", userId);
                                            insertCmd.Parameters.AddWithValue("@materie", materie);
                                            insertCmd.Parameters.AddWithValue("@nota", nota);
                                            insertCmd.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }

                        // Actualizează DataGridView după sincronizare
                        string selectUpdatedQuery = "SELECT note.materie, note.nota FROM note " +
                                                    "JOIN users ON note.user_id = users.id " +
                                                    "WHERE users.username = @username";
                        using (MySqlCommand cmd = new MySqlCommand(selectUpdatedQuery, connectionStud))
                        {
                            cmd.Parameters.AddWithValue("@username", username); // Asigură-te că variabila `username` este definită și corectă
                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }

                        connectionStud.Close();
                        connectionProf.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Note_Load(object sender, EventArgs e)
        {

        }
    }
}

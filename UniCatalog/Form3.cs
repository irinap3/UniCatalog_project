using MySql.Data.MySqlClient;
using System.Data;

namespace UniCatalog
{
    public partial class Form3 : Form
    {
        private string username;
        MySqlConnection connection = new MySqlConnection("server=localhost;database=profesori;port=3306;username=root;password=");


        public Form3(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadTeacherDetails();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void LoadTeacherDetails()
        {
            try
            {
                connection.Open();
                string query = "SELECT  td.nume, td.prenume, td.titlu, td.post FROM profesori.teacher_details td JOIN logintable.users u ON td.username = u.username WHERE u.username = @username ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    numeProf.Text = reader["nume"].ToString();
                    prenumeProf.Text = reader["prenume"].ToString();
                    titluProf.Text = reader["titlu"].ToString();
                    postProf.Text = reader["post"].ToString();
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error." + ex.Message);
            }
        }

        private void detaliiPersonaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;


        }


        private void cursuriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void roboticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            label6.Text = "Cursuri - Robotica";
            try
            {
                connection.Open();
                string query2 = "SELECT robotica.nume_curs, robotica.numar_ore FROM robotica " +
                               "WHERE robotica.username = @username";
                MySqlCommand cmd = new MySqlCommand(query2, connection);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["nume_curs"].HeaderText = "Nume curs";
                dataGridView1.Columns["numar_ore"].HeaderText = "Numar de ore";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void eTTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            label6.Text = "Cursuri - Tehnologia\n Informatiei";
            try
            {
                connection.Open();
                string query3 = "SELECT ti.nume_curs, ti.numar_ore FROM ti " +
                               "WHERE ti.username = @username";
                MySqlCommand cmd = new MySqlCommand(query3, connection);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["nume_curs"].HeaderText = "Nume curs";
                dataGridView1.Columns["numar_ore"].HeaderText = "Numar de ore";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void automaticaSiCalculatoareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            label6.Text = "Cursuri - \n Automatica \n si Calculatoare";
            try
            {
                connection.Open();
                string query3 = "SELECT calculatoare.nume_curs, calculatoare.numar_ore FROM calculatoare " +
                               "WHERE calculatoare.username = @username";
                MySqlCommand cmd = new MySqlCommand(query3, connection);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["nume_curs"].HeaderText = "Nume curs";
                dataGridView1.Columns["numar_ore"].HeaderText = "Numar de ore";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void roboticaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            label6.Text = "Cursuri - ETTI";
            try
            {
                connection.Open();
                string query3 = "SELECT etti.nume_curs, etti.numar_ore FROM etti " +
                               "WHERE etti.username = @username";
                MySqlCommand cmd = new MySqlCommand(query3, connection);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["nume_curs"].HeaderText = "Nume curs";
                dataGridView1.Columns["numar_ore"].HeaderText = "Numar de ore";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void programeDeStudiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 grades = new Form4();
            grades.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }
    }
}

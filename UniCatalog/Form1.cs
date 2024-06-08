using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace UniCatalog
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=LoginTable;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader dr;
        private string username;
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_username.Text) || string.IsNullOrEmpty(tb_password.Text))
                {
                    MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connection.Open();
                string selectQuery = "SELECT * FROM users WHERE username = @username AND password = @password";
                command = new MySqlCommand(selectQuery, connection);
                username = tb_username.Text;
                string password = tb_password.Text;
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                dr = command.ExecuteReader();

                if (dr.Read())
                { 
                    btnSt.Visible = true;
                    btnProf.Visible = true;
                    btnAd.Visible = true;
                    panel1.Visible = false;
                }
                else
                {
                    using (MySqlConnection connection = new MySqlConnection("server=localhost;database=LoginTable;port=3306;username=root;password="))
                    {
                        connection.Open();
                        string checkQ = "SELECT COUNT(*) FROM users WHERE username = @username";
                        using (MySqlCommand check_cmd = new MySqlCommand(checkQ, connection))
                        {
                            check_cmd.Parameters.AddWithValue("@username", username);
                            int count = Convert.ToInt32(check_cmd.ExecuteScalar());

                            if (count == 0)
                            {
                                MessageBox.Show("Nu esti membru UNITBV!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("E-mail sau parola invalide!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 studentMenuForm = new Form2(username);
            studentMenuForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            Form3 teacherMenuForm = new Form3(username);
            teacherMenuForm.Show();
        }
    }
}

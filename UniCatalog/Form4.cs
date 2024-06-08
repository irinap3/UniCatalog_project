using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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

namespace UniCatalog
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=profesori;port=3306;username=root;password=");
            MySqlCommand cmd = new MySqlCommand("INSERT INTO adaugareNote(user_id, nume, prenume, specializare, grupa, materie, nota) VALUES(@id, @nume, @prenume, @specializare, @grupa, @materie, @nota)", connection);
            connection.Open();
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@nume", textBox2.Text);
            cmd.Parameters.AddWithValue("@prenume", textBox3.Text);
            cmd.Parameters.AddWithValue("@specializare", textBox4.Text);
            cmd.Parameters.AddWithValue("@grupa", textBox5.Text);
            cmd.Parameters.AddWithValue("@materie", textBox7.Text);
            cmd.Parameters.AddWithValue("@nota", int.Parse(textBox6.Text));
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Nota adaugata cu succes!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=profesori;port=3306;username=root;password=");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE adaugareNote SET id = @id , nume = @nume, prenume= @prenume,specializare=@specializare ,grupa=@grupa,materie=@materie,nota=@nota", connection);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@nume", textBox2.Text);
            cmd.Parameters.AddWithValue("@prenume", textBox3.Text);
            cmd.Parameters.AddWithValue("@specializare", textBox4.Text);
            cmd.Parameters.AddWithValue("@grupa", textBox5.Text);
            cmd.Parameters.AddWithValue("@materie", textBox7.Text);
            cmd.Parameters.AddWithValue("@nota", int.Parse(textBox6.Text));
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Inregistrarea a fost modificata cu succes!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=profesori;port=3306;username=root;password=");
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM adaugareNote WHERE id=@id ", connection);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Inregistrare stearsa cu succes!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=profesori;port=3306;username=root;password=");
            MySqlCommand cmd = new MySqlCommand("SELECT nume,prenume,specializare,grupa,materie,nota FROM adaugareNote", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}

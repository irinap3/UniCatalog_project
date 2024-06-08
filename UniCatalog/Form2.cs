using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace UniCatalog
{
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=LoginTable;port=3306;username=root;password=");
        MySqlDataAdapter adapter;
        DataTable table;
        private string username;
        public Form2(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadStudentDetails();

        }

        private void LoadStudentDetails()
        {
            try
            {
                connection.Open();
                string query = "SELECT nume, prenume, data_inscriere,init_tatalui, facultate, specializare, grupa FROM studentdetails WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lNume.Text = reader["nume"].ToString();
                    lPren.Text = reader["prenume"].ToString();
                    lDataInsc.Text = reader["data_inscriere"].ToString();
                    lInitTata.Text = reader["init_tatalui"].ToString();
                    lFacultate.Text = reader["facultate"].ToString();
                    lProgrStudii.Text = reader["specializare"].ToString();
                    lGrupa.Text = reader["grupa"].ToString();
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error." + ex.Message);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void detaliiStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pDetails.Visible = true;
        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note noteForm = new Note(username);
            noteForm.Show();
        }

        private void pDetails_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadFees()
        {
            try
            {
                connection.Open();
                string query2 = "SELECT * FROM taxe WHERE student_id = (SELECT id FROM users WHERE username = @username) AND paid = FALSE";
                MySqlCommand cmd = new MySqlCommand(query2, connection);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable feesTable = new DataTable();
                adapter.Fill(feesTable);
                if (feesTable.Rows.Count > 0)
                {
                    Taxe feesForm = new Taxe(feesTable);
                    feesForm.Show();
                }
                else
                {
                    MessageBox.Show("Nicio taxa de platit!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void caminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void taxeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFees();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lNume_Click(object sender, EventArgs e)
        {

        }
    }
}

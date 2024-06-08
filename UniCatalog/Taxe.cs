using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniCatalog
{
    public partial class Taxe : Form
    {
        public Taxe(DataTable feesTable)
        {
            InitializeComponent();
            dataGridView1.DataSource = feesTable;
            FormatDataGridView();

        }

        private void FormatDataGridView()
        {
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["student_id"].Visible = false;
            dataGridView1.Columns["suma"].HeaderText = "Suma";
            dataGridView1.Columns["tip_taxa"].HeaderText = "Tip de taxa";
            dataGridView1.Columns["due_date"].HeaderText = "Termen de plata";
            dataGridView1.Columns["paid"].HeaderText = "Achitat";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

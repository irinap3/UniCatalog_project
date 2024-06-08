using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace UniCatalog
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContStudent cont = new ContStudent();
            cont.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContProf cont = new ContProf();
            cont.Show();
        }

        private string MapFacultate(string facultate)
        {
            switch (facultate.ToLower())
            {
                case "fmi":
                    return "1";
                case "seea":
                    return "2";
                case "fim":
                    return "3";
                case "iesc":
                    return "4";
                default:
                    throw new ArgumentException("Facultatea necunoscută: " + facultate);
            }
        }

        private string MapProgramDeStudii(string specializare)
        {
            switch (specializare.ToLower())
            {
                case "robotica":
                    return "1";
                case "etti":
                    return "2";
                case "ti":
                    return "3";
                case "aia":
                    return "4";
                default:
                    throw new ArgumentException("Specializarea necunoscută: " + specializare);
            }
        }

        private string MapNivelDeStudiu(string nivel)
        {
            switch (nivel.ToLower())
            {
                case "licenta":
                    return "L";
                case "master":
                    return "M";
                default:
                    throw new ArgumentException("Nivel de studiu necunoscut: " + nivel);
            }
        }

        private string FormeazaCodificare(string nume, string specializare, string facultate, int anStudiu, string nivelDeStudiu, int grupa)
        {
            string codFacultate = MapFacultate(facultate);
            string codProgram = MapProgramDeStudii(specializare);
            string codNivel = MapNivelDeStudiu(nivelDeStudiu);
            string ultimaCifraAn = anStudiu.ToString().Substring(3, 1);
            string codGrupa = grupa.ToString();

            string codificare = $"{codFacultate}{codNivel}{codProgram}{ultimaCifraAn}{codGrupa}";
            return codificare;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            openFileDialog1.Title = "Select an Excel File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWorkbook = null;
                Excel._Worksheet excelWorksheet = null;
                Excel.Range excelRange = null;

                try
                {
                    excelWorkbook = excelApp.Workbooks.Open(filePath);
                    excelWorksheet = (Excel._Worksheet)excelWorkbook.Sheets[1];
                    excelRange = excelWorksheet.UsedRange;

                    int rowCount = excelRange.Rows.Count;
                    int colCount = excelRange.Columns.Count;

                    // Verifică dacă există cel puțin 6 coloane
                    if (colCount < 6)
                    {
                        MessageBox.Show("Fișierul Excel nu are suficiente coloane.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    for (int i = 2; i <= rowCount; i++) // Pornim de la 2 pentru a sări peste header
                    {
                        string nume = Convert.ToString((excelRange.Cells[i, 1] as Excel.Range).Value2);
                        string specializare = Convert.ToString((excelRange.Cells[i, 2] as Excel.Range).Value2);
                        string facultate = Convert.ToString((excelRange.Cells[i, 3] as Excel.Range).Value2);
                        int anStudiu = Convert.ToInt32((excelRange.Cells[i, 4] as Excel.Range).Value2);
                        string nivelDeStudiu = Convert.ToString((excelRange.Cells[i, 5] as Excel.Range).Value2);
                        int grupa = i % 3 + 1; // Exemplu simplu de asignare a grupei

                        // Verifică pentru valori null sau invalide
                        if (string.IsNullOrWhiteSpace(nume) || string.IsNullOrWhiteSpace(specializare) ||
                            string.IsNullOrWhiteSpace(facultate) || string.IsNullOrWhiteSpace(nivelDeStudiu) || anStudiu <= 0)
                        {
                            MessageBox.Show($"Rândul {i} are date invalide sau lipsă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        string codificare = FormeazaCodificare(nume, specializare, facultate, anStudiu, nivelDeStudiu, grupa);

                        // Salvează codificarea înapoi în fișierul Excel
                        (excelRange.Cells[i, 6] as Excel.Range).Value2 = codificare;
                    }

                    excelWorkbook.Save();
                    MessageBox.Show("Grupele au fost formate cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare: " + ex.Message);
                }
                finally
                {
                    // Închidere workbook și eliberare resurse COM
                    if (excelWorkbook != null) excelWorkbook.Close(false);
                    if (excelApp != null) excelApp.Quit();

                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelRange);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorksheet);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_Presentacion
{
    public partial class Reports : Form
    {
        public string _Usuario;
        public Reports(string loggedUser)
        {
            InitializeComponent();
            _Usuario = loggedUser;
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn cargar = new LogIn();
            cargar.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu cargar = new mainMenu(_Usuario);
            cargar.ShowDialog();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings cargar = new Settings(_Usuario);
            cargar.ShowDialog();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datSistema1.facturas' table. You can move, or remove it, as needed.
            this.facturasTableAdapter.Fill(this.datSistema1.facturas);
            // TODO: This line of code loads data into the 'datSistema.facturas' table. You can move, or remove it, as needed.
            this.facturasTableAdapter.Fill(this.datSistema.facturas);

        }

        private void button1_Click(object sender, EventArgs e)
        {

                if (datalistadoarticulos.Rows.Count > 0)

                {

                    SaveFileDialog save = new SaveFileDialog();

                    save.Filter = "PDF (*.pdf)|*.pdf";

                    save.FileName = "ReporteDeVentas.pdf";

                    bool ErrorMessage = false;

                    if (save.ShowDialog() == DialogResult.OK)

                    {

                        if (File.Exists(save.FileName))

                        {

                            try

                            {

                                File.Delete(save.FileName);

                            }

                            catch (Exception ex)

                            {

                                ErrorMessage = true;

                                MessageBox.Show("Unable to wride data in disk" + ex.Message);

                            }

                        }

                        if (!ErrorMessage)

                        {

                            try

                            {

                                PdfPTable pTable = new PdfPTable(datalistadoarticulos.Columns.Count);

                                pTable.DefaultCell.Padding = 2;

                                pTable.WidthPercentage = 100;

                                pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                                foreach (DataGridViewColumn col in datalistadoarticulos.Columns)

                                {

                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                    pTable.AddCell(pCell);

                                }

                                foreach (DataGridViewRow viewRow in datalistadoarticulos.Rows)

                                {

                                    foreach (DataGridViewCell dcell in viewRow.Cells)

                                    {

                                        pTable.AddCell(dcell.Value.ToString());

                                    }

                                }

                                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                                {

                                    Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                    PdfWriter.GetInstance(document, fileStream);

                                    document.Open();

                                    document.Add(pTable);

                                    document.Close();

                                    fileStream.Close();

                                }

                                MessageBox.Show("Data Export Successfully", "info");

                            }

                            catch (Exception ex)

                            {

                                MessageBox.Show("Error while exporting Data" + ex.Message);

                            }

                        }

                    }

                }

                else

                {

                    MessageBox.Show("No Record Found", "Info");

                }
        }
    }
}

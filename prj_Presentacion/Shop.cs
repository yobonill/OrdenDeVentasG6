using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prj_Logica;
using Prj_Datos;

namespace prj_Presentacion
{
    public partial class Shop : Form
    {
        public string _Usuario;
        public int contador = 1;
        //DatPersonal ds = new DatPersonal();
        DatSistema ds = new DatSistema();
        DatSistemaTableAdapters.articuloTableAdapter consulta = new DatSistemaTableAdapters.articuloTableAdapter();
        public Shop(string loggedUser)
        {
            InitializeComponent();
            _Usuario = loggedUser;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu cargar = new mainMenu(_Usuario);
            cargar.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn cargar = new LogIn();
            cargar.ShowDialog();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings cargar = new Settings(_Usuario);
            cargar.ShowDialog();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            try
            {
                consulta.Fill(ds.articulo);
                CbArticulos.DataSource = ds.articulo;
                CbArticulos.DisplayMember = "nombre";
                CbArticulos.ValueMember = "idarticulo";

                // Bind the SelectedValueChanged event to our handler for it.
                CbArticulos.SelectedValueChanged +=
                    new EventHandler(CbArticulos_SelectedValueChanged);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CbArticulos_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (CbArticulos.SelectedIndex != -1)
                {
                    //txt_cantidad.Text = CbArticulos.SelectedValue.ToString();
                    //cantidad.Maximum = Convert.ToInt16(CbArticulos.SelectedValue);

                    RecordArticulos Rec2 = new RecordArticulos(Convert.ToInt16(CbArticulos.SelectedValue), 0);

                    txt_cantidad.Text = Rec2.STOCK1.ToString();
                    cantidad.Maximum = Convert.ToInt16(Rec2.STOCK1);
                    // If we also wanted to get the displayed text we could use
                    // the SelectedItem item property:
                    // string s = ((USState)ListBox1.SelectedItem).LongName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //RecordArticulos Rec2 = new RecordArticulos(Convert.ToInt16(CbArticulos.SelectedValue), 0);
        }
    }
}

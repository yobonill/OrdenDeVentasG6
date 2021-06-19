using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // TODO: This line of code loads data into the 'datSistema.facturas' table. You can move, or remove it, as needed.
            this.facturasTableAdapter.Fill(this.datSistema.facturas);

        }
    }
}

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
    public partial class SettingsUser : Form
    {
        public string _Usuario;
        public SettingsUser(string loggedUser)
        {
            InitializeComponent();
            _Usuario = loggedUser;
        }

        private void BtImprimir_Click(object sender, EventArgs e)
        {

        }

        private void BtEditar_Click_1(object sender, EventArgs e)
        {

        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings cargar = new Settings(_Usuario);
            cargar.ShowDialog();
        }

        private void SettingsUser_Load(object sender, EventArgs e)
        {

        }
    }
}

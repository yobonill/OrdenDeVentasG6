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
    public partial class SettingsPersonas : Form
    {
        public string _Usuario;
        public SettingsPersonas(string loggedUser)
        {
            InitializeComponent();
            _Usuario = loggedUser;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings cargar = new Settings(_Usuario);
            cargar.ShowDialog();
        }

        private void SettingsPersonas_Load(object sender, EventArgs e)
        {

        }
    }
}

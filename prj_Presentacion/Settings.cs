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
    public partial class Settings : Form
    {
        public string _Usuario;
        public Settings(string loggedUser)
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

        private void usersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsUser cargar = new SettingsUser(_Usuario);
            cargar.ShowDialog();
        }

        private void BtnArticle_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsArticles cargar = new SettingsArticles(_Usuario);
            cargar.ShowDialog();
        }

        private void BtnPerson_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsPersonas cargar = new SettingsPersonas(_Usuario);
            cargar.ShowDialog();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}

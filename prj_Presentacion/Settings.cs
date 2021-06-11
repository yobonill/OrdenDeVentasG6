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
        public Settings()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu cargar = new mainMenu();
            cargar.ShowDialog();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsUser cargar = new SettingsUser();
            cargar.ShowDialog();
        }

        private void BtnArticle_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsArticles cargar = new SettingsArticles();
            cargar.ShowDialog();
        }

        private void BtnPerson_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsPersonas cargar = new SettingsPersonas();
            cargar.ShowDialog();
        }
    }
}

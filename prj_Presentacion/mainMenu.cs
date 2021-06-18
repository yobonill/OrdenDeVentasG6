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
    public partial class mainMenu : Form
    {
        public string _Usuario;
        public mainMenu(string loggedUser)
        {
            InitializeComponent();
            _Usuario = loggedUser;
        }
        private void mainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shop cargar = new Shop(_Usuario);
            cargar.ShowDialog();
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports cargar = new Reports(_Usuario);
            cargar.ShowDialog();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings cargar = new Settings(_Usuario);
            cargar.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn cargar = new LogIn();
            cargar.ShowDialog();
        }
    }
}

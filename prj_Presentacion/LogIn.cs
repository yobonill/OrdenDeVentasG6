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

namespace prj_Presentacion
{
    public partial class LogIn : Form
    {
        public int counter = 1;
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void pass_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            NE_Usuario Reg = new NE_Usuario();
            bool exist = false;

            exist = Reg.VerificarAutenticacion(tb_user.Text, tb_pass.Text);

            if (exist)
            {
                this.Hide();
                mainMenu cargar = new mainMenu();
                cargar.ShowDialog();
                //Application.Exit();
            }
            else
            {
                if (counter == 3)
                {
                    MessageBox.Show("Cantidad de oportunidades sobrepasadas" + counter.ToString());
                    Application.Exit();
                }
                MessageBox.Show("Usuario/Clave incorrectos");
                counter++;
            }
        }
    }
}

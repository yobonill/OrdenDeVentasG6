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
    public partial class SettingsUser : Form
    {
        DataSet DSQL = new DataSet();
        public string _Usuario;
        public SettingsUser()
        {
            InitializeComponent();
        }

        public SettingsUser(string usuario)
        {
            InitializeComponent();
            _Usuario = usuario;
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
            NE_Usuario eld = new NE_Usuario();
            try
            {
                datalistadousuarios.Refresh();

                string parametro = "";
                int VARIABLE = 0;
                DSQL.Clear();
                //error
                if (TxtCedula.Text != "")
                {
                    if (VARIABLE != 1)
                    {
                        parametro = " num_documento LIKE '%" + TxtCedula.Text + "%'";
                    }
                    else
                    {
                        parametro = parametro + " AND num_documento LIKE '%" + TxtCedula.Text + "%'";
                    }
                    VARIABLE = 1;
                }
                //error
                if (TxtTelefono.Text != "")
                {
                    if (VARIABLE != 1)
                    {
                        parametro = " telefono LIKE '%" + TxtTelefono.Text + "%'";
                    }
                    else
                    {
                        parametro = parametro + " AND telefono  LIKE '%" + TxtTelefono.Text + "%'";
                    }
                    VARIABLE = 1;
                }

                if (TxtCorreo.Text != "")
                {
                    if (VARIABLE != 1)
                    {
                        parametro = " email LIKE '%" + TxtCorreo.Text + "%'";
                    }
                    else
                    {
                        parametro = parametro + " AND email LIKE '%" + TxtCorreo.Text + "%'";
                    }
                    VARIABLE = 1;
                }


                string SQL = "SELECT idusuario,idrol,usuario,password,num_documento,direccion,telefono,email,estado FROM dbo.usuario";

                if (VARIABLE == 1)
                {
                    parametro = SQL + " WHERE " + parametro;
                }
                else
                {
                    parametro = SQL;
                }

                DSQL = eld.RN_Buscar_RecordUsuario(parametro);
                datalistadousuarios.AutoGenerateColumns = false;

                datalistadousuarios.DataSource = DSQL;

                datalistadousuarios.DataMember = "VerRecord";
                Lbltotal.Visible = true;
                Lbltotal.Text = DSQL.Tables["VerRecord"].Rows.Count.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(TxtCedula, TxtCorreo, TxtTelefono);
            TxtCedula.Focus();
            
            //Cargar los Registros de los Clientes
            MostrarTodoslosRegistrosCargadosUsuarios();
        }
        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();

            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                MantUsuario cargar = new MantUsuario("0", "Creando Registro");
                cargar.ShowDialog();

                MostrarTodoslosRegistrosCargadosUsuarios();  //Usuarios
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                SelectToEditItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Información del Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void SelectToEditItem()
        {
            try
            {
                int fila = datalistadousuarios.CurrentRow.Index;

                if (datalistadousuarios.Rows.Count != 0)
                {
                    string id = Convert.ToInt32(datalistadousuarios.Rows[fila].Cells[0].Value).ToString();

                    MantUsuario cat = new MantUsuario(id, "Actualizando Registro");
                    cat.StartPosition = FormStartPosition.CenterScreen;
                    cat.ShowInTaskbar = false;
                    cat.ShowDialog();
                    //Refrescar Datagridview, cuando retorne
                    MostrarTodoslosRegistrosCargadosUsuarios();  //Clientes
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista de Usuarios",
                        "Información del Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Información del Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Roles cargar = new Roles();
            cargar.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings cargar = new Settings();
            cargar.ShowDialog();
        }

        private void SettingsUser_Load(object sender, EventArgs e)
        {
            //Cargar los registros de usuario
            MostrarTodoslosRegistrosCargadosUsuarios();

            LblUsuario.Text = "Usuario Actual:   " + _Usuario;

            
            try
            {
                this.Text = "Configuracion de Usuarios (Grupo 6)" + Espacio(160);
                TmrMensaje.Enabled = true;

                DateTime hoy = DateTime.Now;
                LblFecha.Text = hoy.ToString("dddd, dd MMMM yyyy");

                TmrHora.Enabled = true;

                //DataTable DtMenu = new DataTable();
                //DataTable DtSubMenu = new DataTable();
                //NE_Menu nm = new NE_Menu();
                //NE_Submenu ns = new NE_Submenu();

                //DtMenu = nm.MostrarMenu();
                //DtSubMenu = ns.MostrarSubMenu();

                //CreateMenu(DtMenu, DtSubMenu);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void TmrHora_Tick_1(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("hh:mm");
        }
        public static string Espacio(int n)
        {
            string s = " ";
            for (int i = 0; i <= n; i++) s += " ";
            return s;
        }
        private void MostrarTodoslosRegistrosCargadosUsuarios()
        {
            try
            {
                NE_Usuario Obj = new NE_Usuario();
                DSQL = Obj.VerTodosLosUsuarios();
                
                datalistadousuarios.AutoGenerateColumns = false;
                
                SetupColumnsCargadasUsuarios(DSQL);
                
                datalistadousuarios.DataSource = DSQL;
                
                datalistadousuarios.DataMember = "VerRecord";
                Lbltotal.Visible = true;
                Lbltotal.Text = DSQL.Tables["VerRecord"].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetupColumnsCargadasUsuarios(DataSet ds)
        {
            datalistadousuarios.Columns.Clear();
            
            datalistadousuarios.ScrollBars = ScrollBars.Both;
            
            datalistadousuarios.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            // Set the background color for all rows and for alternating rows.  
            // The value for alternating rows overrides the value for all rows. 
            datalistadousuarios.RowsDefaultCellStyle.BackColor = Color.White;
            datalistadousuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            
            // Set the row and column header styles.
            datalistadousuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datalistadousuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            datalistadousuarios.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            
            DataGridViewTextBoxColumn idusuarioColumn = new DataGridViewTextBoxColumn();
            idusuarioColumn.DataPropertyName = "idusuario";
            idusuarioColumn.Width = 40;
            idusuarioColumn.HeaderText = "ID #";
            idusuarioColumn.Frozen = true;
            idusuarioColumn.ValueType = typeof(string);
            datalistadousuarios.Columns.Add(idusuarioColumn);
            
            DataGridViewTextBoxColumn idrolColumn = new DataGridViewTextBoxColumn();
            idrolColumn.DataPropertyName = "idrol";
            idrolColumn.Width = 40;
            idrolColumn.HeaderText = "idrol";
            idrolColumn.Frozen = true;
            idrolColumn.ValueType = typeof(string);
            datalistadousuarios.Columns.Add(idrolColumn);
            
            DataGridViewTextBoxColumn usuarioColumn = new DataGridViewTextBoxColumn();
            usuarioColumn.DataPropertyName = "usuario";
            usuarioColumn.Width = 150;
            usuarioColumn.HeaderText = "Usuario";
            usuarioColumn.Frozen = true;
            usuarioColumn.ValueType = typeof(string);
            datalistadousuarios.Columns.Add(usuarioColumn);
            
            DataGridViewTextBoxColumn passwordColumn = new DataGridViewTextBoxColumn();
            passwordColumn.DataPropertyName = "password";
            passwordColumn.Width = 100;
            passwordColumn.HeaderText = "Contraseña";
            passwordColumn.Frozen = true;
            passwordColumn.ValueType = typeof(string);
            passwordColumn.Visible = false;
            datalistadousuarios.Columns.Add(passwordColumn);
            
            DataGridViewTextBoxColumn num_documentoColumn = new DataGridViewTextBoxColumn();
            num_documentoColumn.DataPropertyName = "num_documento";
            num_documentoColumn.Width = 120;
            num_documentoColumn.HeaderText = "No. de documento";
            num_documentoColumn.Frozen = true;
            num_documentoColumn.ValueType = typeof(string);
            datalistadousuarios.Columns.Add(num_documentoColumn);
            
            DataGridViewTextBoxColumn direccionColumn = new DataGridViewTextBoxColumn();
            direccionColumn.DataPropertyName = "direccion";
            direccionColumn.Width = 200;
            direccionColumn.HeaderText = "Dirección";
            direccionColumn.Frozen = true;
            direccionColumn.ValueType = typeof(string);
            datalistadousuarios.Columns.Add(direccionColumn);
            
            DataGridViewTextBoxColumn telefonoColumn = new DataGridViewTextBoxColumn();
            telefonoColumn.DataPropertyName = "telefono";
            telefonoColumn.Width = 100;
            telefonoColumn.HeaderText = "Telefono";
            telefonoColumn.Frozen = true;
            telefonoColumn.ValueType = typeof(string);
            datalistadousuarios.Columns.Add(telefonoColumn);
            
            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName = "email";
            emailColumn.Width = 150;
            emailColumn.HeaderText = "Email";
            emailColumn.Frozen = true;
            emailColumn.ValueType = typeof(string);
            datalistadousuarios.Columns.Add(emailColumn);
            
            DataGridViewCheckBoxColumn EstatusColumn = new DataGridViewCheckBoxColumn();
            EstatusColumn.DataPropertyName = "estado";
            EstatusColumn.Width = 57;
            EstatusColumn.HeaderText = "Estado";
            EstatusColumn.Frozen = true;
            EstatusColumn.ValueType = typeof(Boolean);
            datalistadousuarios.Columns.Add(EstatusColumn);
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn cargar = new LogIn();
            cargar.ShowDialog();
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    BtnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    BtnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    BtnBuscar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datalistadousuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectToEditItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Tmr2click.Stop();
            label9.Visible = false;
        }

        private void Tmr2click_Tick(object sender, EventArgs e)
        {
            if (label9.Visible == true)
            {
                label9.Visible = false;
            }
            else
            {
                label9.Visible = true;
            }
        }

        private void TmrMensaje_Tick_1(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }
    }
}


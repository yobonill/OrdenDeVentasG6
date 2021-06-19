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
    public partial class SettingsPersonas : Form
    {
        DataSet DSQL = new DataSet();
        public string _Usuario;
        public SettingsPersonas()
        {
            InitializeComponent();
        }

        public  SettingsPersonas(string usuario)
        {
            InitializeComponent();
            _Usuario = usuario;
        }

        protected void SelectToEditItem()
        {
            try
            {
                int fila = datalistadopersona.CurrentRow.Index;

                if (datalistadopersona.Rows.Count != 0)
                {
                    string id = Convert.ToInt32(datalistadopersona.Rows[fila].Cells[0].Value).ToString();

                    MantPersona cat = new MantPersona(id, "Actualizando Registro");
                    cat.StartPosition = FormStartPosition.CenterScreen;
                    cat.ShowInTaskbar = false;
                    cat.ShowDialog();
                    //Refrescar Datagridview, cuando retorne
                    MostrarTodoslosRegistrosCargadospersona();  //Clientes
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista de Roles",
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings cargar = new Settings();
            cargar.ShowDialog();
        }

        private void SettingsPersonas_Load(object sender, EventArgs e)
        {
            //Cargar los registros de persona
            MostrarTodoslosRegistrosCargadospersona();

            //LblUsuario.Text = "Usuario Actual:   " + _Usuario;


            try
            {
                this.Text = "Configuracion de Personas (Grupo 6)" + Espacio(160);
                tmrMensaje.Enabled = true;

                DateTime hoy = DateTime.Now;
                LblFecha.Text = hoy.ToString("dddd, dd MMMM yyyy");

                tmrHora.Enabled = true;

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

        private void MostrarTodoslosRegistrosCargadospersona()
        {
            try
            {
                NE_Persona Obj = new NE_Persona();
                DSQL = Obj.VerTodosLospersona();

                datalistadopersona.AutoGenerateColumns = false;

                SetupColumnsCargadaspersona(DSQL);

                datalistadopersona.DataSource = DSQL;

                datalistadopersona.DataMember = "VerRecord";
                LblTotal.Visible = true;
                LblTotal.Text = DSQL.Tables["VerRecord"].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetupColumnsCargadaspersona(DataSet ds)
        {
            datalistadopersona.Columns.Clear();

            datalistadopersona.ScrollBars = ScrollBars.Both;

            datalistadopersona.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            // Set the background color for all rows and for alternating rows.  
            // The value for alternating rows overrides the value for all rows. 
            datalistadopersona.RowsDefaultCellStyle.BackColor = Color.White;
            datalistadopersona.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Set the row and column header styles.
            datalistadopersona.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datalistadopersona.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            datalistadopersona.RowHeadersDefaultCellStyle.BackColor = Color.Black;

            DataGridViewTextBoxColumn idpersonaColumn = new DataGridViewTextBoxColumn();
            idpersonaColumn.DataPropertyName = "idpersona";
            idpersonaColumn.Width = 50;
            idpersonaColumn.HeaderText = "Id #";
            idpersonaColumn.Frozen = true;
            idpersonaColumn.ValueType = typeof(string);
            datalistadopersona.Columns.Add(idpersonaColumn);

            DataGridViewTextBoxColumn tipopColumn = new DataGridViewTextBoxColumn();
            tipopColumn.DataPropertyName = "tipo_persona";
            tipopColumn.Width = 75;
            tipopColumn.HeaderText = "tipo_persona";
            tipopColumn.Frozen = true;
            tipopColumn.ValueType = typeof(string);
            datalistadopersona.Columns.Add(tipopColumn);

            DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
            nombreColumn.DataPropertyName = "nombre";
            nombreColumn.Width = 150;
            nombreColumn.HeaderText = "nombre";
            nombreColumn.Frozen = true;
            nombreColumn.ValueType = typeof(string);
            datalistadopersona.Columns.Add(nombreColumn);

            DataGridViewTextBoxColumn tipodColumn = new DataGridViewTextBoxColumn();
            tipodColumn.DataPropertyName = "tipo_documento";
            tipodColumn.Width = 88;
            tipodColumn.HeaderText = "tipo_documento";
            tipodColumn.Frozen = true;
            tipodColumn.ValueType = typeof(string);
            datalistadopersona.Columns.Add(tipodColumn);

            DataGridViewTextBoxColumn num_documentoColumn = new DataGridViewTextBoxColumn();
            num_documentoColumn.DataPropertyName = "num_documento";
            num_documentoColumn.Width = 100;
            num_documentoColumn.HeaderText = "num_documento";
            num_documentoColumn.Frozen = true;
            num_documentoColumn.ValueType = typeof(string);
            datalistadopersona.Columns.Add(num_documentoColumn);

            DataGridViewTextBoxColumn direccionColumn = new DataGridViewTextBoxColumn();
            direccionColumn.DataPropertyName = "direccion";
            direccionColumn.Width = 160;
            direccionColumn.HeaderText = "direccion";
            direccionColumn.Frozen = true;
            direccionColumn.ValueType = typeof(string);
            datalistadopersona.Columns.Add(direccionColumn);

            DataGridViewTextBoxColumn telefonoColumn = new DataGridViewTextBoxColumn();
            telefonoColumn.DataPropertyName = "telefono";
            telefonoColumn.Width = 80;
            telefonoColumn.HeaderText = "telefono";
            telefonoColumn.Frozen = true;
            telefonoColumn.ValueType = typeof(string);
            datalistadopersona.Columns.Add(telefonoColumn);

            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.DataPropertyName = "email";
            emailColumn.Width = 150;
            emailColumn.HeaderText = "email";
            emailColumn.Frozen = true;
            emailColumn.ValueType = typeof(string);
            datalistadopersona.Columns.Add(emailColumn);
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            NE_Persona eld = new NE_Persona();
            try
            {
                datalistadopersona.Refresh();

                string parametro = "";
                int VARIABLE = 0;
                DSQL.Clear();
                //error
                if (TxtTipo.Text != "")
                {
                    if (VARIABLE != 1)
                    {
                        parametro = " tipo LIKE '%" + TxtTipo.Text + "%'";
                    }
                    else
                    {
                        parametro = parametro + " AND tipo LIKE '%" + TxtTipo.Text + "%'";
                    }
                    VARIABLE = 1;
                }
                //error
                if (TxtNombre.Text != "")
                {
                    if (VARIABLE != 1)
                    {
                        parametro = " nombre LIKE '%" + TxtNombre.Text + "%'";
                    }
                    else
                    {
                        parametro = parametro + " AND nombre  LIKE '%" + TxtNombre.Text + "%'";
                    }
                    VARIABLE = 1;
                }

                if (TxtIdentificacion.Text != "")
                {
                    if (VARIABLE != 1)
                    {
                        parametro = " identificacion LIKE '%" + TxtIdentificacion.Text + "%'";
                    }
                    else
                    {
                        parametro = parametro + " AND identificacion LIKE '%" + TxtIdentificacion.Text + "%'";
                    }
                    VARIABLE = 1;
                }


                string SQL = "SELECT idpersona,tipo_persona,nombre,tipo_documento,num_documento,direccion,telefono,email FROM dbo.rol";

                if (VARIABLE == 1)
                {
                    parametro = SQL + " WHERE " + parametro;
                }
                else
                {
                    parametro = SQL;
                }

                DSQL = eld.RN_Buscar_Recordpersona(parametro);
                datalistadopersona.AutoGenerateColumns = false;

                datalistadopersona.DataSource = DSQL;

                datalistadopersona.DataMember = "VerRecord";
                LblTotal.Visible = true;
                LblTotal.Text = DSQL.Tables["VerRecord"].Rows.Count.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(TxtTipo, TxtNombre, TxtIdentificacion);
            TxtTipo.Focus();

            //Cargar los Registros de los Clientes
            MostrarTodoslosRegistrosCargadospersona();
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
                MantPersona cargar = new MantPersona("0", "Creando Registro");
                cargar.ShowDialog();

                MostrarTodoslosRegistrosCargadospersona();  //roles
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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn cargar = new LogIn();
            cargar.ShowDialog();
        }

        private void tmrMensaje_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void TxtTipo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void msjdobleclick_Click(object sender, EventArgs e)
        {
            tmr2click.Stop();
            msjdobleclick.Visible = false;
        }

        private void tmr2click_Tick(object sender, EventArgs e)
        {
            if (msjdobleclick.Visible == true)
            {
                msjdobleclick.Visible = false;
            }
            else
            {
                msjdobleclick.Visible = true;
            }
        }

        private void datalistadopersona_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("hh:mm");
        }
        public static string Espacio(int n)
        {
            string s = " ";
            for (int i = 0; i <= n; i++) s += " ";
            return s;
        }
    }
}

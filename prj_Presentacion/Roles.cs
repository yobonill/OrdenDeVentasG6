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
    public partial class Roles : Form
    {
        DataSet DSQL = new DataSet();
        public string _Usuario;
        public Roles()
        {
            InitializeComponent();
        }

        public Roles(string usuario)
        {
            InitializeComponent();
            _Usuario = usuario;
        }
 

        protected void SelectToEditItem()
        {
            try
            {
                int fila = datalistadorol.CurrentRow.Index;

                if (datalistadorol.Rows.Count != 0)
                {
                    string id = Convert.ToInt32(datalistadorol.Rows[fila].Cells[0].Value).ToString();

                    MantRol cat = new MantRol(id, "Actualizando Registro");
                    cat.StartPosition = FormStartPosition.CenterScreen;
                    cat.ShowInTaskbar = false;
                    cat.ShowDialog();
                    //Refrescar Datagridview, cuando retorne
                    MostrarTodoslosRegistrosCargadosrol();  //Clientes
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

        private void Roles_Load(object sender, EventArgs e)
        {
            //Cargar los registros de roles
            MostrarTodoslosRegistrosCargadosrol();

            LblUsuario.Text = "Usuario Actual:   " + _Usuario;


            try
            {
                this.Text = "Configuracion de Roles (Grupo 6)" + Espacio(160);
                TmrMensaje.Enabled = true;

                DateTime hoy = DateTime.Now;
                LblFecha2.Text = hoy.ToString("dddd, dd MMMM yyyy");

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
            LblHora2.Text = DateTime.Now.ToString("hh:mm");
        }
        public static string Espacio(int n)
        {
            string s = " ";
            for (int i = 0; i <= n; i++) s += " ";
            return s;
        }
        private void MostrarTodoslosRegistrosCargadosrol()
        {
            try
            {
                NE_Rol Obj = new NE_Rol();
                DSQL = Obj.VerTodosLosrol();

                datalistadorol.AutoGenerateColumns = false;

                SetupColumnsCargadasrol(DSQL);

                datalistadorol.DataSource = DSQL;

                datalistadorol.DataMember = "VerRecord";
                Lbltotal.Visible = true;
                Lbltotal.Text = DSQL.Tables["VerRecord"].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetupColumnsCargadasrol(DataSet ds)
        {
            datalistadorol.Columns.Clear();

            datalistadorol.ScrollBars = ScrollBars.Both;

            datalistadorol.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            // Set the background color for all rows and for alternating rows.  
            // The value for alternating rows overrides the value for all rows. 
            datalistadorol.RowsDefaultCellStyle.BackColor = Color.White;
            datalistadorol.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;

            // Set the row and column header styles.
            datalistadorol.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datalistadorol.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            datalistadorol.RowHeadersDefaultCellStyle.BackColor = Color.Black;

            DataGridViewTextBoxColumn idrolColumn = new DataGridViewTextBoxColumn();
            idrolColumn.DataPropertyName = "idrol";
            idrolColumn.Width = 49;
            idrolColumn.HeaderText = "idrol";
            idrolColumn.Frozen = true;
            idrolColumn.ValueType = typeof(string);
            datalistadorol.Columns.Add(idrolColumn);

            DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
            nombreColumn.DataPropertyName = "nombre";
            nombreColumn.Width = 250;
            nombreColumn.HeaderText = "nombre";
            nombreColumn.Frozen = true;
            nombreColumn.ValueType = typeof(string);
            datalistadorol.Columns.Add(nombreColumn);

            DataGridViewTextBoxColumn descripcionColumn = new DataGridViewTextBoxColumn();
            descripcionColumn.DataPropertyName = "descripcion";
            descripcionColumn.Width = 220;
            descripcionColumn.HeaderText = "descripcion";
            descripcionColumn.Frozen = true;
            descripcionColumn.ValueType = typeof(string);
            datalistadorol.Columns.Add(descripcionColumn);

            DataGridViewCheckBoxColumn EstatusColumn = new DataGridViewCheckBoxColumn();
            EstatusColumn.DataPropertyName = "estado";
            EstatusColumn.Width = 57;
            EstatusColumn.HeaderText = "estado";
            EstatusColumn.Frozen = true;
            EstatusColumn.ValueType = typeof(Boolean);
            datalistadorol.Columns.Add(EstatusColumn);
        }
 

        private void TmrMensaje_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsUser cargar = new SettingsUser();
            cargar.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Settings cargar = new Settings();
            cargar.ShowDialog();
        }

 

        private void Txtidrol_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void Txtnombre_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void Txtdescripcion_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void BtnBuscar_Click_2(object sender, EventArgs e)
        {
            NE_Rol eld = new NE_Rol();
            try
            {
                datalistadorol.Refresh();

                string parametro = "";
                int VARIABLE = 0;
                DSQL.Clear();
                //error
                if (Txtidrol.Text != "")
                {
                    if (VARIABLE != 1)
                    {
                        parametro = " idrol LIKE '%" + Txtidrol.Text + "%'";
                    }
                    else
                    {
                        parametro = parametro + " AND idrol LIKE '%" + Txtidrol.Text + "%'";
                    }
                    VARIABLE = 1;
                }
                //error
                if (Txtnombre.Text != "")
                {
                    if (VARIABLE != 1)
                    {
                        parametro = " nombre LIKE '%" + Txtnombre.Text + "%'";
                    }
                    else
                    {
                        parametro = parametro + " AND nombre  LIKE '%" + Txtnombre.Text + "%'";
                    }
                    VARIABLE = 1;
                }

                if (Txtdescripcion.Text != "")
                {
                    if (VARIABLE != 1)
                    {
                        parametro = " descripcion LIKE '%" + Txtdescripcion.Text + "%'";
                    }
                    else
                    {
                        parametro = parametro + " AND descripcion LIKE '%" + Txtdescripcion.Text + "%'";
                    }
                    VARIABLE = 1;
                }


                string SQL = "SELECT idrol,nombre,descripcion,estado FROM dbo.rol";

                if (VARIABLE == 1)
                {
                    parametro = SQL + " WHERE " + parametro;
                }
                else
                {
                    parametro = SQL;
                }

                DSQL = eld.RN_Buscar_Recordrol(parametro);
                datalistadorol.AutoGenerateColumns = false;

                datalistadorol.DataSource = DSQL;

                datalistadorol.DataMember = "VerRecord";
                Lbltotal.Visible = true;
                Lbltotal.Text = DSQL.Tables["VerRecord"].Rows.Count.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar(Txtidrol, Txtdescripcion, Txtnombre);
            Txtidrol.Focus();

            //Cargar los Registros de los Clientes
            MostrarTodoslosRegistrosCargadosrol();
        }
        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();

            }
        }

        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {
            try
            {
                MantRol cargar = new MantRol("0", "Creando Registro");
                cargar.ShowDialog();

                MostrarTodoslosRegistrosCargadosrol();  //roles
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
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

        private void label9_Click_1(object sender, EventArgs e)
        {
            Tmr2click.Stop();
            label9.Visible = false;
        }

        private void Tmr2click_Tick_1(object sender, EventArgs e)
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

        private void datalistadorol_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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

   
    }
}



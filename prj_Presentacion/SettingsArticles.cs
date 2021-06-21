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
    public partial class SettingsArticles : Form
    {
        DataSet DSQL = new DataSet();
        public string _Usuario;
        public SettingsArticles()
        {
            InitializeComponent();
        }
        public SettingsArticles(string usuario)
        {
            InitializeComponent();
            _Usuario = usuario;
        }
        protected void SelectToEditItem()
        {
            try
            {
                int fila = datalistadoarticulos.CurrentRow.Index;

                if (datalistadoarticulos.Rows.Count != 0)
                {
                    string id = Convert.ToInt32(datalistadoarticulos.Rows[fila].Cells[0].Value).ToString();

                    Manarticulo cat = new Manarticulo(id, "Actualizando Registro");
                    cat.StartPosition = FormStartPosition.CenterScreen;
                    cat.ShowInTaskbar = false;
                    cat.ShowDialog();
                    //Refrescar Datagridview, cuando retorne
                    MostrarTodoslosRegistrosCargadosarticulos();  //Clientes
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista de articulos",
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void datalistadoarticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn cargar = new LogIn();
            cargar.ShowDialog();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Manarticulo cargar = new Manarticulo("0", "Creando Registro");
                cargar.ShowDialog();

                MostrarTodoslosRegistrosCargadosarticulos();  //roles
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

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            categoria cargar = new categoria();
            cargar.ShowDialog();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(TxtCodigo, TxtNombre, TxtDescripcion);
            TxtCodigo.Focus();

            //Cargar los Registros de los Clientes
            MostrarTodoslosRegistrosCargadosarticulos();
        }
        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();

            }
        }




        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            NE_articulo eld = new NE_articulo();
            try
            {
                datalistadoarticulos.Refresh();

                string parametro = "";
                int VARIABLE = 0;
                DSQL.Clear();
                //error
                if (TxtCodigo.Text != "")
                {
                    if (VARIABLE != 1)
                    {
                        parametro = " codigo LIKE '%" + TxtCodigo.Text + "%'";
                    }
                    else
                    {
                        parametro = parametro + " AND codigo LIKE '%" + TxtCodigo.Text + "%'";
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

                if (TxtDescripcion.Text != "")
                {
                    if (VARIABLE != 1)
                    {
                        parametro = " descripcion LIKE '%" + TxtDescripcion.Text + "%'";
                    }
                    else
                    {
                        parametro = parametro + " AND descripcion LIKE '%" + TxtDescripcion.Text + "%'";
                    }
                    VARIABLE = 1;
                }


                string SQL = "SELECT idarticulo,idcategoria,codigo,nombre,precio_venta,stock,descripcion,estado FROM dbo.articulo";


                if (VARIABLE == 1)
                {
                    parametro = SQL + " WHERE " + parametro;
                }
                else
                {
                    parametro = SQL;
                }

                DSQL = eld.RN_Buscar_Recordarticulo(parametro);
                datalistadoarticulos.AutoGenerateColumns = false;

                datalistadoarticulos.DataSource = DSQL;

                datalistadoarticulos.DataMember = "VerRecord";
                LblTotal.Visible = true;
                LblTotal.Text = DSQL.Tables["VerRecord"].Rows.Count.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SettingsArticles_Load(object sender, EventArgs e)
        {
            //Cargar los registros de persona
            MostrarTodoslosRegistrosCargadosarticulos();

            //LblUsuario.Text = "Usuario Actual:   " + _Usuario;


            try
            {
                this.Text = "Configuracion de articulo (Grupo 6)" + Espacio(160);
                tmrMensaje.Enabled = true;

                DateTime hoy = DateTime.Now;
                LblFecha.Text = hoy.ToString("dddd, dd MMMM yyyy");

                // LblHora.Enabled = true;

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

        public static string Espacio(int n)
        {
            string s = " ";
            for (int i = 0; i <= n; i++) s += " ";
            return s;
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            //LblHora.Text = DateTime.Now.ToString("hh:mm");
        }
        private void MostrarTodoslosRegistrosCargadosarticulos()
        {
            try
            {
                NE_articulo Obj = new NE_articulo();
                DSQL = Obj.VerTodosLosarticulo();

                datalistadoarticulos.AutoGenerateColumns = false;

                SetupColumnsCargadasarticulos(DSQL);

                datalistadoarticulos.DataSource = DSQL;

                datalistadoarticulos.DataMember = "VerRecord";
                LblTotal.Visible = true;
                LblTotal.Text = DSQL.Tables["VerRecord"].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetupColumnsCargadasarticulos(DataSet ds)
        {
            datalistadoarticulos.Columns.Clear();

            datalistadoarticulos.ScrollBars = ScrollBars.Both;

            datalistadoarticulos.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            // Set the background color for all rows and for alternating rows.  
            // The value for alternating rows overrides the value for all rows. 
            datalistadoarticulos.RowsDefaultCellStyle.BackColor = Color.White;
            datalistadoarticulos.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;

            // Set the row and column header styles.
            datalistadoarticulos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datalistadoarticulos.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            datalistadoarticulos.RowHeadersDefaultCellStyle.BackColor = Color.Black;

            DataGridViewTextBoxColumn idarticuloColumn = new DataGridViewTextBoxColumn();
            idarticuloColumn.DataPropertyName = "idarticulo";
            idarticuloColumn.Width = 50;
            idarticuloColumn.HeaderText = "Id #";
            idarticuloColumn.Frozen = true;
            idarticuloColumn.ValueType = typeof(string);
            datalistadoarticulos.Columns.Add(idarticuloColumn);

            DataGridViewTextBoxColumn idcategoriaColumn = new DataGridViewTextBoxColumn();
            idcategoriaColumn.DataPropertyName = "idcategoria";
            idcategoriaColumn.Width = 75;
            idcategoriaColumn.HeaderText = "idcategoria";
            idcategoriaColumn.Frozen = true;
            idcategoriaColumn.ValueType = typeof(string);
            datalistadoarticulos.Columns.Add(idcategoriaColumn);

            DataGridViewTextBoxColumn codigoColumn = new DataGridViewTextBoxColumn();
            codigoColumn.DataPropertyName = "codigo";
            codigoColumn.Width = 150;
            codigoColumn.HeaderText = "codigo";
            codigoColumn.Frozen = true;
            codigoColumn.ValueType = typeof(string);
            datalistadoarticulos.Columns.Add(codigoColumn);

            DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
            nombreColumn.DataPropertyName = "nombre";
            nombreColumn.Width = 88;
            nombreColumn.HeaderText = "nombre";
            nombreColumn.Frozen = true;
            nombreColumn.ValueType = typeof(string);
            datalistadoarticulos.Columns.Add(nombreColumn);

            DataGridViewTextBoxColumn precio_ventaColumn = new DataGridViewTextBoxColumn();
            precio_ventaColumn.DataPropertyName = "precio_venta";
            precio_ventaColumn.Width = 100;
            precio_ventaColumn.HeaderText = "precio_venta";
            precio_ventaColumn.Frozen = true;
            precio_ventaColumn.ValueType = typeof(string);
            datalistadoarticulos.Columns.Add(precio_ventaColumn);

            DataGridViewTextBoxColumn stockColumn = new DataGridViewTextBoxColumn();
            stockColumn.DataPropertyName = "stock";
            stockColumn.Width = 160;
            stockColumn.HeaderText = " stock";
            stockColumn.Frozen = true;
            stockColumn.ValueType = typeof(string);
            datalistadoarticulos.Columns.Add(stockColumn);

            DataGridViewTextBoxColumn descripcionColumn = new DataGridViewTextBoxColumn();
            descripcionColumn.DataPropertyName = "descripcion";
            descripcionColumn.Width = 80;
            descripcionColumn.HeaderText = "descripcion";
            descripcionColumn.Frozen = true;
            descripcionColumn.ValueType = typeof(string);
            datalistadoarticulos.Columns.Add(descripcionColumn);

            DataGridViewTextBoxColumn estadoColumn = new DataGridViewTextBoxColumn();
            estadoColumn.DataPropertyName = "estado";
            estadoColumn.Width = 150;
            estadoColumn.HeaderText = "estado";
            estadoColumn.Frozen = true;
            estadoColumn.ValueType = typeof(string);
            datalistadoarticulos.Columns.Add(estadoColumn);
        }

        private void tmrMensaje_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
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

        private void msjdobleclick_Click(object sender, EventArgs e)
        {
            tmr2click.Stop();
            msjdobleclick.Visible = false;
        }

        private void datalistadoarticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

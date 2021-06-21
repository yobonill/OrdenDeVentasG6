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
    public partial class categoria : Form
    {
        DataSet DSQL = new DataSet();
        public string _Usuario;
        public categoria()
        {
            InitializeComponent();
        }
        public categoria(string usuario)
        {
            InitializeComponent();
            _Usuario = usuario;
        }
        private void SetupColumnsCargadascategorias(DataSet ds)
        {
            datalistadocategorias.Columns.Clear();

            datalistadocategorias.ScrollBars = ScrollBars.Both;

            datalistadocategorias.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            // Set the background color for all rows and for alternating rows.  
            // The value for alternating rows overrides the value for all rows. 
            datalistadocategorias.RowsDefaultCellStyle.BackColor = Color.White;
            datalistadocategorias.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;

            // Set the row and column header styles.
            datalistadocategorias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datalistadocategorias.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            datalistadocategorias.RowHeadersDefaultCellStyle.BackColor = Color.Black;

            DataGridViewTextBoxColumn idcategoriaColumn = new DataGridViewTextBoxColumn();
            idcategoriaColumn.DataPropertyName = "idcategoria";
            idcategoriaColumn.Width = 50;
            idcategoriaColumn.HeaderText = "Id #";
            idcategoriaColumn.Frozen = true;
            idcategoriaColumn.ValueType = typeof(string);
            datalistadocategorias.Columns.Add(idcategoriaColumn);

           
            DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
            nombreColumn.DataPropertyName = "nombre";
            nombreColumn.Width = 88;
            nombreColumn.HeaderText = "nombre";
            nombreColumn.Frozen = true;
            nombreColumn.ValueType = typeof(string);
            datalistadocategorias.Columns.Add(nombreColumn);

           
            DataGridViewTextBoxColumn descripcionColumn = new DataGridViewTextBoxColumn();
            descripcionColumn.DataPropertyName = "descripcion";
            descripcionColumn.Width = 80;
            descripcionColumn.HeaderText = "descripcion";
            descripcionColumn.Frozen = true;
            descripcionColumn.ValueType = typeof(string);
            datalistadocategorias.Columns.Add(descripcionColumn);

            DataGridViewTextBoxColumn estadoColumn = new DataGridViewTextBoxColumn();
            estadoColumn.DataPropertyName = "estado";
            estadoColumn.Width = 150;
            estadoColumn.HeaderText = "estado";
            estadoColumn.Frozen = true;
            estadoColumn.ValueType = typeof(string);
            datalistadocategorias.Columns.Add(estadoColumn);
        }

        private void MostrarTodoslosRegistrosCargadoscategorias()
        {
            try
            {
                NE_categoria Obj = new NE_categoria();
                DSQL = Obj.VerTodosLoscategoria();

                datalistadocategorias.AutoGenerateColumns = false;

                SetupColumnsCargadascategorias(DSQL);

                datalistadocategorias.DataSource = DSQL;

                datalistadocategorias.DataMember = "VerRecord";
                LblTotal.Visible = true;
                LblTotal.Text = DSQL.Tables["VerRecord"].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        protected void SelectToEditItem()
        {
            try
            {
                int fila = datalistadocategorias.CurrentRow.Index;

                if (datalistadocategorias.Rows.Count != 0)
                {
                    string id = Convert.ToInt32(datalistadocategorias.Rows[fila].Cells[0].Value).ToString();

                    Mancategoria cat = new Mancategoria(id, "Actualizando Registro");
                    cat.StartPosition = FormStartPosition.CenterScreen;
                    cat.ShowInTaskbar = false;
                    cat.ShowDialog();
                    //Refrescar Datagridview, cuando retorne
                    MostrarTodoslosRegistrosCargadoscategorias();  //Clientes
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista de categorias",
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
        public static string Espacio(int n)
        {
            string s = " ";
            for (int i = 0; i <= n; i++) s += " ";
            return s;
        }


        private void categoria_Load(object sender, EventArgs e)
        {
            //Cargar los registros de persona
            MostrarTodoslosRegistrosCargadoscategorias();

            //LblUsuario.Text = "Usuario Actual:   " + _Usuario;


            try
            {
                this.Text = "Configuracion de categoria (Grupo 6)" + Espacio(160);
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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn cargar = new LogIn();
            cargar.ShowDialog();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            NE_categoria eld = new NE_categoria();
            try
            {
                datalistadocategorias.Refresh();

                string parametro = "";
                int VARIABLE = 0;
                DSQL.Clear();
                //error
                if (TxtCodigo.Text != "")
                {
                    if (VARIABLE != 1)
                    {
                        parametro = "idcategoria LIKE '%" + TxtCodigo.Text + "%'";
                    }
                    else
                    {
                        parametro = parametro + " AND idcategoria LIKE '%" + TxtCodigo.Text + "%'";
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


                string SQL = "SELECT idcategoria,nombre,descripcion,estado FROM dbo.categoria";


                if (VARIABLE == 1)
                {
                    parametro = SQL + " WHERE " + parametro;
                }
                else
                {
                    parametro = SQL;
                }

                DSQL = eld.RN_Buscar_Recordcategoria(parametro);
                datalistadocategorias.AutoGenerateColumns = false;

                datalistadocategorias.DataSource = DSQL;

                datalistadocategorias.DataMember = "VerRecord";
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
            Limpiar(TxtCodigo, TxtNombre, TxtDescripcion);
            TxtCodigo.Focus();

            //Cargar los Registros de los Clientes
            MostrarTodoslosRegistrosCargadoscategorias();
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
                Mancategoria cargar = new Mancategoria("0", "Creando Registro");
                cargar.ShowDialog();

                MostrarTodoslosRegistrosCargadoscategorias();  //roles
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsArticles cargar = new SettingsArticles();
            cargar.ShowDialog();


        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }

        private void LblHora_Click(object sender, EventArgs e)
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

        private void datalistadocategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datalistadocategorias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datalistadocategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

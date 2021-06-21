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
using Prj_Entidades;
using Validador;

namespace prj_Presentacion
{
    public partial class Mancategoria : Form
    {
        public bool valor = false;
        public string _Codigo, _Mensaje;
        public Mancategoria()

        {
            InitializeComponent();
        }
        public Mancategoria(string codi, string mensa)
        {
            InitializeComponent();
            _Codigo = codi;
            _Mensaje = mensa;
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            // this.categoriaBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.datUsuario);

        }

        private void Mancategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datUsuario.categoria' Puede moverla o quitarla según sea necesario.
            // this.categoriaTableAdapter.Fill(this.datUsuario.categoria);

        }

      
        

        

        private void BTNAyuda_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(@"c:\Ayuda\Matenimiento_a_usuarios.pdf");

        }
        private void ClearErrors()
        {
            this.errorProvider1.SetError(this.nombreTextBox, null);
        }

        public bool validar()
        {
            ClearErrors();
            if (string.IsNullOrEmpty(this.nombreTextBox.Text))
            {
                this.errorProvider1.SetError(this.nombreTextBox, ValidatorMessagesR.FIELD_REQUIRED);
                valor = false;
            }
            else
            {
                ClearErrors();
                valor = true;
            }
            return valor;
        }
        public void Limpiar(params TextBox[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i].Clear();
            }
        }

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(idcategoriaTextBox, idcategoriaTextBox,nombreTextBox,descripcionTextBox);
            idcategoriaTextBox.Focus();
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                NE_categoria RecI = new NE_categoria();
                EN_categoria RecImp = new EN_categoria();

                //Verificar si existe el No. de Record

                bool valida = false;

                if (idcategoriaTextBox.Text == "")
                {
                    idcategoriaTextBox.Text = "0";
                }
                valida = RecI.BusquedaRecord(int.Parse(idcategoriaTextBox.Text));

                if (valida)
                {
                    if (MessageBox.Show("¿Está seguro de eliminar de la lista de categoria a " +
                        idcategoriaTextBox.Text + " " + nombreTextBox.Text + " ? ",
                        "Eliminar categoria de lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        RecImp.Idcategoria = int.Parse(idcategoriaTextBox.Text);
                        RecI.RN_Eliminar_categoria(RecImp);

                        MessageBox.Show("Registro eliminado con exito.", "Eliminar",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        BTNLimpiar.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Persona # " + idcategoriaTextBox.Text + " No existe", "Eliminar", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    BTNLimpiar.PerformClick();
                }
            }
            catch (Exception)
            {
                throw;
            }


        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void idcategoriaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {

                e.Handled = true;
                //Validar si el codigo del cliente no esta en blanco

                NE_categoria obj = new NE_categoria();
                DataTable data = new DataTable();

                //hacer una busqueda en sql para filtrar el codigo del cliente que se 
                //esta buscando
                data = obj.RN_Buscar_categoriaxNocategoria(idcategoriaTextBox.Text);

                //luego de buscar el codigo del cliente
                //valida si existe el codigo del cliente
                if (data.Rows.Count > 0)  //si es mayor que cero, significa que lo encontro
                {

                   
                    idcategoriaTextBox.Text = Convert.ToString(data.Rows[0]["idcategoria"]);
                    nombreTextBox.Text = Convert.ToString(data.Rows[0]["nombre"]);
                    descripcionTextBox.Text = Convert.ToString(data.Rows[0]["descripcion"]);
                    int RetenerEstado = Convert.ToInt16(data.Rows[0]["Estado"]);


                    if (RetenerEstado == 1)
                    {
                        estadoCheckBox.Checked = true;
                    }
                    else
                    {
                        estadoCheckBox.Checked = false;
                    }

                }
                //Muestra mensaje en caso de buscar este cliente y no exista
                else
                {
                    nombreTextBox.Clear();
                    descripcionTextBox.Text = "";

                    MessageBox.Show("categoria No. " + idcategoriaTextBox.Text + " No existe");
                    idcategoriaTextBox.Text = "";
                    nombreTextBox.Focus();

                }
            }


        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {


            try
            {
                NE_categoria RecI = new NE_categoria();
                EN_categoria RecImp = new EN_categoria();

                //Verificar si existe el No. de Record
                bool valida = false;

                if (idcategoriaTextBox.Text == "")
                {
                    idcategoriaTextBox.Text = "0";
                }
                //OJO!!! campo de texto
                valida = RecI.BusquedaRecord(int.Parse(idcategoriaTextBox.Text));

                if (valida)
                {
                    if (validar())
                    {

                        
                        RecImp.Idcategoria = int.Parse(idcategoriaTextBox.Text);
                        RecImp.Nombre = nombreTextBox.Text;
                        RecImp.Descripcion = descripcionTextBox.Text;

                        if (estadoCheckBox.Checked == true)
                        {
                            RecImp.Estado = true;
                        }
                        else
                        {
                            RecImp.Estado = false;
                        }

                        RecI.RN_Actualizar_categoria(RecImp);

                        MessageBox.Show("Registro actualizado con exito.", "Actualizar", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        BTNLimpiar.PerformClick();
                    }
                }
                //insertar registro
                else
                {
                    if (validar())
                    {


                        RecImp.Idcategoria = int.Parse(idcategoriaTextBox.Text);
                        RecImp.Nombre = nombreTextBox.Text;
                        RecImp.Descripcion = descripcionTextBox.Text;

                        
                        if (idcategoriaTextBox.Text == "")
                        {
                            idcategoriaTextBox.Text = "0";
                        }
                      

                        //RecImp.Password1 = passwordTextBox.Text;
                        //RecImp.Num_documento1 = num_documentoTextBox.Text;
                        //RecImp.Direccion1 = direccionTextBox.Text;
                        //RecImp.Telefono1 = telefonoTextBox.Text;
                        //RecImp.Email1 = emailTextBox.Text;

                        if (estadoCheckBox.Checked == true)
                        {
                            RecImp.Estado = true;
                        }
                        else
                        {
                            RecImp.Estado = false;
                        }

                        RecI.RN_Registrar_categoria(RecImp);

                        MessageBox.Show("Registro agregado con exito.", "Agregado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        BTNLimpiar.PerformClick();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
